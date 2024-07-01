namespace Final_prj
{
    partial class AdminDeleteDataFoam
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
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtPrimaryKey = new System.Windows.Forms.TextBox();
            this.btnGoback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(39, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(39, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Row Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDeleteData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteData.ForeColor = System.Drawing.Color.White;
            this.btnDeleteData.Location = new System.Drawing.Point(207, 364);
            this.btnDeleteData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(151, 58);
            this.btnDeleteData.TabIndex = 2;
            this.btnDeleteData.Text = "Enter";
            this.btnDeleteData.UseVisualStyleBackColor = false;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableName.Location = new System.Drawing.Point(45, 118);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(458, 32);
            this.txtTableName.TabIndex = 3;
            this.txtTableName.TextChanged += new System.EventHandler(this.txtTableName_TextChanged);
            // 
            // txtPrimaryKey
            // 
            this.txtPrimaryKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPrimaryKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimaryKey.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txtPrimaryKey.Location = new System.Drawing.Point(45, 243);
            this.txtPrimaryKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrimaryKey.Name = "txtPrimaryKey";
            this.txtPrimaryKey.Size = new System.Drawing.Size(458, 32);
            this.txtPrimaryKey.TabIndex = 4;
            this.txtPrimaryKey.TextChanged += new System.EventHandler(this.txtPrimaryKey_TextChanged);
            // 
            // btnGoback
            // 
            this.btnGoback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnGoback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoback.ForeColor = System.Drawing.Color.White;
            this.btnGoback.Location = new System.Drawing.Point(207, 465);
            this.btnGoback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(151, 58);
            this.btnGoback.TabIndex = 5;
            this.btnGoback.Text = "Exit";
            this.btnGoback.UseVisualStyleBackColor = false;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // AdminDeleteDataFoam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 643);
            this.Controls.Add(this.btnGoback);
            this.Controls.Add(this.txtPrimaryKey);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminDeleteDataFoam";
            this.Text = "AdminDeleteDataFoam";
            this.Load += new System.EventHandler(this.AdminDeleteDataFoam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtPrimaryKey;
        private System.Windows.Forms.Button btnGoback;
    }
}