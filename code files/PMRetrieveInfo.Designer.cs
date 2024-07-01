namespace Final_prj
{
    partial class PMRetrieveInfo
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
            this.btnRetrieveInfo = new System.Windows.Forms.Button();
            this.DataGridRetrieveInfo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRetrieveInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetrieveInfo
            // 
            this.btnRetrieveInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnRetrieveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieveInfo.ForeColor = System.Drawing.Color.White;
            this.btnRetrieveInfo.Location = new System.Drawing.Point(253, 327);
            this.btnRetrieveInfo.Name = "btnRetrieveInfo";
            this.btnRetrieveInfo.Size = new System.Drawing.Size(109, 41);
            this.btnRetrieveInfo.TabIndex = 11;
            this.btnRetrieveInfo.Text = "Retrieve";
            this.btnRetrieveInfo.UseVisualStyleBackColor = false;
            this.btnRetrieveInfo.Click += new System.EventHandler(this.btnRetrieveInfo_Click);
            // 
            // DataGridRetrieveInfo
            // 
            this.DataGridRetrieveInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridRetrieveInfo.Location = new System.Drawing.Point(22, 30);
            this.DataGridRetrieveInfo.Name = "DataGridRetrieveInfo";
            this.DataGridRetrieveInfo.RowHeadersWidth = 62;
            this.DataGridRetrieveInfo.RowTemplate.Height = 28;
            this.DataGridRetrieveInfo.Size = new System.Drawing.Size(651, 277);
            this.DataGridRetrieveInfo.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(253, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PMRetrieveInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRetrieveInfo);
            this.Controls.Add(this.DataGridRetrieveInfo);
            this.Name = "PMRetrieveInfo";
            this.Text = "PMRetrieveInfo";
            this.Load += new System.EventHandler(this.PMRetrieveInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRetrieveInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetrieveInfo;
        private System.Windows.Forms.DataGridView DataGridRetrieveInfo;
        private System.Windows.Forms.Button button1;
    }
}