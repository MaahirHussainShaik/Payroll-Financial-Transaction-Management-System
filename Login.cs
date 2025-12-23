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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maahi\Documents\FinanceDB.mdf;Integrated Security=True;Connect Timeout=30");
        public static string User;
        private void button1_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Valid Username and Password");
            }
            else
            {
                try
                {
                    Con.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM UserTbl WHERE UName = @name AND UPass = @pass", Con))
                    {
                        cmd.Parameters.AddWithValue("@name", UnameTb.Text);
                        cmd.Parameters.AddWithValue("@pass", PasswordTb.Text);

                        int count = (int)cmd.ExecuteScalar();

                        if (count == 1)
                        {
                            User = UnameTb.Text;
                            Dashboard obj = new Dashboard();
                            obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong UserName or Password!!");
                            UnameTb.Clear();
                            PasswordTb.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
            }

        }

        private void LoginCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
   }
