using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income_Expense_tracker
{
    public partial class ViewExpenses : Form
    {
        public ViewExpenses()
        {
            InitializeComponent();
            DisplayExpenses();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maahi\Documents\FinanceDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayExpenses()
        {
            Con.Open();
            string Query = "select * from ExpenseTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpenseDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ViewExpenseCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashBoardSideMenu_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void IncomeSideMenu_Click(object sender, EventArgs e)
        {
            Incomes Obj = new Incomes();
            Obj.Show();
            this.Hide();
        }

        private void ExpenseSideMenu_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();

        }

        private void ViewIncomeSideMenu_Click(object sender, EventArgs e)
        {
            ViewIncomes Obj = new ViewIncomes();
            Obj.Show();
            this.Hide();
        }

        private void VExpLg_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void ExpnameTb_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string name = ExpnameTb.Text.Trim();
            string category = (CatCb.SelectedItem == null) ? "" : CatCb.SelectedItem.ToString();

            try
            {
                Con.Open();

                string query = @"
            SELECT *
            FROM ExpenseTbl
            WHERE ExpUser = @User
              AND (@Name = '' OR ExpName LIKE '%' + @Name + '%')
              AND (@Cat = '' OR ExpCat = @Cat)
        ";

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@User", Login.User);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Cat", category);

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        ExpenseDGV.DataSource = dt;
                    }
                }
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }

    }
}
