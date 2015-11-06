namespace FullTextSearch
{
    partial class Analysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analysis));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_LoadData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1299, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_LoadData
            // 
            this.button_LoadData.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_LoadData.Location = new System.Drawing.Point(373, 449);
            this.button_LoadData.Name = "button_LoadData";
            this.button_LoadData.Size = new System.Drawing.Size(254, 31);
            this.button_LoadData.TabIndex = 1;
            this.button_LoadData.Text = "Load/Refresh Data";
            this.button_LoadData.UseVisualStyleBackColor = false;
            this.button_LoadData.Click += new System.EventHandler(this.button_LoadData_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(633, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "I\'ve seen enough";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_LoadData);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Analysis";
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.Analysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_LoadData;
        private System.Windows.Forms.Button button1;
    }
}