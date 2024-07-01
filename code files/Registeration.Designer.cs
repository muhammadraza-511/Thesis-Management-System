namespace Final_prj
{
    partial class Registeration
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
            this.BtnPMRegister = new System.Windows.Forms.Button();
            this.BtnSupervisorRegister = new System.Windows.Forms.Button();
            this.BtnStudentRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Registeration Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(139, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Your Role";
            // 
            // BtnPMRegister
            // 
            this.BtnPMRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnPMRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPMRegister.ForeColor = System.Drawing.Color.White;
            this.BtnPMRegister.Location = new System.Drawing.Point(143, 226);
            this.BtnPMRegister.Name = "BtnPMRegister";
            this.BtnPMRegister.Size = new System.Drawing.Size(154, 41);
            this.BtnPMRegister.TabIndex = 3;
            this.BtnPMRegister.Text = "Panel Member";
            this.BtnPMRegister.UseVisualStyleBackColor = false;
            this.BtnPMRegister.Click += new System.EventHandler(this.BtnPMRegister_Click);
            // 
            // BtnSupervisorRegister
            // 
            this.BtnSupervisorRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnSupervisorRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupervisorRegister.ForeColor = System.Drawing.Color.White;
            this.BtnSupervisorRegister.Location = new System.Drawing.Point(143, 323);
            this.BtnSupervisorRegister.Name = "BtnSupervisorRegister";
            this.BtnSupervisorRegister.Size = new System.Drawing.Size(152, 39);
            this.BtnSupervisorRegister.TabIndex = 4;
            this.BtnSupervisorRegister.Text = "Supervisor";
            this.BtnSupervisorRegister.UseVisualStyleBackColor = false;
            this.BtnSupervisorRegister.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnStudentRegister
            // 
            this.BtnStudentRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnStudentRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudentRegister.ForeColor = System.Drawing.Color.White;
            this.BtnStudentRegister.Location = new System.Drawing.Point(141, 419);
            this.BtnStudentRegister.Name = "BtnStudentRegister";
            this.BtnStudentRegister.Size = new System.Drawing.Size(152, 39);
            this.BtnStudentRegister.TabIndex = 5;
            this.BtnStudentRegister.Text = "Student";
            this.BtnStudentRegister.UseVisualStyleBackColor = false;
            this.BtnStudentRegister.Click += new System.EventHandler(this.BtnStudentRegister_Click);
            // 
            // Registeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 624);
            this.Controls.Add(this.BtnStudentRegister);
            this.Controls.Add(this.BtnSupervisorRegister);
            this.Controls.Add(this.BtnPMRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registeration";
            this.Text = "Registeration";
            this.Load += new System.EventHandler(this.Registeration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPMRegister;
        private System.Windows.Forms.Button BtnSupervisorRegister;
        private System.Windows.Forms.Button BtnStudentRegister;
    }
}