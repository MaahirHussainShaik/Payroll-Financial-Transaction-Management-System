using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Income_Expense_tracker
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maahi\Documents\FinanceDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void Clear()
        {
            UnameTb.Text = string.Empty;
            PasswordTb.Text = string.Empty;
            PhoneTb.Text = string.Empty;
            AddressTb.Text = string.Empty;
        }
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == ""|| PhoneTb.Text == "" || PasswordTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTbl(Uname,UDate,Uphone,UPass,UAddress)values(@UN,@UD,@UP,@UPA,@UA)",Con);
                    cmd.Parameters.AddWithValue("@UN", UnameTb.Text);
                    cmd.Parameters.AddWithValue("@UD", DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@UP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@UPA", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@UA", AddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Added");
                    Con.Close();
                    Clear();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void BackLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
