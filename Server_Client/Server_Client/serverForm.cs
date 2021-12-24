using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Client
{
    public partial class serverForm : Form
    {
        public serverForm() 
        {
            InitializeComponent();

            Server.path = "D:/Nam3_HK1/PHL4/ReceiveFilefromClient";
            
        }
        public static string path;
        public static string MessageCurrent = "Stopped";
        public static int luot = 0;
        private void serverForm_Load(object sender, EventArgs e)
        {
                if (Server.path.Length > 0)
                {   
                    backgroundWorker1.RunWorkerAsync();
                                                        
                }
                else
                {
                    MessageBox.Show("Not Receive File");

                }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Server.MessageCurrent + Environment.NewLine + Server.path;
        }

        Server server;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //if (this.backgroundWorker1.CancellationPending)
                //{
                //    e.Cancel = true;
                //    return;
                //}
                server = new Server();
                //luot += 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void serverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //server.EndServer();
        }

        //private void Reset_Click(object sender, EventArgs e)
        //{
        //    if (Server.path.Length > 0 && luot > 0)
        //    {
        //        backgroundWorker1.RunWorkerAsync();
        //    }
        //    else
        //    {
                
        //    }
        //}
    }
}
