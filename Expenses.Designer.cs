namespace Income_Expense_tracker
{
    partial class Expenses
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.ExpDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.ExpDescTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ExpAmtTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ExpNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ExpLbl = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LgExp = new System.Windows.Forms.Label();
            this.ViewExpenseTabSideMenu = new System.Windows.Forms.Label();
            this.VIncSideMenu = new System.Windows.Forms.Label();
            this.Dashboard_menu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IncSideMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Aqua;
            this.SaveBtn.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(576, 531);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(190, 31);
            this.SaveBtn.TabIndex = 50;
            this.SaveBtn.Text = "Save Expense";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label13.Location = new System.Drawing.Point(802, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "Date";
            // 
            // ExpDate
            // 
            this.ExpDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpDate.Location = new System.Drawing.Point(805, 256);
            this.ExpDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(176, 29);
            this.ExpDate.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label12.Location = new System.Drawing.Point(801, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Categories";
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
            this.CatCb.Location = new System.Drawing.Point(805, 177);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(170, 21);
            this.CatCb.TabIndex = 46;
            // 
            // ExpDescTb
            // 
            this.ExpDescTb.Location = new System.Drawing.Point(675, 356);
            this.ExpDescTb.Multiline = true;
            this.ExpDescTb.Name = "ExpDescTb";
            this.ExpDescTb.Size = new System.Drawing.Size(209, 94);
            this.ExpDescTb.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label11.Location = new System.Drawing.Point(671, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Description";
            // 
            // ExpAmtTb
            // 
            this.ExpAmtTb.Location = new System.Drawing.Point(521, 265);
            this.ExpAmtTb.Name = "ExpAmtTb";
            this.ExpAmtTb.Size = new System.Drawing.Size(172, 20);
            this.ExpAmtTb.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label10.Location = new System.Drawing.Point(517, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Amount";
            // 
            // ExpNameTb
            // 
            this.ExpNameTb.Location = new System.Drawing.Point(521, 177);
            this.ExpNameTb.Name = "ExpNameTb";
            this.ExpNameTb.Size = new System.Drawing.Size(172, 20);
            this.ExpNameTb.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label9.Location = new System.Drawing.Point(517, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Expense Name";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Cyan;
            this.panel9.Controls.Add(this.ExpLbl);
            this.panel9.Controls.Add(this.label31);
            this.panel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel9.Location = new System.Drawing.Point(225, 374);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(207, 81);
            this.panel9.TabIndex = 39;
            // 
            // ExpLbl
            // 
            this.ExpLbl.AutoSize = true;
            this.ExpLbl.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.ExpLbl.Location = new System.Drawing.Point(31, 44);
            this.ExpLbl.Name = "ExpLbl";
            this.ExpLbl.Size = new System.Drawing.Size(79, 20);
            this.ExpLbl.TabIndex = 6;
            this.ExpLbl.Text = "Amount";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Cyan;
            this.label31.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.SteelBlue;
            this.label31.Location = new System.Drawing.Point(31, 19);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(126, 20);
            this.label31.TabIndex = 5;
            this.label31.Text = "Total Expenses";
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
            // LgExp
            // 
            this.LgExp.AutoSize = true;
            this.LgExp.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LgExp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LgExp.Location = new System.Drawing.Point(9, 556);
            this.LgExp.Name = "LgExp";
            this.LgExp.Size = new System.Drawing.Size(73, 24);
            this.LgExp.TabIndex = 7;
            this.LgExp.Text = "Logout";
            this.LgExp.Click += new System.EventHandler(this.LgExp_Click);
            // 
            // ViewExpenseTabSideMenu
            // 
            this.ViewExpenseTabSideMenu.AutoSize = true;
            this.ViewExpenseTabSideMenu.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewExpenseTabSideMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ViewExpenseTabSideMenu.Location = new System.Drawing.Point(51, 340);
            this.ViewExpenseTabSideMenu.Name = "ViewExpenseTabSideMenu";
            this.ViewExpenseTabSideMenu.Size = new System.Drawing.Size(140, 20);
            this.ViewExpenseTabSideMenu.TabIndex = 6;
            this.ViewExpenseTabSideMenu.Text = "View Expenses";
            this.ViewExpenseTabSideMenu.Click += new System.EventHandler(this.ViewExpenseTabSideMenu_Click);
            // 
            // VIncSideMenu
            // 
            this.VIncSideMenu.AutoSize = true;
            this.VIncSideMenu.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIncSideMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.VIncSideMenu.Location = new System.Drawing.Point(50, 291);
            this.VIncSideMenu.Name = "VIncSideMenu";
            this.VIncSideMenu.Size = new System.Drawing.Size(123, 20);
            this.VIncSideMenu.TabIndex = 5;
            this.VIncSideMenu.Text = "View Income";
            this.VIncSideMenu.Click += new System.EventHandler(this.VIncSideMenu_Click);
            // 
            // Dashboard_menu
            // 
            this.Dashboard_menu.AutoSize = true;
            this.Dashboard_menu.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_menu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Dashboard_menu.Location = new System.Drawing.Point(51, 140);
            this.Dashboard_menu.Name = "Dashboard_menu";
            this.Dashboard_menu.Size = new System.Drawing.Size(104, 20);
            this.Dashboard_menu.TabIndex = 4;
            this.Dashboard_menu.Text = "DashBoard";
            this.Dashboard_menu.Click += new System.EventHandler(this.Dashboard_menu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(50, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Expense";
            // 
            // IncSideMenu
            // 
            this.IncSideMenu.AutoSize = true;
            this.IncSideMenu.Font = new System.Drawing.Font("Mongolian Baiti", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncSideMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.IncSideMenu.Location = new System.Drawing.Point(51, 190);
            this.IncSideMenu.Name = "IncSideMenu";
            this.IncSideMenu.Size = new System.Drawing.Size(72, 20);
            this.IncSideMenu.TabIndex = 2;
            this.IncSideMenu.Text = "Income";
            this.IncSideMenu.Click += new System.EventHandler(this.IncSideMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.LgExp);
            this.panel1.Controls.Add(this.ViewExpenseTabSideMenu);
            this.panel1.Controls.Add(this.VIncSideMenu);
            this.panel1.Controls.Add(this.Dashboard_menu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IncSideMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 599);
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
            this.label7.Size = new System.Drawing.Size(145, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "Expense Details";
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 599);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ExpDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.ExpDescTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ExpAmtTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ExpNameTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker ExpDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.TextBox ExpDescTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ExpAmtTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ExpNameTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label ExpLbl;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LgExp;
        private System.Windows.Forms.Label ViewExpenseTabSideMenu;
        private System.Windows.Forms.Label VIncSideMenu;
        private System.Windows.Forms.Label Dashboard_menu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IncSideMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}