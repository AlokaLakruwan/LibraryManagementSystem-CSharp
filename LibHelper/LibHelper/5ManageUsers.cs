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
    public partial class manageUsers : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=ALIENWARE\SQLExpress;Initial Catalog=LibHelperDB;Integrated Security=True");

        public manageUsers()
        {
            InitializeComponent();
            comboBoxMU_UType.SelectedIndex = 0;
        }

        static void main(string[] args)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMUSave_Click(object sender, EventArgs e)
        {
            if (txtMU_UName.Text == "" || txtMU_Pw1.Text == "" || txtMU_Pw2.Text=="" || comboBoxMU_UType.Text=="")
            {
                MessageBox.Show("Empty Fields Not Allowed!\nPlease Fill Empty Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtMU_Pw1.Text != txtMU_Pw2.Text)
            {
                MessageBox.Show("Passwords Not Equal!\nPlease Insert Same Password in the password Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "INSERT INTO UserDetail VALUES (@UN,@UT,@PW)";
                    cmd.Parameters.AddWithValue("@UN", txtMU_UName.Text);
                    cmd.Parameters.AddWithValue("@UT", comboBoxMU_UType.Text);
                    cmd.Parameters.AddWithValue("@PW", txtMU_Pw1.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MUClear();

                    MessageBox.Show("New User Succesfully Added!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMUClear_Click(object sender, EventArgs e)
        {
            MUClear();
        }

        private void MUClear()
        {
            txtMU_UName.Text = "";
            comboBoxMU_UType.SelectedIndex = 0;
            txtMU_Pw1.Text = "";
            txtMU_Pw2.Text = "";
        }

        private void btnMUSearchX_Click(object sender, EventArgs e)
        {
            if (txtMU_UName.Text != "") {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT * FROM UserDetail WHERE UserName=@UN";
                    cmd.Parameters.AddWithValue("@UN", txtMU_UName.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    int i = Convert.ToInt16(dt.Rows.Count.ToString());
                    if (i != 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            comboBoxMU_UType.Text = dr["UserType"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Data Found!\nPlease Check Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Username is Empty!\nPlease Enter a Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnMUUpdate_Click(object sender, EventArgs e)
        {
            if (txtMU_UName.Text == "" || txtMU_Pw1.Text == "" || txtMU_Pw2.Text == "" || comboBoxMU_UType.Text == "")
            {
                MessageBox.Show("Empty Fields Not Allowed!\nPlease Fill Empty Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMU_Pw1.Text != txtMU_Pw2.Text)
            {
                MessageBox.Show("Passwords Not Equal!\nPlease Insert Same Password in the password Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "UPDATE UserDetail SET Password=@PW WHERE UserName=@UN";
                    cmd.Parameters.AddWithValue("@UN", txtMU_UName.Text);
                    cmd.Parameters.AddWithValue("@PW", txtMU_Pw1.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MUClear();

                    MessageBox.Show("User Details Succesfully Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMUDelete_Click(object sender, EventArgs e)
        {
            if (txtMU_UName.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "DELETE FROM UserDetail WHERE UserName=@UN";
                    cmd.Parameters.AddWithValue("@UN", txtMU_UName.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MUClear();
                    MessageBox.Show("User Details Succesfully Removed!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Username is Empty!\nPlease Enter a Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
