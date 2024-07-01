namespace Final_prj
{
    partial class SupervisorViewProposalFoam
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
            this.DataGridViewProposal = new System.Windows.Forms.DataGridView();
            this.btnViewThesisProposal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProposal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thesis Proposals";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DataGridViewProposal
            // 
            this.DataGridViewProposal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProposal.Location = new System.Drawing.Point(42, 98);
            this.DataGridViewProposal.Name = "DataGridViewProposal";
            this.DataGridViewProposal.RowHeadersWidth = 62;
            this.DataGridViewProposal.RowTemplate.Height = 28;
            this.DataGridViewProposal.Size = new System.Drawing.Size(510, 281);
            this.DataGridViewProposal.TabIndex = 1;
            // 
            // btnViewThesisProposal
            // 
            this.btnViewThesisProposal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnViewThesisProposal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewThesisProposal.ForeColor = System.Drawing.Color.White;
            this.btnViewThesisProposal.Location = new System.Drawing.Point(210, 385);
            this.btnViewThesisProposal.Name = "btnViewThesisProposal";
            this.btnViewThesisProposal.Size = new System.Drawing.Size(114, 37);
            this.btnViewThesisProposal.TabIndex = 2;
            this.btnViewThesisProposal.Text = "View";
            this.btnViewThesisProposal.UseVisualStyleBackColor = false;
            this.btnViewThesisProposal.Click += new System.EventHandler(this.btnViewThesisProposal_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(210, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SupervisorViewProposalFoam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViewThesisProposal);
            this.Controls.Add(this.DataGridViewProposal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupervisorViewProposalFoam";
            this.Text = "SupervisorViewProposalFoam";
            this.Load += new System.EventHandler(this.SupervisorViewProposalFoam_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProposal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewProposal;
        private System.Windows.Forms.Button btnViewThesisProposal;
        private System.Windows.Forms.Button button1;
    }
}