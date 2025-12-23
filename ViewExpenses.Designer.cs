namespace Income_Expense_tracker
{
    partial class ViewExpenses
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
            this.ExpnameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ViewExpenseCloseBtn = new System.Windows.Forms.Label();
            this.VExpLg = new System.Windows.Forms.Label();
            this.ViewIncomeSideMenu = new System.Windows.Forms.Label();
            this.IncomeSideMenu = new System.Windows.Forms.Label();
            this.DashBoardSideMenu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpenseSideMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpenseDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "Food",
            "Shopping",
            "Medical",
            "Household",
            "Travel",
            "Vehicle",
            "Others"});
            this.CatCb.Location = new System.Drawing.Point(800, 139);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(170, 21);
            this.CatCb.TabIndex = 57;
            this.CatCb.SelectedIndexChanged += new System.EventHandler(this.CatCb_SelectedIndexChanged);
            // 
            // ExpnameTb
            // 
            this.ExpnameTb.Location = new System.Drawing.Point(398, 140);
            this.ExpnameTb.Name = "ExpnameTb";
            this.ExpnameTb.Size = new System.Drawing.Size(172, 20);
            this.ExpnameTb.TabIndex = 56;
            this.ExpnameTb.TextChanged += new System.EventHandler(this.ExpnameTb_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label9.Location = new System.Drawing.Point(261, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "Expense Name";
            // 
            // ViewExpenseCloseBtn
            // 
            this.ViewExpenseCloseBtn.AutoSize = true;
            this.ViewExpenseCloseBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.ViewExpenseCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewExpenseCloseBtn.Location = new System.Drawing.Point(1028, 12);
            this.ViewExpenseCloseBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ViewExpenseCloseBtn.Name = "ViewExpenseCloseBtn";
            this.ViewExpenseCloseBtn.Size = new System.Drawing.Size(25, 24);
            this.ViewExpenseCloseBtn.TabIndex = 54;
            this.ViewExpenseCloseBtn.Text = "X";
            this.ViewExpenseCloseBtn.Click += new System.EventHandler(this.ViewExpenseCloseBtn_Click);
            // 
            // VExpLg
            // 
            this.VExpLg.AutoSize = true;
            this.VExpLg.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VExpLg.ForeColor = System.Drawing.SystemColors.GrayText;
            this.VExpLg.Location = new System.Drawing.Point(12, 575);
            this.VExpLg.Name = "VExpLg";
            this.VExpLg.Size = new System.Drawing.Size(73, 24);
            this.VExpLg.TabIndex = 7;
            this.VExpLg.Text = "Logout";
            this.VExpLg.Click += new System.EventHandler(this.VExpLg_Click);
            // 
            // ViewIncomeSideMenu
            // 
            this.ViewIncomeSideMenu.AutoSize = true;
            this.ViewIncomeSideMenu.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewIncomeSideMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ViewIncomeSideMenu.Location = new System.Drawing.Point(51, 290);
            this.ViewIncomeSideMenu.Name = "ViewIncomeSideMenu";
            this.ViewIncomeSideMenu.Size = new System.Drawing.Size(123, 20);
            this.ViewIncomeSideMenu.TabIndex = 6;
            this.ViewIncomeSideMenu.Text = "View Income";
            this.ViewIncomeSideMenu.Click += new System.EventHandler(this.ViewIncomeSideMenu_Click);
            // 
            // IncomeSideMenu
            // 
            this.IncomeSideMenu.AutoSize = true;
            this.IncomeSideMenu.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeSideMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.IncomeSideMenu.Location = new System.Drawing.Point(51, 190);
            this.IncomeSideMenu.Name = "IncomeSideMenu";
            this.IncomeSideMenu.Size = new System.Drawing.Size(72, 20);
            this.IncomeSideMenu.TabIndex = 5;
            this.IncomeSideMenu.Text = "Income";
            this.IncomeSideMenu.Click += new System.EventHandler(this.IncomeSideMenu_Click);
            // 
            // DashBoardSideMenu
            // 
            this.DashBoardSideMenu.AutoSize = true;
            this.DashBoardSideMenu.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardSideMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DashBoardSideMenu.Location = new System.Drawing.Point(51, 140);
            this.DashBoardSideMenu.Name = "DashBoardSideMenu";
            this.DashBoardSideMenu.Size = new System.Drawing.Size(104, 20);
            this.DashBoardSideMenu.TabIndex = 4;
            this.DashBoardSideMenu.Text = "DashBoard";
            this.DashBoardSideMenu.Click += new System.EventHandler(this.DashBoardSideMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(51, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "View Expenses";
            // 
            // ExpenseSideMenu
            // 
            this.ExpenseSideMenu.AutoSize = true;
            this.ExpenseSideMenu.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseSideMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ExpenseSideMenu.Location = new System.Drawing.Point(51, 242);
            this.ExpenseSideMenu.Name = "ExpenseSideMenu";
            this.ExpenseSideMenu.Size = new System.Drawing.Size(81, 20);
            this.ExpenseSideMenu.TabIndex = 2;
            this.ExpenseSideMenu.Text = "Expense";
            this.ExpenseSideMenu.Click += new System.EventHandler(this.ExpenseSideMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.VExpLg);
            this.panel1.Controls.Add(this.ViewIncomeSideMenu);
            this.panel1.Controls.Add(this.IncomeSideMenu);
            this.panel1.Controls.Add(this.DashBoardSideMenu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ExpenseSideMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 52;
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
            // ExpenseDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ExpenseDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpenseDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ExpenseDGV.ColumnHeadersHeight = 4;
            this.ExpenseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpenseDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ExpenseDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ExpenseDGV.Location = new System.Drawing.Point(207, 190);
            this.ExpenseDGV.Name = "ExpenseDGV";
            this.ExpenseDGV.RowHeadersVisible = false;
            this.ExpenseDGV.RowHeadersWidth = 62;
            this.ExpenseDGV.Size = new System.Drawing.Size(837, 398);
            this.ExpenseDGV.TabIndex = 59;
            this.ExpenseDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ExpenseDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ExpenseDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ExpenseDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ExpenseDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ExpenseDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ExpenseDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ExpenseDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExpenseDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ExpenseDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ExpenseDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ExpenseDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.ExpenseDGV.ThemeStyle.ReadOnly = false;
            this.ExpenseDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ExpenseDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExpenseDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ExpenseDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ExpenseDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ExpenseDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label12.Location = new System.Drawing.Point(672, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 58;
            this.label12.Text = "Categories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(256, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 23);
            this.label7.TabIndex = 53;
            this.label7.Text = "View Expense";
            // 
            // ViewExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1055, 600);
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.ExpnameTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ViewExpenseCloseBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExpenseDGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewExpenses";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.TextBox ExpnameTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ViewExpenseCloseBtn;
        private System.Windows.Forms.Label VExpLg;
        private System.Windows.Forms.Label ViewIncomeSideMenu;
        private System.Windows.Forms.Label IncomeSideMenu;
        private System.Windows.Forms.Label DashBoardSideMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ExpenseSideMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView ExpenseDGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
    }
}