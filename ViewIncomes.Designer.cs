namespace Income_Expense_tracker
{
    partial class ViewIncomes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.IncNameTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LgVIncLbl = new System.Windows.Forms.Label();
            this.VExpSideMenu = new System.Windows.Forms.Label();
            this.IncSideMenu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpSideMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.IncomeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "Salary",
            "Business",
            "Tips",
            "Others"});
            this.CatCb.Location = new System.Drawing.Point(799, 139);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(170, 21);
            this.CatCb.TabIndex = 46;
            this.CatCb.SelectedIndexChanged += new System.EventHandler(this.CatCb_SelectedIndexChanged);
            // 
            // IncNameTB
            // 
            this.IncNameTB.Location = new System.Drawing.Point(397, 140);
            this.IncNameTB.Name = "IncNameTB";
            this.IncNameTB.Size = new System.Drawing.Size(172, 20);
            this.IncNameTB.TabIndex = 41;
            this.IncNameTB.TextChanged += new System.EventHandler(this.IncNameTB_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label9.Location = new System.Drawing.Point(260, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Income Name";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.RoyalBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1027, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 24);
            this.label14.TabIndex = 38;
            this.label14.Text = "X";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // LgVIncLbl
            // 
            this.LgVIncLbl.AutoSize = true;
            this.LgVIncLbl.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LgVIncLbl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LgVIncLbl.Location = new System.Drawing.Point(9, 556);
            this.LgVIncLbl.Name = "LgVIncLbl";
            this.LgVIncLbl.Size = new System.Drawing.Size(73, 24);
            this.LgVIncLbl.TabIndex = 7;
            this.LgVIncLbl.Text = "Logout";
            this.LgVIncLbl.Click += new System.EventHandler(this.LgVIncLbl_Click);
            // 
            // VExpSideMenu
            // 
            this.VExpSideMenu.AutoSize = true;
            this.VExpSideMenu.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VExpSideMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.VExpSideMenu.Location = new System.Drawing.Point(51, 340);
            this.VExpSideMenu.Name = "VExpSideMenu";
            this.VExpSideMenu.Size = new System.Drawing.Size(140, 20);
            this.VExpSideMenu.TabIndex = 6;
            this.VExpSideMenu.Text = "View Expenses";
            this.VExpSideMenu.Click += new System.EventHandler(this.VExpSideMenu_Click);
            // 
            // IncSideMenu
            // 
            this.IncSideMenu.AutoSize = true;
            this.IncSideMenu.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncSideMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.IncSideMenu.Location = new System.Drawing.Point(51, 190);
            this.IncSideMenu.Name = "IncSideMenu";
            this.IncSideMenu.Size = new System.Drawing.Size(72, 20);
            this.IncSideMenu.TabIndex = 5;
            this.IncSideMenu.Text = "Income";
            this.IncSideMenu.Click += new System.EventHandler(this.IncSideMenu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(51, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "DashBoard";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(51, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "View Income";
            // 
            // ExpSideMenu
            // 
            this.ExpSideMenu.AutoSize = true;
            this.ExpSideMenu.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpSideMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ExpSideMenu.Location = new System.Drawing.Point(51, 242);
            this.ExpSideMenu.Name = "ExpSideMenu";
            this.ExpSideMenu.Size = new System.Drawing.Size(81, 20);
            this.ExpSideMenu.TabIndex = 2;
            this.ExpSideMenu.Text = "Expense";
            this.ExpSideMenu.Click += new System.EventHandler(this.ExpSideMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.LgVIncLbl);
            this.panel1.Controls.Add(this.VExpSideMenu);
            this.panel1.Controls.Add(this.IncSideMenu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ExpSideMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense Tracker";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(255, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "View Income ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label12.Location = new System.Drawing.Point(671, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Categories";
            // 
            // IncomeDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.IncomeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IncomeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.IncomeDGV.ColumnHeadersHeight = 22;
            this.IncomeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.IncomeDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.IncomeDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.IncomeDGV.Location = new System.Drawing.Point(206, 190);
            this.IncomeDGV.Name = "IncomeDGV";
            this.IncomeDGV.RowHeadersVisible = false;
            this.IncomeDGV.RowHeadersWidth = 62;
            this.IncomeDGV.Size = new System.Drawing.Size(837, 398);
            this.IncomeDGV.TabIndex = 51;
            this.IncomeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.IncomeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.IncomeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.IncomeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.IncomeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.IncomeDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.IncomeDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.IncomeDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Indigo;
            this.IncomeDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.IncomeDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.IncomeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.IncomeDGV.ThemeStyle.HeaderStyle.Height = 22;
            this.IncomeDGV.ThemeStyle.ReadOnly = false;
            this.IncomeDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gold;
            this.IncomeDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.IncomeDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.IncomeDGV.ThemeStyle.RowsStyle.Height = 22;
            this.IncomeDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Magenta;
            this.IncomeDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.IncomeDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IncomeDGV_CellContentClick);
            // 
            // ViewIncomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1055, 600);
            this.Controls.Add(this.IncomeDGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.IncNameTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewIncomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewIncomes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.TextBox IncNameTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LgVIncLbl;
        private System.Windows.Forms.Label VExpSideMenu;
        private System.Windows.Forms.Label IncSideMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ExpSideMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DataGridView IncomeDGV;
    }
}