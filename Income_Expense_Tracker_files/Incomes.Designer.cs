namespace Income_Expense_tracker
{
    partial class Incomes
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.TotIncLbl = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LgInc = new System.Windows.Forms.Label();
            this.VExpSideMenu = new System.Windows.Forms.Label();
            this.VIncSideMenu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpSideMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IncNameTb = new System.Windows.Forms.TextBox();
            this.IncAmtTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IncDescTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.IncDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Cyan;
            this.panel9.Controls.Add(this.TotIncLbl);
            this.panel9.Controls.Add(this.label31);
            this.panel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel9.Location = new System.Drawing.Point(223, 374);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(207, 81);
            this.panel9.TabIndex = 23;
            // 
            // TotIncLbl
            // 
            this.TotIncLbl.AutoSize = true;
            this.TotIncLbl.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotIncLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.TotIncLbl.Location = new System.Drawing.Point(31, 44);
            this.TotIncLbl.Name = "TotIncLbl";
            this.TotIncLbl.Size = new System.Drawing.Size(79, 20);
            this.TotIncLbl.TabIndex = 6;
            this.TotIncLbl.Text = "Amount";
            this.TotIncLbl.Click += new System.EventHandler(this.TotIncLbl_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Cyan;
            this.label31.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.SteelBlue;
            this.label31.Location = new System.Drawing.Point(31, 19);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(110, 20);
            this.label31.TabIndex = 5;
            this.label31.Text = "Total income";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.LgInc);
            this.panel1.Controls.Add(this.VExpSideMenu);
            this.panel1.Controls.Add(this.VIncSideMenu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ExpSideMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 13;
            // 
            // LgInc
            // 
            this.LgInc.AutoSize = true;
            this.LgInc.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LgInc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LgInc.Location = new System.Drawing.Point(9, 556);
            this.LgInc.Name = "LgInc";
            this.LgInc.Size = new System.Drawing.Size(73, 24);
            this.LgInc.TabIndex = 7;
            this.LgInc.Text = "Logout";
            this.LgInc.Click += new System.EventHandler(this.LgInc_Click);
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
            this.label3.Location = new System.Drawing.Point(50, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Income";
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
            this.label7.Location = new System.Drawing.Point(253, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Income Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.RoyalBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1025, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 24);
            this.label14.TabIndex = 16;
            this.label14.Text = "X";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label9.Location = new System.Drawing.Point(515, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Income Name";
            // 
            // IncNameTb
            // 
            this.IncNameTb.Location = new System.Drawing.Point(519, 177);
            this.IncNameTb.Name = "IncNameTb";
            this.IncNameTb.Size = new System.Drawing.Size(172, 20);
            this.IncNameTb.TabIndex = 25;
            // 
            // IncAmtTb
            // 
            this.IncAmtTb.Location = new System.Drawing.Point(519, 265);
            this.IncAmtTb.Name = "IncAmtTb";
            this.IncAmtTb.Size = new System.Drawing.Size(172, 20);
            this.IncAmtTb.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label10.Location = new System.Drawing.Point(515, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Amount";
            // 
            // IncDescTb
            // 
            this.IncDescTb.Location = new System.Drawing.Point(673, 356);
            this.IncDescTb.Multiline = true;
            this.IncDescTb.Name = "IncDescTb";
            this.IncDescTb.Size = new System.Drawing.Size(209, 94);
            this.IncDescTb.TabIndex = 29;
            this.IncDescTb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label11.Location = new System.Drawing.Point(669, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Description";
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "Salary",
            "Business",
            "Tips",
            "Others"});
            this.CatCb.Location = new System.Drawing.Point(803, 177);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(170, 21);
            this.CatCb.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label12.Location = new System.Drawing.Point(799, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Categories";
            // 
            // IncDate
            // 
            this.IncDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IncDate.Location = new System.Drawing.Point(803, 256);
            this.IncDate.Margin = new System.Windows.Forms.Padding(2);
            this.IncDate.Name = "IncDate";
            this.IncDate.Size = new System.Drawing.Size(176, 29);
            this.IncDate.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label13.Location = new System.Drawing.Point(800, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Date";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Aqua;
            this.SaveBtn.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(574, 531);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(190, 31);
            this.SaveBtn.TabIndex = 35;
            this.SaveBtn.Text = "Save Income";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Incomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1055, 600);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.IncDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.IncDescTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.IncAmtTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IncNameTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Incomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incomes";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label TotIncLbl;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LgInc;
        private System.Windows.Forms.Label VExpSideMenu;
        private System.Windows.Forms.Label VIncSideMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ExpSideMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IncNameTb;
        private System.Windows.Forms.TextBox IncAmtTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IncDescTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.DateTimePicker IncDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label12;
    }
}