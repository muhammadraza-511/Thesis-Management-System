namespace Final_prj
{
    partial class AdminViewStudentInfo
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
            this.btnViewdata = new System.Windows.Forms.Button();
            this.DataGridMailbox = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMailbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewdata
            // 
            this.btnViewdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnViewdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewdata.ForeColor = System.Drawing.Color.White;
            this.btnViewdata.Location = new System.Drawing.Point(236, 336);
            this.btnViewdata.Name = "btnViewdata";
            this.btnViewdata.Size = new System.Drawing.Size(109, 41);
            this.btnViewdata.TabIndex = 13;
            this.btnViewdata.Text = "View";
            this.btnViewdata.UseVisualStyleBackColor = false;
            this.btnViewdata.Click += new System.EventHandler(this.btnViewdata_Click);
            // 
            // DataGridMailbox
            // 
            this.DataGridMailbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMailbox.Location = new System.Drawing.Point(5, 39);
            this.DataGridMailbox.Name = "DataGridMailbox";
            this.DataGridMailbox.RowHeadersWidth = 62;
            this.DataGridMailbox.RowTemplate.Height = 28;
            this.DataGridMailbox.Size = new System.Drawing.Size(651, 277);
            this.DataGridMailbox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(236, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminViewStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViewdata);
            this.Controls.Add(this.DataGridMailbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminViewStudentInfo";
            this.Text = "AdminViewStudentInfo";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMailbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewdata;
        private System.Windows.Forms.DataGridView DataGridMailbox;
        private System.Windows.Forms.Button button1;
    }
}