namespace FullTextSearch
{
    partial class Form1
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
            this.gb_unosPodataka = new System.Windows.Forms.GroupBox();
            this.button_unosTekstaUBazu = new System.Windows.Forms.Button();
            this.rTB_unosTextaUBazu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.linkLabel_Rezultat = new System.Windows.Forms.LinkLabel();
            this.labelBrojac = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtn_Fuzzy = new System.Windows.Forms.RadioButton();
            this.rbtn_Rijecnici = new System.Windows.Forms.RadioButton();
            this.rbtnNeizmjenjeni = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_OR = new System.Windows.Forms.RadioButton();
            this.rbtn_AND = new System.Windows.Forms.RadioButton();
            this.button_Pretrazi = new System.Windows.Forms.Button();
            this.textBox_Pretrazivanje = new System.Windows.Forms.TextBox();
            this.groupBox_Connect = new System.Windows.Forms.GroupBox();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Database = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.gb_unosPodataka.SuspendLayout();
            this.groupBox_Search.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Connect.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_unosPodataka
            // 
            this.gb_unosPodataka.Controls.Add(this.button_unosTekstaUBazu);
            this.gb_unosPodataka.Controls.Add(this.rTB_unosTextaUBazu);
            this.gb_unosPodataka.Controls.Add(this.label1);
            this.gb_unosPodataka.Location = new System.Drawing.Point(12, 261);
            this.gb_unosPodataka.Name = "gb_unosPodataka";
            this.gb_unosPodataka.Size = new System.Drawing.Size(231, 445);
            this.gb_unosPodataka.TabIndex = 0;
            this.gb_unosPodataka.TabStop = false;
            this.gb_unosPodataka.Text = "Unos podataka";
            // 
            // button_unosTekstaUBazu
            // 
            this.button_unosTekstaUBazu.Location = new System.Drawing.Point(6, 151);
            this.button_unosTekstaUBazu.Name = "button_unosTekstaUBazu";
            this.button_unosTekstaUBazu.Size = new System.Drawing.Size(216, 23);
            this.button_unosTekstaUBazu.TabIndex = 1;
            this.button_unosTekstaUBazu.Text = "Dodaj u bazu podataka";
            this.button_unosTekstaUBazu.UseVisualStyleBackColor = true;
            this.button_unosTekstaUBazu.Click += new System.EventHandler(this.button_unosTekstaUBazu_Click);
            // 
            // rTB_unosTextaUBazu
            // 
            this.rTB_unosTextaUBazu.Location = new System.Drawing.Point(6, 49);
            this.rTB_unosTextaUBazu.Name = "rTB_unosTextaUBazu";
            this.rTB_unosTextaUBazu.Size = new System.Drawing.Size(216, 96);
            this.rTB_unosTextaUBazu.TabIndex = 1;
            this.rTB_unosTextaUBazu.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite text za unos u bazu podataka:";
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.linkLabel_Rezultat);
            this.groupBox_Search.Controls.Add(this.labelBrojac);
            this.groupBox_Search.Controls.Add(this.label2);
            this.groupBox_Search.Controls.Add(this.richTextBox1);
            this.groupBox_Search.Controls.Add(this.groupBox3);
            this.groupBox_Search.Controls.Add(this.groupBox2);
            this.groupBox_Search.Controls.Add(this.button_Pretrazi);
            this.groupBox_Search.Controls.Add(this.textBox_Pretrazivanje);
            this.groupBox_Search.Location = new System.Drawing.Point(249, 12);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(669, 694);
            this.groupBox_Search.TabIndex = 1;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Pretraživanje";
            // 
            // linkLabel_Rezultat
            // 
            this.linkLabel_Rezultat.AutoSize = true;
            this.linkLabel_Rezultat.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
            this.linkLabel_Rezultat.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_Rezultat.Location = new System.Drawing.Point(3, 438);
            this.linkLabel_Rezultat.Name = "linkLabel_Rezultat";
            this.linkLabel_Rezultat.Size = new System.Drawing.Size(117, 17);
            this.linkLabel_Rezultat.TabIndex = 11;
            this.linkLabel_Rezultat.TabStop = true;
            this.linkLabel_Rezultat.Text = "Rezultat pretraživanja:";
            this.linkLabel_Rezultat.UseCompatibleTextRendering = true;
            // 
            // labelBrojac
            // 
            this.labelBrojac.AutoSize = true;
            this.labelBrojac.Location = new System.Drawing.Point(3, 397);
            this.labelBrojac.Name = "labelBrojac";
            this.labelBrojac.Size = new System.Drawing.Size(0, 13);
            this.labelBrojac.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Upit prema bazi podataka:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 206);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(645, 188);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtn_Fuzzy);
            this.groupBox3.Controls.Add(this.rbtn_Rijecnici);
            this.groupBox3.Controls.Add(this.rbtnNeizmjenjeni);
            this.groupBox3.Location = new System.Drawing.Point(212, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 50);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // rbtn_Fuzzy
            // 
            this.rbtn_Fuzzy.AutoSize = true;
            this.rbtn_Fuzzy.Location = new System.Drawing.Point(307, 19);
            this.rbtn_Fuzzy.Name = "rbtn_Fuzzy";
            this.rbtn_Fuzzy.Size = new System.Drawing.Size(126, 17);
            this.rbtn_Fuzzy.TabIndex = 9;
            this.rbtn_Fuzzy.TabStop = true;
            this.rbtn_Fuzzy.Text = "Fuzzy string matching";
            this.rbtn_Fuzzy.UseVisualStyleBackColor = true;
            this.rbtn_Fuzzy.CheckedChanged += new System.EventHandler(this.rbtn_Fuzzy_CheckedChanged);
            // 
            // rbtn_Rijecnici
            // 
            this.rbtn_Rijecnici.AutoSize = true;
            this.rbtn_Rijecnici.Location = new System.Drawing.Point(170, 19);
            this.rbtn_Rijecnici.Name = "rbtn_Rijecnici";
            this.rbtn_Rijecnici.Size = new System.Drawing.Size(100, 17);
            this.rbtn_Rijecnici.TabIndex = 8;
            this.rbtn_Rijecnici.TabStop = true;
            this.rbtn_Rijecnici.Text = "Use dictionaries";
            this.rbtn_Rijecnici.UseVisualStyleBackColor = true;
            this.rbtn_Rijecnici.CheckedChanged += new System.EventHandler(this.rbtn_Rijecnici_CheckedChanged);
            // 
            // rbtnNeizmjenjeni
            // 
            this.rbtnNeizmjenjeni.AutoSize = true;
            this.rbtnNeizmjenjeni.Location = new System.Drawing.Point(6, 19);
            this.rbtnNeizmjenjeni.Name = "rbtnNeizmjenjeni";
            this.rbtnNeizmjenjeni.Size = new System.Drawing.Size(126, 17);
            this.rbtnNeizmjenjeni.TabIndex = 7;
            this.rbtnNeizmjenjeni.TabStop = true;
            this.rbtnNeizmjenjeni.Text = "Exact string matching";
            this.rbtnNeizmjenjeni.UseVisualStyleBackColor = true;
            this.rbtnNeizmjenjeni.CheckedChanged += new System.EventHandler(this.rbtnNeizmjenjeni_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_OR);
            this.groupBox2.Controls.Add(this.rbtn_AND);
            this.groupBox2.Location = new System.Drawing.Point(6, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 50);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rbtn_OR
            // 
            this.rbtn_OR.AutoSize = true;
            this.rbtn_OR.Location = new System.Drawing.Point(124, 19);
            this.rbtn_OR.Name = "rbtn_OR";
            this.rbtn_OR.Size = new System.Drawing.Size(41, 17);
            this.rbtn_OR.TabIndex = 6;
            this.rbtn_OR.TabStop = true;
            this.rbtn_OR.Text = "OR";
            this.rbtn_OR.UseVisualStyleBackColor = true;
            this.rbtn_OR.CheckedChanged += new System.EventHandler(this.rbtn_OR_CheckedChanged);
            // 
            // rbtn_AND
            // 
            this.rbtn_AND.AutoSize = true;
            this.rbtn_AND.Location = new System.Drawing.Point(27, 19);
            this.rbtn_AND.Name = "rbtn_AND";
            this.rbtn_AND.Size = new System.Drawing.Size(48, 17);
            this.rbtn_AND.TabIndex = 5;
            this.rbtn_AND.TabStop = true;
            this.rbtn_AND.Text = "AND";
            this.rbtn_AND.UseVisualStyleBackColor = true;
            this.rbtn_AND.CheckedChanged += new System.EventHandler(this.rbtn_AND_CheckedChanged);
            // 
            // button_Pretrazi
            // 
            this.button_Pretrazi.Location = new System.Drawing.Point(6, 126);
            this.button_Pretrazi.Name = "button_Pretrazi";
            this.button_Pretrazi.Size = new System.Drawing.Size(645, 38);
            this.button_Pretrazi.TabIndex = 2;
            this.button_Pretrazi.Text = "Pretraži!";
            this.button_Pretrazi.UseVisualStyleBackColor = true;
            this.button_Pretrazi.Click += new System.EventHandler(this.button_Pretrazi_Click);
            // 
            // textBox_Pretrazivanje
            // 
            this.textBox_Pretrazivanje.Location = new System.Drawing.Point(6, 32);
            this.textBox_Pretrazivanje.Name = "textBox_Pretrazivanje";
            this.textBox_Pretrazivanje.Size = new System.Drawing.Size(645, 20);
            this.textBox_Pretrazivanje.TabIndex = 0;
            // 
            // groupBox_Connect
            // 
            this.groupBox_Connect.Controls.Add(this.button_Disconnect);
            this.groupBox_Connect.Controls.Add(this.button_Connect);
            this.groupBox_Connect.Controls.Add(this.label7);
            this.groupBox_Connect.Controls.Add(this.textBox_Database);
            this.groupBox_Connect.Controls.Add(this.label6);
            this.groupBox_Connect.Controls.Add(this.textBox_Password);
            this.groupBox_Connect.Controls.Add(this.label5);
            this.groupBox_Connect.Controls.Add(this.textBox_UserID);
            this.groupBox_Connect.Controls.Add(this.label4);
            this.groupBox_Connect.Controls.Add(this.textBox_Port);
            this.groupBox_Connect.Controls.Add(this.label3);
            this.groupBox_Connect.Controls.Add(this.textBox_IP);
            this.groupBox_Connect.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Connect.Name = "groupBox_Connect";
            this.groupBox_Connect.Size = new System.Drawing.Size(231, 243);
            this.groupBox_Connect.TabIndex = 12;
            this.groupBox_Connect.TabStop = false;
            this.groupBox_Connect.Text = "Spajanje na bazu";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(67, 32);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(155, 20);
            this.textBox_IP.TabIndex = 12;
            this.textBox_IP.Text = "192.168.56.12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Port: ";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(67, 58);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(155, 20);
            this.textBox_Port.TabIndex = 14;
            this.textBox_Port.Text = "5432";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "User ID:";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(67, 84);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(155, 20);
            this.textBox_UserID.TabIndex = 16;
            this.textBox_UserID.Text = "postgres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Password: ";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(67, 110);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(155, 20);
            this.textBox_Password.TabIndex = 18;
            this.textBox_Password.Text = "reverse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Database: ";
            // 
            // textBox_Database
            // 
            this.textBox_Database.Location = new System.Drawing.Point(67, 136);
            this.textBox_Database.Name = "textBox_Database";
            this.textBox_Database.Size = new System.Drawing.Size(155, 20);
            this.textBox_Database.TabIndex = 20;
            this.textBox_Database.Text = "postgres";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(9, 173);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(213, 23);
            this.button_Connect.TabIndex = 12;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(9, 206);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(213, 23);
            this.button_Disconnect.TabIndex = 21;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 718);
            this.Controls.Add(this.groupBox_Connect);
            this.Controls.Add(this.groupBox_Search);
            this.Controls.Add(this.gb_unosPodataka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_unosPodataka.ResumeLayout(false);
            this.gb_unosPodataka.PerformLayout();
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Connect.ResumeLayout(false);
            this.groupBox_Connect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_unosPodataka;
        private System.Windows.Forms.Button button_unosTekstaUBazu;
        private System.Windows.Forms.RichTextBox rTB_unosTextaUBazu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtn_Fuzzy;
        private System.Windows.Forms.RadioButton rbtn_Rijecnici;
        private System.Windows.Forms.RadioButton rbtnNeizmjenjeni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_OR;
        private System.Windows.Forms.RadioButton rbtn_AND;
        private System.Windows.Forms.Button button_Pretrazi;
        private System.Windows.Forms.TextBox textBox_Pretrazivanje;
        private System.Windows.Forms.LinkLabel linkLabel_Rezultat;
        private System.Windows.Forms.Label labelBrojac;
        private System.Windows.Forms.GroupBox groupBox_Connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Database;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
    }
}

