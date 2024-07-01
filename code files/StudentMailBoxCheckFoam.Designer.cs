namespace Final_prj
{
    partial class StudentMailBoxCheckFoam
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
            this.txtstudentwelcomeMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridMailbox = new System.Windows.Forms.DataGridView();
            this.btnViewMail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMailbox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtstudentwelcomeMsg
            // 
            this.txtstudentwelcomeMsg.AutoSize = true;
            this.txtstudentwelcomeMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txtstudentwelcomeMsg.Location = new System.Drawing.Point(308, 9);
            this.txtstudentwelcomeMsg.Name = "txtstudentwelcomeMsg";
            this.txtstudentwelcomeMsg.Size = new System.Drawing.Size(57, 21);
            this.txtstudentwelcomeMsg.TabIndex = 7;
            this.txtstudentwelcomeMsg.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome";
            // 
            // DataGridMailbox
            // 
            this.DataGridMailbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMailbox.Location = new System.Drawing.Point(13, 78);
            this.DataGridMailbox.Name = "DataGridMailbox";
            this.DataGridMailbox.RowHeadersWidth = 62;
            this.DataGridMailbox.RowTemplate.Height = 28;
            this.DataGridMailbox.Size = new System.Drawing.Size(651, 277);
            this.DataGridMailbox.TabIndex = 8;
            this.DataGridMailbox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMailbox_CellContentClick);
            // 
            // btnViewMail
            // 
            this.btnViewMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnViewMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMail.ForeColor = System.Drawing.Color.White;
            this.btnViewMail.Location = new System.Drawing.Point(244, 375);
            this.btnViewMail.Name = "btnViewMail";
            this.btnViewMail.Size = new System.Drawing.Size(109, 41);
            this.btnViewMail.TabIndex = 9;
            this.btnViewMail.Text = "View";
            this.btnViewMail.UseVisualStyleBackColor = false;
            this.btnViewMail.Click += new System.EventHandler(this.btnViewMail_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(244, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentMailBoxCheckFoam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViewMail);
            this.Controls.Add(this.DataGridMailbox);
            this.Controls.Add(this.txtstudentwelcomeMsg);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentMailBoxCheckFoam";
            this.Text = "StudentMailBoxCheckFoam";
            this.Load += new System.EventHandler(this.StudentMailBoxCheckFoam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMailbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtstudentwelcomeMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridMailbox;
        private System.Windows.Forms.Button btnViewMail;
        private System.Windows.Forms.Button button1;
    }
}