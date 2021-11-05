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

namespace LibHelper
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ALIENWARE\SQLExpress;Initial Catalog=LibHelperDB;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (txtUName.Text=="" || txtPw.Text=="") {
                MessageBox.Show("Please Insert Username And Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT * FROM UserDetail WHERE UserName=@UN";
                    cmd.Parameters.AddWithValue("@UN", txtUName.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    int i = Convert.ToInt16(dt.Rows.Count.ToString());
                    if (i != 0)
                    {*/
                        this.Hide();
                        new Form1().ShowDialog();
                        this.Close();
                   /* }
                    else
                    {
                        MessageBox.Show("Username and Password is Incorrect!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }
    }
}
