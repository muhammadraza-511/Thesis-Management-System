namespace Final_prj
{
    partial class PMApproveProposal
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
            this.txtPMwelcomeMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datGridApproveProp = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datGridApproveProp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPMwelcomeMsg
            // 
            this.txtPMwelcomeMsg.AutoSize = true;
            this.txtPMwelcomeMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txtPMwelcomeMsg.Location = new System.Drawing.Point(314, 10);
            this.txtPMwelcomeMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPMwelcomeMsg.Name = "txtPMwelcomeMsg";
            this.txtPMwelcomeMsg.Size = new System.Drawing.Size(57, 21);
            this.txtPMwelcomeMsg.TabIndex = 7;
            this.txtPMwelcomeMsg.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(224, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome";
            // 
            // datGridApproveProp
            // 
            this.datGridApproveProp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridApproveProp.Location = new System.Drawing.Point(24, 74);
            this.datGridApproveProp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datGridApproveProp.Name = "datGridApproveProp";
            this.datGridApproveProp.RowHeadersWidth = 62;
            this.datGridApproveProp.RowTemplate.Height = 28;
            this.datGridApproveProp.Size = new System.Drawing.Size(636, 273);
            this.datGridApproveProp.TabIndex = 8;
            this.datGridApproveProp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datGridApproveProp_CellContentClick);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(244, 364);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(115, 42);
            this.btnApprove.TabIndex = 9;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(244, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PMApproveProposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.datGridApproveProp);
            this.Controls.Add(this.txtPMwelcomeMsg);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PMApproveProposal";
            this.Text = "PMApproveProposal";
            this.Load += new System.EventHandler(this.PMApproveProposal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datGridApproveProp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPMwelcomeMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datGridApproveProp;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button button1;
    }
}