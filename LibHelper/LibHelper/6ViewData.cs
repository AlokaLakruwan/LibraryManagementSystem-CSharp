using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibHelper
{
    public partial class viewData : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ALIENWARE\SQLExpress;Initial Catalog=LibHelperDB;Integrated Security=True");
        public String txt;

        public viewData()
        {
            InitializeComponent();
            comboBoxRe.SelectedIndex = 0;
        }

        private void btnMUClear_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void comboBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void ViewBooks()
        {
            try{
                 con.Open();
                 SqlCommand cmd = con.CreateCommand();
                 cmd.CommandType = CommandType.Text;

                 cmd.CommandText = "SELECT * FROM Book";

                 cmd.ExecuteNonQuery();
                 con.Close();

                 DataTable dt = new DataTable();
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 da.Fill(dt);

                 int i = Convert.ToInt32(dt.Rows.Count.ToString());
                
                 if (i != 0)
                 {
                      dataGridView.DataSource = dt;
                 }
                 else
                 {
                     MessageBox.Show("No Data Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
            }
            catch (Exception ex)
            {
                 Console.WriteLine(ex.Message);
                 MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewMembers()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM Member";

                cmd.ExecuteNonQuery();
                con.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                int i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i != 0)
                {
                    dataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewBorrowedBooks()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM Borrow";

                cmd.ExecuteNonQuery();
                con.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                int i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i != 0)
                {
                    dataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewReturnedBooks()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM Returned";

                cmd.ExecuteNonQuery();
                con.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                int i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i != 0)
                {
                    dataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxRe_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt = comboBoxRe.Text;

            if (txt == "Book Details")
            {
                ViewBooks();
            }
            else if (txt == "Member Details")
            {
                ViewMembers();
            }
            else if (txt == "Borrowed Books")
            {
                ViewBorrowedBooks();
            }
            else if(txt == "Returned Books")
            {
                ViewReturnedBooks();
            }
        }
    }
}
