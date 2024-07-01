namespace Final_prj
{
    partial class SupervisorNotifyStudentFoam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecepentId = new System.Windows.Forms.TextBox();
            this.txtNotifyContent = new System.Windows.Forms.TextBox();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notify Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recepent Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Content";
            // 
            // txtRecepentId
            // 
            this.txtRecepentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRecepentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtRecepentId.Location = new System.Drawing.Point(18, 90);
            this.txtRecepentId.Name = "txtRecepentId";
            this.txtRecepentId.Size = new System.Drawing.Size(284, 44);
            this.txtRecepentId.TabIndex = 3;
            // 
            // txtNotifyContent
            // 
            this.txtNotifyContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNotifyContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNotifyContent.Location = new System.Drawing.Point(18, 176);
            this.txtNotifyContent.Multiline = true;
            this.txtNotifyContent.Name = "txtNotifyContent";
            this.txtNotifyContent.Size = new System.Drawing.Size(442, 170);
            this.txtNotifyContent.TabIndex = 4;
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSendNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendNotification.ForeColor = System.Drawing.Color.White;
            this.btnSendNotification.Location = new System.Drawing.Point(184, 372);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(186, 41);
            this.btnSendNotification.TabIndex = 5;
            this.btnSendNotification.Text = "Send Notification";
            this.btnSendNotification.UseVisualStyleBackColor = false;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // SupervisorNotifyStudentFoam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 530);
            this.Controls.Add(this.btnSendNotification);
            this.Controls.Add(this.txtNotifyContent);
            this.Controls.Add(this.txtRecepentId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupervisorNotifyStudentFoam";
            this.Text = "SupervisorNotifyStudentFoam";
            this.Load += new System.EventHandler(this.SupervisorNotifyStudentFoam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecepentId;
        private System.Windows.Forms.TextBox txtNotifyContent;
        private System.Windows.Forms.Button btnSendNotification;
    }
}