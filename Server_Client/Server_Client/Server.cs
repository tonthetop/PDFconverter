using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using System.Windows.Forms;
using System.Diagnostics;
using SautinSoft.Document;
using System.Threading;

namespace Server_Client
{
    class Server
    {
        IPEndPoint end;
        Socket sock;
        
        public Server()
        {
            end = new IPEndPoint(IPAddress.Any, 5000);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            sock.Bind(end);
            sock.Listen(5);
            Thread thrd = new Thread(StartServer);
            thrd.Start();
            
        }
        //public void EndServer()
        //{
        //    thrd.Abort();
        //}
        public static string path;
        public static string MessageCurrent = "Waiting";
        public void StartServer()
        {
            while (true)
            {
                Socket clientSocket = sock.Accept();
                HandleClient client = new HandleClient();
                client.StartClient(clientSocket);
            }
        }

        public class HandleClient
        {
            Socket clientSocket;
            public void StartClient(Socket clientSock)
            {
                this.clientSocket = clientSock;            
                Thread thrdClient = new Thread(Function);
                thrdClient.Start();
            }
            public void Function()
            {
                try
                {   //Khoi tao thah phan
                    //Socket clientSock = sock.Accept();
                    byte[] clientData = new byte[15000*1024];
                    while (true)
                    {
                        MessageCurrent = "It work and look for files";

                        //Thread thrdFunction = new Thread(ReceiveFile); //se lam o day
                        //while (true)
                        //byte[] clientData = new byte[1024 * 5000];
                        //Nhan file
                        int receiveByteLen = clientSocket.Receive(clientData); //do value vao clientData

                        if (CheckStateSocket(clientSocket) == false) return;

                        string filePath_type = HandleClient.ReceiveAndWrite(clientData, receiveByteLen); //***
                        //Load va ConvertFile
                        string docName = HandleClient.LoadAndConvert(filePath_type);
                        //Load va Gui File
                        byte[] serverData = HandleClient.LoadAndSendClient(docName);
                        //Kiem tra vao giai doan dau tien - Neu clientsock kh phan hoi thi return                
                       
                        if (CheckStateSocket(clientSocket) == false) return;
                        else clientSocket.Send(serverData);
                        //clientSock.Send(serverData);
                        //clientSock.Close(); 
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public static bool CheckStateSocket(Socket clientSocket)
            {
                bool part1 = clientSocket.Poll(1000, SelectMode.SelectRead);
                bool part2 = (clientSocket.Available == 0);
                if (part1 && part2) return false;
                return true;
            }
            public static string ReceiveAndWrite(byte[] clientData, int receiveByteLen)
            {
                try
                {
                    MessageCurrent = "Receiving File...";
                    System.Threading.Thread.Sleep(500);
                    int fNameLen = BitConverter.ToInt32(clientData, 0); //
                    string fName = Encoding.ASCII.GetString(clientData, 4, fNameLen);//bat dau` tu byte thu 4, chieu dai fNameLen
                                                                                     //
                    string convertType = fName.Substring(fName.IndexOf("/") + 1);
                    fName = fName.Substring(0, fName.IndexOf("/"));
                    //MessageBox.Show(fName + "|" + convertType);
                    //
                    string filePath = path + "/" + fName;
                    BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create));
                    writer.Write(clientData, 4 + fNameLen, receiveByteLen - 4 - fNameLen);
                    MessageCurrent = "Saving file at: " + filePath;
                    System.Threading.Thread.Sleep(1000);
                    writer.Flush();
                    writer.Close();
                    return filePath + "/" + convertType;
                }
                catch (Exception ex)
                {
                    MessageCurrent = "Error in Receive & Write";
                    MessageBox.Show(ex.Message);

                }
                return "";
            }
            public static string LoadAndConvert(string filePath_type)
            {
                try
                {
                    MessageCurrent = "Converting...";

                    string fileUp = "";
                    string convertType = "";
                    filePath_type = filePath_type.Replace("\\", "/");
                    while (filePath_type.IndexOf("/") > -1)
                    {
                        fileUp += filePath_type.Substring(0, filePath_type.IndexOf("/") + 1);
                        filePath_type = filePath_type.Substring(filePath_type.IndexOf("/") + 1);
                    }
                    fileUp = fileUp.Substring(0, fileUp.Length - 1);
                    convertType = filePath_type;
                    string docName = "false";
                    switch (convertType)
                    {
                        case "docx": docName = HandleClient.ToWordDOCX(fileUp); break;
                        case "doc": docName = HandleClient.ToWordDoc(fileUp); break;
                        case "pdf": docName = HandleClient.ToPDF(fileUp); break;
                        case "txt": docName = HandleClient.ToText(fileUp); break;
                        default:
                            MessageBox.Show("Khong co dinh dang nao duoc chon!"); break;
                    }
                    return docName;
                }
                catch (Exception ex)
                {
                    MessageCurrent = "Error in Load & Convert";
                    MessageBox.Show(ex.Message);
                }
                return "";
            }
            public static byte[] LoadAndSendClient(string docName)
            {
                try
                {
                    string fName = docName;
                    fName = fName.Replace("\\", "/");
                    while (fName.IndexOf("/") > -1)
                    {
                        fName = fName.Substring(fName.IndexOf("/") + 1);

                    }
                    //Gui
                    byte[] fNameByte = Encoding.ASCII.GetBytes(fName);
                    byte[] fileData = File.ReadAllBytes(docName);
                    byte[] serverData = new byte[4 + fNameByte.Length + fileData.Length];
                    byte[] fNameLen_server = BitConverter.GetBytes(fNameByte.Length);
                    fNameLen_server.CopyTo(serverData, 0);
                    fNameByte.CopyTo(serverData, 4);
                    fileData.CopyTo(serverData, 4 + fNameByte.Length);

                    MessageCurrent = "The file was sent back";
                    System.Threading.Thread.Sleep(500);                   
                    return serverData;
                }
                catch (Exception ex)
                {
                    MessageCurrent = "Error in Load & SendClient";
                    MessageBox.Show(ex.Message);
                }
                return null;

            }
           
            public static string ToWordDOCX(string fileUp)
            {
                string filePath = fileUp.Replace("\\", "/");
                string docName = filePath.Substring(0, filePath.Length - 4) + "_converted.docx"; // c?t .pdf hoac .txt r?i thêm duôi .docx
                if (fileUp.Contains(".pdf"))
                {
                    //PDDocument doc = PDDocument.load(fileUp);
                    //PDFTextStripper stripper = new PDFTextStripper();
                    //SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
                    //f.OpenPdf(filePath);
                    //if (f.PageCount > 0)
                    //{
                    //    f.WordOptions.Format = SautinSoft.PdfFocus.CWordOptions.eWordDocument.Docx;
                    //    f.ToWord(docName);
                    //}
                    DocumentCore dc = DocumentCore.Load(filePath);
                    dc.Save(docName);
                    //  Process.Start(docName);
                }
                else if (fileUp.Contains(".txt") || fileUp.Contains(".doc"))
                {
                    DocumentCore dc = DocumentCore.Load(filePath);

                    dc.Save(docName);
                    // Process.Start(docName);
                }
                else MessageBox.Show("File must be PDF extension");
                return docName;
            }
            public static string ToWordDoc(string fileUp)
            {
                string filePath = fileUp.Replace("\\", "/");
                string docName;
                if (fileUp.Contains(".docx"))
                {
                    docName = filePath.Substring(0, filePath.Length - 5) + "_converted.doc";
                }
                else { docName = filePath.Substring(0, filePath.Length - 4) + "_converted.doc"; }
                if (fileUp.Contains(".pdf"))
                {
                    PDDocument doc = PDDocument.load(fileUp);
                    PDFTextStripper stripper = new PDFTextStripper();
                    DocumentCore dc = DocumentCore.Load(filePath);
                    dc.Save(docName);
                    // Process.Start(docName);
                }
                else if (fileUp.Contains(".txt") || fileUp.Contains(".docx"))
                {
                    DocumentCore dc = DocumentCore.Load(filePath);

                    dc.Save(docName);
                    //  Process.Start(docName);
                }
                else MessageBox.Show("File must be different extension");
                return docName;
            }
            public static string ToText(string fileUp)
            {
                string filePath = fileUp.Replace("\\", "/");
                string docName;
                if (fileUp.Contains(".docx"))
                {
                    docName = filePath.Substring(0, filePath.Length - 5) + "_converted.txt";
                }
                else { docName = filePath.Substring(0, filePath.Length - 4) + "_converted.txt"; }
                if (fileUp.Contains(".pdf"))
                {
                    //PDDocument doc = PDDocument.load(fileUp);
                    //PDFTextStripper stripper = new PDFTextStripper();
                    //SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
                    //f.OpenPdf(filePath);
                    //if (f.PageCount > 0)
                    //{
                    //    //f.WordOptions.Format = SautinSoft.PdfFocus.CWordOptions.eWordDocument.Docx;
                    //    f.ToText(docName);
                    //}
                    DocumentCore dc = DocumentCore.Load(filePath);
                    dc.Save(docName);
                    //f.ClosePdf();

                    //Process.Start(docName);
                }
                else if (fileUp.Contains(".docx") || fileUp.Contains(".doc"))
                {
                    DocumentCore dc = DocumentCore.Load(filePath);
                    dc.Save(docName);
                    // Process.Start(docName);
                }
                else MessageBox.Show("File must be PDF extension");
                return docName;
            }
            public static string ToPDF(string fileUp)
            {
                string filePath = fileUp.Replace("\\", "/");
                string docName;
                if (fileUp.Contains(".docx"))
                {
                    docName = filePath.Substring(0, filePath.Length - 5) + "_converted.pdf";
                }
                else { docName = filePath.Substring(0, filePath.Length - 4) + "_converted.pdf"; }
                if (fileUp.Contains(".docx") || fileUp.Contains(".doc") || fileUp.Contains(".txt"))
                {
                    DocumentCore dc = DocumentCore.Load(filePath);
                    dc.Save(docName);
                    //Process.Start(docName);
                }
                return docName;
            }
        }
}
}
