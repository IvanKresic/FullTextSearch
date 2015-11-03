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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Database = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.groupBox_Analysis = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.gb_unosPodataka.SuspendLayout();
            this.groupBox_Search.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Connect.SuspendLayout();
            this.groupBox_Analysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_unosPodataka
            // 
            this.gb_unosPodataka.Controls.Add(this.button_unosTekstaUBazu);
            this.gb_unosPodataka.Controls.Add(this.rTB_unosTextaUBazu);
            this.gb_unosPodataka.Controls.Add(this.label1);
            this.gb_unosPodataka.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_unosPodataka.Location = new System.Drawing.Point(14, 303);
            this.gb_unosPodataka.Name = "gb_unosPodataka";
            this.gb_unosPodataka.Size = new System.Drawing.Size(300, 218);
            this.gb_unosPodataka.TabIndex = 0;
            this.gb_unosPodataka.TabStop = false;
            this.gb_unosPodataka.Text = "Add data to database";
            // 
            // button_unosTekstaUBazu
            // 
            this.button_unosTekstaUBazu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_unosTekstaUBazu.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_unosTekstaUBazu.Location = new System.Drawing.Point(7, 163);
            this.button_unosTekstaUBazu.Name = "button_unosTekstaUBazu";
            this.button_unosTekstaUBazu.Size = new System.Drawing.Size(286, 25);
            this.button_unosTekstaUBazu.TabIndex = 1;
            this.button_unosTekstaUBazu.Text = "Add to database";
            this.button_unosTekstaUBazu.UseVisualStyleBackColor = false;
            this.button_unosTekstaUBazu.Click += new System.EventHandler(this.button_unosTekstaUBazu_Click);
            // 
            // rTB_unosTextaUBazu
            // 
            this.rTB_unosTextaUBazu.Location = new System.Drawing.Point(7, 53);
            this.rTB_unosTextaUBazu.Name = "rTB_unosTextaUBazu";
            this.rTB_unosTextaUBazu.Size = new System.Drawing.Size(285, 103);
            this.rTB_unosTextaUBazu.TabIndex = 1;
            this.rTB_unosTextaUBazu.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert text to insert in database:";
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.linkLabel1);
            this.groupBox_Search.Controls.Add(this.linkLabel_Rezultat);
            this.groupBox_Search.Controls.Add(this.labelBrojac);
            this.groupBox_Search.Controls.Add(this.label2);
            this.groupBox_Search.Controls.Add(this.richTextBox1);
            this.groupBox_Search.Controls.Add(this.groupBox3);
            this.groupBox_Search.Controls.Add(this.groupBox2);
            this.groupBox_Search.Controls.Add(this.button_Pretrazi);
            this.groupBox_Search.Controls.Add(this.textBox_Pretrazivanje);
            this.groupBox_Search.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Search.Location = new System.Drawing.Point(321, 13);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(782, 747);
            this.groupBox_Search.TabIndex = 1;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Search";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(6, 466);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 24);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SEARCH RESULTS:";
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // linkLabel_Rezultat
            // 
            this.linkLabel_Rezultat.AutoSize = true;
            this.linkLabel_Rezultat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Rezultat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel_Rezultat.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel_Rezultat.Location = new System.Drawing.Point(6, 490);
            this.linkLabel_Rezultat.Name = "linkLabel_Rezultat";
            this.linkLabel_Rezultat.Size = new System.Drawing.Size(0, 18);
            this.linkLabel_Rezultat.TabIndex = 11;
            // 
            // labelBrojac
            // 
            this.labelBrojac.AutoSize = true;
            this.labelBrojac.Location = new System.Drawing.Point(3, 428);
            this.labelBrojac.Name = "labelBrojac";
            this.labelBrojac.Size = new System.Drawing.Size(0, 14);
            this.labelBrojac.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "SQL query:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 222);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(752, 202);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtn_Fuzzy);
            this.groupBox3.Controls.Add(this.rbtn_Rijecnici);
            this.groupBox3.Controls.Add(this.rbtnNeizmjenjeni);
            this.groupBox3.Location = new System.Drawing.Point(247, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 54);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // rbtn_Fuzzy
            // 
            this.rbtn_Fuzzy.AutoSize = true;
            this.rbtn_Fuzzy.Location = new System.Drawing.Point(337, 20);
            this.rbtn_Fuzzy.Name = "rbtn_Fuzzy";
            this.rbtn_Fuzzy.Size = new System.Drawing.Size(156, 18);
            this.rbtn_Fuzzy.TabIndex = 9;
            this.rbtn_Fuzzy.TabStop = true;
            this.rbtn_Fuzzy.Text = "Fuzzy string matching";
            this.rbtn_Fuzzy.UseVisualStyleBackColor = true;
            this.rbtn_Fuzzy.CheckedChanged += new System.EventHandler(this.rbtn_Fuzzy_CheckedChanged);
            // 
            // rbtn_Rijecnici
            // 
            this.rbtn_Rijecnici.AutoSize = true;
            this.rbtn_Rijecnici.Location = new System.Drawing.Point(195, 20);
            this.rbtn_Rijecnici.Name = "rbtn_Rijecnici";
            this.rbtn_Rijecnici.Size = new System.Drawing.Size(116, 18);
            this.rbtn_Rijecnici.TabIndex = 8;
            this.rbtn_Rijecnici.TabStop = true;
            this.rbtn_Rijecnici.Text = "Use dictionaries";
            this.rbtn_Rijecnici.UseVisualStyleBackColor = true;
            this.rbtn_Rijecnici.CheckedChanged += new System.EventHandler(this.rbtn_Rijecnici_CheckedChanged);
            // 
            // rbtnNeizmjenjeni
            // 
            this.rbtnNeizmjenjeni.AutoSize = true;
            this.rbtnNeizmjenjeni.Location = new System.Drawing.Point(7, 20);
            this.rbtnNeizmjenjeni.Name = "rbtnNeizmjenjeni";
            this.rbtnNeizmjenjeni.Size = new System.Drawing.Size(155, 18);
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
            this.groupBox2.Location = new System.Drawing.Point(7, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rbtn_OR
            // 
            this.rbtn_OR.AutoSize = true;
            this.rbtn_OR.Location = new System.Drawing.Point(145, 20);
            this.rbtn_OR.Name = "rbtn_OR";
            this.rbtn_OR.Size = new System.Drawing.Size(42, 18);
            this.rbtn_OR.TabIndex = 6;
            this.rbtn_OR.TabStop = true;
            this.rbtn_OR.Text = "OR";
            this.rbtn_OR.UseVisualStyleBackColor = true;
            this.rbtn_OR.CheckedChanged += new System.EventHandler(this.rbtn_OR_CheckedChanged);
            // 
            // rbtn_AND
            // 
            this.rbtn_AND.AutoSize = true;
            this.rbtn_AND.Location = new System.Drawing.Point(31, 20);
            this.rbtn_AND.Name = "rbtn_AND";
            this.rbtn_AND.Size = new System.Drawing.Size(51, 18);
            this.rbtn_AND.TabIndex = 5;
            this.rbtn_AND.TabStop = true;
            this.rbtn_AND.Text = "AND";
            this.rbtn_AND.UseVisualStyleBackColor = true;
            this.rbtn_AND.CheckedChanged += new System.EventHandler(this.rbtn_AND_CheckedChanged);
            // 
            // button_Pretrazi
            // 
            this.button_Pretrazi.BackColor = System.Drawing.Color.SkyBlue;
            this.button_Pretrazi.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pretrazi.Location = new System.Drawing.Point(7, 136);
            this.button_Pretrazi.Name = "button_Pretrazi";
            this.button_Pretrazi.Size = new System.Drawing.Size(752, 41);
            this.button_Pretrazi.TabIndex = 2;
            this.button_Pretrazi.Text = "SEARCH";
            this.button_Pretrazi.UseVisualStyleBackColor = false;
            this.button_Pretrazi.Click += new System.EventHandler(this.button_Pretrazi_Click);
            // 
            // textBox_Pretrazivanje
            // 
            this.textBox_Pretrazivanje.Location = new System.Drawing.Point(7, 34);
            this.textBox_Pretrazivanje.Name = "textBox_Pretrazivanje";
            this.textBox_Pretrazivanje.Size = new System.Drawing.Size(766, 20);
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
            this.groupBox_Connect.Font = new System.Drawing.Font("Georgia", 8F);
            this.groupBox_Connect.Location = new System.Drawing.Point(14, 13);
            this.groupBox_Connect.Name = "groupBox_Connect";
            this.groupBox_Connect.Size = new System.Drawing.Size(300, 262);
            this.groupBox_Connect.TabIndex = 12;
            this.groupBox_Connect.TabStop = false;
            this.groupBox_Connect.Text = "Database connection";
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.BackColor = System.Drawing.Color.IndianRed;
            this.button_Disconnect.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Disconnect.Location = new System.Drawing.Point(10, 222);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(282, 25);
            this.button_Disconnect.TabIndex = 21;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = false;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Connect.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Connect.Location = new System.Drawing.Point(10, 186);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(282, 25);
            this.button_Connect.TabIndex = 12;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = false;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "Database: ";
            // 
            // textBox_Database
            // 
            this.textBox_Database.Location = new System.Drawing.Point(98, 146);
            this.textBox_Database.Name = "textBox_Database";
            this.textBox_Database.Size = new System.Drawing.Size(180, 20);
            this.textBox_Database.TabIndex = 20;
            this.textBox_Database.Text = "postgres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Password: ";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(98, 118);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(180, 20);
            this.textBox_Password.TabIndex = 18;
            this.textBox_Password.Text = "reverse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "User ID:";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(98, 90);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(180, 20);
            this.textBox_UserID.TabIndex = 16;
            this.textBox_UserID.Text = "postgres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Port: ";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(98, 62);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(180, 20);
            this.textBox_Port.TabIndex = 14;
            this.textBox_Port.Text = "5432";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP adresa:";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(98, 34);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(180, 20);
            this.textBox_IP.TabIndex = 12;
            this.textBox_IP.Text = "192.168.56.12";
            // 
            // groupBox_Analysis
            // 
            this.groupBox_Analysis.Controls.Add(this.button1);
            this.groupBox_Analysis.Controls.Add(this.label10);
            this.groupBox_Analysis.Controls.Add(this.label9);
            this.groupBox_Analysis.Controls.Add(this.label8);
            this.groupBox_Analysis.Controls.Add(this.dateTimePicker_To);
            this.groupBox_Analysis.Controls.Add(this.dateTimePicker_From);
            this.groupBox_Analysis.Location = new System.Drawing.Point(14, 549);
            this.groupBox_Analysis.Name = "groupBox_Analysis";
            this.groupBox_Analysis.Size = new System.Drawing.Size(300, 211);
            this.groupBox_Analysis.TabIndex = 13;
            this.groupBox_Analysis.TabStop = false;
            this.groupBox_Analysis.Text = "Analysis";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Analize";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 14);
            this.label10.TabIndex = 16;
            this.label10.Text = "TO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "FROM:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Analize data:";
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Location = new System.Drawing.Point(58, 82);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker_To.TabIndex = 14;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(58, 56);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker_From.TabIndex = 13;
            this.dateTimePicker_From.Value = new System.DateTime(2015, 11, 3, 11, 44, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 773);
            this.Controls.Add(this.groupBox_Analysis);
            this.Controls.Add(this.groupBox_Connect);
            this.Controls.Add(this.groupBox_Search);
            this.Controls.Add(this.gb_unosPodataka);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Full Text Search";
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
            this.groupBox_Analysis.ResumeLayout(false);
            this.groupBox_Analysis.PerformLayout();
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
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox_Analysis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
    }
}

