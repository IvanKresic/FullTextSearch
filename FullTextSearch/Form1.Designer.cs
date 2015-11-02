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
            this.label1 = new System.Windows.Forms.Label();
            this.rTB_unosTextaUBazu = new System.Windows.Forms.RichTextBox();
            this.button_unosTekstaUBazu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Pretrazivanje = new System.Windows.Forms.TextBox();
            this.button_Pretrazi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtn_AND = new System.Windows.Forms.RadioButton();
            this.rbtn_OR = new System.Windows.Forms.RadioButton();
            this.rbtnNeizmjenjeni = new System.Windows.Forms.RadioButton();
            this.rbtn_Rijecnici = new System.Windows.Forms.RadioButton();
            this.rbtn_Fuzzy = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBrojac = new System.Windows.Forms.Label();
            this.linkLabel_Rezultat = new System.Windows.Forms.LinkLabel();
            this.gb_unosPodataka.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_unosPodataka
            // 
            this.gb_unosPodataka.Controls.Add(this.button_unosTekstaUBazu);
            this.gb_unosPodataka.Controls.Add(this.rTB_unosTextaUBazu);
            this.gb_unosPodataka.Controls.Add(this.label1);
            this.gb_unosPodataka.Location = new System.Drawing.Point(12, 12);
            this.gb_unosPodataka.Name = "gb_unosPodataka";
            this.gb_unosPodataka.Size = new System.Drawing.Size(231, 694);
            this.gb_unosPodataka.TabIndex = 0;
            this.gb_unosPodataka.TabStop = false;
            this.gb_unosPodataka.Text = "Unos podataka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite text za unos u bazu podataka:";
            // 
            // rTB_unosTextaUBazu
            // 
            this.rTB_unosTextaUBazu.Location = new System.Drawing.Point(9, 51);
            this.rTB_unosTextaUBazu.Name = "rTB_unosTextaUBazu";
            this.rTB_unosTextaUBazu.Size = new System.Drawing.Size(216, 96);
            this.rTB_unosTextaUBazu.TabIndex = 1;
            this.rTB_unosTextaUBazu.Text = "";
            // 
            // button_unosTekstaUBazu
            // 
            this.button_unosTekstaUBazu.Location = new System.Drawing.Point(9, 153);
            this.button_unosTekstaUBazu.Name = "button_unosTekstaUBazu";
            this.button_unosTekstaUBazu.Size = new System.Drawing.Size(216, 23);
            this.button_unosTekstaUBazu.TabIndex = 1;
            this.button_unosTekstaUBazu.Text = "Dodaj u bazu podataka";
            this.button_unosTekstaUBazu.UseVisualStyleBackColor = true;
            this.button_unosTekstaUBazu.Click += new System.EventHandler(this.button_unosTekstaUBazu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel_Rezultat);
            this.groupBox1.Controls.Add(this.labelBrojac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button_Pretrazi);
            this.groupBox1.Controls.Add(this.textBox_Pretrazivanje);
            this.groupBox1.Location = new System.Drawing.Point(249, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 694);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraživanje";
            // 
            // textBox_Pretrazivanje
            // 
            this.textBox_Pretrazivanje.Location = new System.Drawing.Point(6, 32);
            this.textBox_Pretrazivanje.Name = "textBox_Pretrazivanje";
            this.textBox_Pretrazivanje.Size = new System.Drawing.Size(645, 20);
            this.textBox_Pretrazivanje.TabIndex = 0;
            // 
            // button_Pretrazi
            // 
            this.button_Pretrazi.Location = new System.Drawing.Point(657, 32);
            this.button_Pretrazi.Name = "button_Pretrazi";
            this.button_Pretrazi.Size = new System.Drawing.Size(173, 23);
            this.button_Pretrazi.TabIndex = 2;
            this.button_Pretrazi.Text = "Pretraži!";
            this.button_Pretrazi.UseVisualStyleBackColor = true;
            this.button_Pretrazi.Click += new System.EventHandler(this.button_Pretrazi_Click);
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
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 208);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(645, 188);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Upit prema bazi podataka:";
            // 
            // labelBrojac
            // 
            this.labelBrojac.AutoSize = true;
            this.labelBrojac.Location = new System.Drawing.Point(6, 399);
            this.labelBrojac.Name = "labelBrojac";
            this.labelBrojac.Size = new System.Drawing.Size(0, 13);
            this.labelBrojac.TabIndex = 2;
            // 
            // linkLabel_Rezultat
            // 
            this.linkLabel_Rezultat.AutoSize = true;
            this.linkLabel_Rezultat.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_Rezultat.Location = new System.Drawing.Point(6, 440);
            this.linkLabel_Rezultat.Name = "linkLabel_Rezultat";
            this.linkLabel_Rezultat.Size = new System.Drawing.Size(112, 13);
            this.linkLabel_Rezultat.TabIndex = 7;
            this.linkLabel_Rezultat.TabStop = true;
            this.linkLabel_Rezultat.Text = "Rezultat pretraživanja:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 718);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_unosPodataka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_unosPodataka.ResumeLayout(false);
            this.gb_unosPodataka.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_unosPodataka;
        private System.Windows.Forms.Button button_unosTekstaUBazu;
        private System.Windows.Forms.RichTextBox rTB_unosTextaUBazu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

