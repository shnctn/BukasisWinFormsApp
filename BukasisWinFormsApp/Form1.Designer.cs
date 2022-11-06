namespace BukasisWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblot = new System.Windows.Forms.Label();
            this.lblOturum = new System.Windows.Forms.Label();
            this.btnKBG = new System.Windows.Forms.Button();
            this.btnYGGBG = new System.Windows.Forms.Button();
            this.btnHasta = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(253, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 172);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Giriş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Şifreniz ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kullanıcı Kodu";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblot
            // 
            this.lblot.AutoSize = true;
            this.lblot.Location = new System.Drawing.Point(117, 3);
            this.lblot.Name = "lblot";
            this.lblot.Size = new System.Drawing.Size(102, 15);
            this.lblot.TabIndex = 9;
            this.lblot.Text = "Oturum Kodunuz:";
            this.lblot.Visible = false;
            // 
            // lblOturum
            // 
            this.lblOturum.AutoSize = true;
            this.lblOturum.Location = new System.Drawing.Point(225, 3);
            this.lblOturum.Name = "lblOturum";
            this.lblOturum.Size = new System.Drawing.Size(26, 15);
            this.lblOturum.TabIndex = 10;
            this.lblOturum.Text = "test";
            this.lblOturum.Visible = false;
            // 
            // btnKBG
            // 
            this.btnKBG.Location = new System.Drawing.Point(237, 31);
            this.btnKBG.Name = "btnKBG";
            this.btnKBG.Size = new System.Drawing.Size(296, 23);
            this.btnKBG.TabIndex = 11;
            this.btnKBG.Text = "Kullanici Bilgileri Getir";
            this.btnKBG.UseVisualStyleBackColor = true;
            this.btnKBG.Visible = false;
            this.btnKBG.Click += new System.EventHandler(this.btnKBG_Click);
            // 
            // btnYGGBG
            // 
            this.btnYGGBG.Location = new System.Drawing.Point(237, 81);
            this.btnYGGBG.Name = "btnYGGBG";
            this.btnYGGBG.Size = new System.Drawing.Size(296, 23);
            this.btnYGGBG.TabIndex = 12;
            this.btnYGGBG.Text = "Yatak Genel Gorunum Bilgileri Getir";
            this.btnYGGBG.UseVisualStyleBackColor = true;
            this.btnYGGBG.Visible = false;
            this.btnYGGBG.Click += new System.EventHandler(this.btnYGGBG_Click);
            // 
            // btnHasta
            // 
            this.btnHasta.Location = new System.Drawing.Point(616, 131);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(156, 23);
            this.btnHasta.TabIndex = 13;
            this.btnHasta.Text = "Hasta Klinik Notu Ekle";
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Visible = false;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(12, 170);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(760, 389);
            this.rtb.TabIndex = 14;
            this.rtb.Text = "";
            this.rtb.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btnHasta);
            this.Controls.Add(this.btnYGGBG);
            this.Controls.Add(this.btnKBG);
            this.Controls.Add(this.lblOturum);
            this.Controls.Add(this.lblot);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUKASIS SAGLIK TEST";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Label lblot;
        private Label lblOturum;
        private Button btnKBG;
        private Button btnYGGBG;
        private Button btnHasta;
        private RichTextBox rtb;
    }
}