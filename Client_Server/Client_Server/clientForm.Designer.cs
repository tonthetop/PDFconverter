namespace Client_Server
{
    partial class clientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txbFileName = new System.Windows.Forms.TextBox();
            this.btnUpFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.btnConvertPDF = new System.Windows.Forms.Button();
            this.btnConvertTxt = new System.Windows.Forms.Button();
            this.btnConvertDoc = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.myProgressBar = new Client_Server.CustomControl1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(66, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Idle";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // txbFileName
            // 
            this.txbFileName.Location = new System.Drawing.Point(55, 19);
            this.txbFileName.Name = "txbFileName";
            this.txbFileName.ReadOnly = true;
            this.txbFileName.Size = new System.Drawing.Size(356, 20);
            this.txbFileName.TabIndex = 16;
            // 
            // btnUpFile
            // 
            this.btnUpFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(133)))));
            this.btnUpFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(133)))));
            this.btnUpFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.btnUpFile.Location = new System.Drawing.Point(431, 12);
            this.btnUpFile.Name = "btnUpFile";
            this.btnUpFile.Size = new System.Drawing.Size(98, 33);
            this.btnUpFile.TabIndex = 15;
            this.btnUpFile.Text = "Upload File";
            this.btnUpFile.UseVisualStyleBackColor = false;
            this.btnUpFile.Click += new System.EventHandler(this.btnUpFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-55, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "File Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(133)))));
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "State: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(133)))));
            this.label4.Location = new System.Drawing.Point(232, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Port:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(133)))));
            this.label5.Location = new System.Drawing.Point(17, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "IP:";
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(283, 227);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(130, 20);
            this.txbPort.TabIndex = 26;
            this.txbPort.Text = "5000";
            this.txbPort.Visible = false;
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(55, 227);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(127, 20);
            this.txbIP.TabIndex = 25;
            this.txbIP.Text = "127.0.0.1";
            // 
            // btnConvertPDF
            // 
            this.btnConvertPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(133)))));
            this.btnConvertPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertPDF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertPDF.Image")));
            this.btnConvertPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertPDF.Location = new System.Drawing.Point(3, 3);
            this.btnConvertPDF.Name = "btnConvertPDF";
            this.btnConvertPDF.Size = new System.Drawing.Size(210, 66);
            this.btnConvertPDF.TabIndex = 24;
            this.btnConvertPDF.Text = "Convert to PDF";
            this.btnConvertPDF.UseVisualStyleBackColor = false;
            this.btnConvertPDF.Click += new System.EventHandler(this.btnConvertPDF_Click);
            // 
            // btnConvertTxt
            // 
            this.btnConvertTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(133)))));
            this.btnConvertTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertTxt.ForeColor = System.Drawing.Color.White;
            this.btnConvertTxt.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertTxt.Image")));
            this.btnConvertTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertTxt.Location = new System.Drawing.Point(3, 218);
            this.btnConvertTxt.Name = "btnConvertTxt";
            this.btnConvertTxt.Size = new System.Drawing.Size(210, 66);
            this.btnConvertTxt.TabIndex = 23;
            this.btnConvertTxt.Text = "Convert to Text";
            this.btnConvertTxt.UseVisualStyleBackColor = false;
            this.btnConvertTxt.Click += new System.EventHandler(this.btnConvertTxt_Click);
            // 
            // btnConvertDoc
            // 
            this.btnConvertDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(133)))));
            this.btnConvertDoc.FlatAppearance.BorderSize = 0;
            this.btnConvertDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertDoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertDoc.Image")));
            this.btnConvertDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertDoc.Location = new System.Drawing.Point(4, 146);
            this.btnConvertDoc.Name = "btnConvertDoc";
            this.btnConvertDoc.Size = new System.Drawing.Size(208, 66);
            this.btnConvertDoc.TabIndex = 22;
            this.btnConvertDoc.Text = "        Convert to Word.doc";
            this.btnConvertDoc.UseVisualStyleBackColor = false;
            this.btnConvertDoc.Click += new System.EventHandler(this.btnConvertDoc_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(133)))));
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Image = ((System.Drawing.Image)(resources.GetObject("btnConvert.Image")));
            this.btnConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvert.Location = new System.Drawing.Point(3, 74);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(210, 66);
            this.btnConvert.TabIndex = 21;
            this.btnConvert.Text = "          Convert to Word.docx";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(133)))));
            this.label6.Location = new System.Drawing.Point(17, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "File: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnConvertPDF);
            this.panel1.Controls.Add(this.btnConvert);
            this.panel1.Controls.Add(this.btnConvertDoc);
            this.panel1.Controls.Add(this.btnConvertTxt);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 289);
            this.panel1.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(133)))));
            this.label7.Location = new System.Drawing.Point(418, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "PDF Converter";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbFileName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txbPort);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.myProgressBar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnUpFile);
            this.panel2.Controls.Add(this.txbIP);
            this.panel2.Location = new System.Drawing.Point(222, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 252);
            this.panel2.TabIndex = 35;
            // 
            // myProgressBar
            // 
            this.myProgressBar.Location = new System.Drawing.Point(55, 129);
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.Size = new System.Drawing.Size(356, 23);
            this.myProgressBar.TabIndex = 31;
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(780, 295);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "clientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.clientForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txbFileName;
        private System.Windows.Forms.Button btnUpFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Button btnConvertPDF;
        private System.Windows.Forms.Button btnConvertTxt;
        private System.Windows.Forms.Button btnConvertDoc;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label6;
        private CustomControl1 myProgressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}

