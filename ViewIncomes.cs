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
    public partial class ViewIncomes : Form
    {
        public ViewIncomes()
        {
            InitializeComponent();
            DisplayIncomes();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maahi\Documents\FinanceDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayIncomes()
        {
            Con.Open();
            string Query = "select * from IncomeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            IncomeDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IncomeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VExpSideMenu_Click(object sender, EventArgs e)
        {
            ViewExpenses Obj = new ViewExpenses();
            Obj.Show();
            this.Hide();
        }

        private void ExpSideMenu_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }

        private void IncSideMenu_Click(object sender, EventArgs e)
        {
            Incomes Obj = new Incomes();
            Obj.Show();
            this.Hide();
        }

        private void LgVIncLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }


        private void ApplyFilters()
        {
            string name = IncNameTB.Text.Trim();
            string category = (CatCb.SelectedItem == null) ? "" : CatCb.SelectedItem.ToString();

            try
            {
                Con.Open();

                string query = @"
            SELECT *
            FROM IncomeTbl
            WHERE IncUser = @User
              AND (@Name = '' OR IncName LIKE '%' + @Name + '%')
              AND (@Cat = '' OR IncCat = @Cat)
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
                        IncomeDGV.DataSource = dt;
                    }
                }
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }


        private void IncNameTB_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
