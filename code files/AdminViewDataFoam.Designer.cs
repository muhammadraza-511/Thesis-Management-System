namespace Final_prj
{
    partial class AdminViewDataFoam
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
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.btnTableName = new System.Windows.Forms.Button();
            this.DataGridForTables = new System.Windows.Forms.DataGridView();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridForTables)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Table name";
            // 
            // txtTableName
            // 
            this.txtTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableName.Location = new System.Drawing.Point(39, 74);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(518, 24);
            this.txtTableName.TabIndex = 1;
            // 
            // btnTableName
            // 
            this.btnTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnTableName.Location = new System.Drawing.Point(243, 117);
            this.btnTableName.Name = "btnTableName";
            this.btnTableName.Size = new System.Drawing.Size(110, 43);
            this.btnTableName.TabIndex = 2;
            this.btnTableName.Text = "Enter";
            this.btnTableName.UseVisualStyleBackColor = false;
            this.btnTableName.Click += new System.EventHandler(this.btnTableName_Click);
            // 
            // DataGridForTables
            // 
            this.DataGridForTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridForTables.Location = new System.Drawing.Point(39, 193);
            this.DataGridForTables.Name = "DataGridForTables";
            this.DataGridForTables.RowHeadersWidth = 62;
            this.DataGridForTables.RowTemplate.Height = 28;
            this.DataGridForTables.Size = new System.Drawing.Size(797, 348);
            this.DataGridForTables.TabIndex = 3;
            this.DataGridForTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridForTables_CellContentClick);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(311, 580);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(246, 41);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "Go Back";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // AdminViewDataFoam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 719);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.DataGridForTables);
            this.Controls.Add(this.btnTableName);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminViewDataFoam";
            this.Text = "AdminViewDataFoam";
            this.Load += new System.EventHandler(this.AdminViewDataFoam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridForTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Button btnTableName;
        private System.Windows.Forms.DataGridView DataGridForTables;
        private System.Windows.Forms.Button btnlogout;
    }
}