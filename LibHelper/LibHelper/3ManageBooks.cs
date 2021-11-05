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
    public partial class manageBooks : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ALIENWARE\SQLExpress;Initial Catalog=LibHelperDB;Integrated Security=True");

        public manageBooks()
        {
            InitializeComponent();
            AutoGenID();
        }

        private void txtMB_Author_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnMBClear_Click(object sender, EventArgs e)
        {
            MBClear();
        }

        private void MBClear()
        {
            txtMB_Id.Text = "";
            txtMB_Bt.Text = "";
            comboBoxMB_Cat.SelectedIndex = -1;
            txtMB_Author.Text = "";
            txtMB_Isbn.Text = "";
            txtMB_Price.Text = "";
            txtMB_Ver.Text = "";
            txtMB_Desc.Text = "";
            txtMB_Bno.Text = "";
            txtMB_Rno.Text = "";
            txtMB_Cno.Text = "";
            AutoGenID();
        }

        private void AutoGenID()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(BookID AS INT)),0)+1 FROM Book", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtMB_Id.Text = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Book ID Auto Genaration Failed!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMBSave_Click(object sender, EventArgs e)
        {
            if (txtMB_Id.Text == "" || txtMB_Bt.Text == "" || txtMB_Author.Text == "" || txtMB_Isbn.Text == "" || txtMB_Price.Text == "")
            {
                MessageBox.Show("Empty Fields Found!\nPlease Fill All Required Fields That Marked *.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxMB_Cat.Text=="")
            {
                MessageBox.Show("Book Category Not Selected!\nPlease Select Book Category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "INSERT INTO Book VALUES (@BID,@Tit,@Cat,@Auth,@ISBN,@Price,@Ver,@Desc,@BNo,@RNo,@CNo)";
                    cmd.Parameters.AddWithValue("@BID", txtMB_Id.Text);
                    cmd.Parameters.AddWithValue("@Tit", txtMB_Bt.Text);
                    cmd.Parameters.AddWithValue("@Cat", comboBoxMB_Cat.Text);
                    cmd.Parameters.AddWithValue("@Auth", txtMB_Author.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txtMB_Isbn.Text);
                    cmd.Parameters.AddWithValue("@Price", txtMB_Price.Text);
                    cmd.Parameters.AddWithValue("@Ver", txtMB_Ver.Text);
                    cmd.Parameters.AddWithValue("@Desc", txtMB_Desc.Text);
                    cmd.Parameters.AddWithValue("@BNo", txtMB_Bno.Text);
                    cmd.Parameters.AddWithValue("@RNo", txtMB_Rno.Text);
                    cmd.Parameters.AddWithValue("@CNo", txtMB_Cno.Text);

                    
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MBClear();
                    AutoGenID();

                    MessageBox.Show("New Book Succesfully Added!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMBSearchX_Click(object sender, EventArgs e)
        {
            if (txtMB_Id.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT * FROM Book WHERE BookID=@BID";
                    cmd.Parameters.AddWithValue("@BID", txtMB_Id.Text);

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
                            txtMB_Bt.Text = dr["BookTitle"].ToString();
                            comboBoxMB_Cat.Text = dr["Cat"].ToString();
                            txtMB_Author.Text = dr["Author"].ToString();
                            txtMB_Isbn.Text = dr["ISBN"].ToString();
                            txtMB_Price.Text = dr["Price"].ToString();
                            txtMB_Ver.Text = dr["Version"].ToString();
                            txtMB_Desc.Text = dr["Description"].ToString();
                            txtMB_Bno.Text = dr["BsNo"].ToString();
                            txtMB_Rno.Text = dr["BsRNo"].ToString();
                            txtMB_Cno.Text = dr["BsCNo"].ToString();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Book ID is Invalid!\nPlease Insert a Valid Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMBUpdate_Click(object sender, EventArgs e)
        {
            if (txtMB_Id.Text == "" || txtMB_Bt.Text == "" || txtMB_Author.Text == "" || txtMB_Isbn.Text == "" || txtMB_Price.Text == "")
            {
                MessageBox.Show("Empty Fields Found!\nPlease Fill All Required Fields That Marked *.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxMB_Cat.Text == "")
            {
                MessageBox.Show("Book Category Not Selected!\nPlease Select Book Category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "UPDATE Book SET BookTitle=@Tit,Cat=@Cat,Author=@Auth,ISBN=@ISBN,Price=@Price,Version=@Ver,Description=@Desc,BsNo=@BNo,BsRNo=@RNo,BsCNo=@CNo WHERE BookID=@BID";
                    cmd.Parameters.AddWithValue("@BID", txtMB_Id.Text);
                    cmd.Parameters.AddWithValue("@Tit", txtMB_Bt.Text);
                    cmd.Parameters.AddWithValue("@Cat", comboBoxMB_Cat.Text);
                    cmd.Parameters.AddWithValue("@Auth", txtMB_Author.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txtMB_Isbn.Text);
                    cmd.Parameters.AddWithValue("@Price", txtMB_Price.Text);
                    cmd.Parameters.AddWithValue("@Ver", txtMB_Ver.Text);
                    cmd.Parameters.AddWithValue("@Desc", txtMB_Desc.Text);
                    cmd.Parameters.AddWithValue("@BNo", txtMB_Bno.Text);
                    cmd.Parameters.AddWithValue("@RNo", txtMB_Rno.Text);
                    cmd.Parameters.AddWithValue("@CNo", txtMB_Cno.Text);
                    
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MBClear();
                    AutoGenID();

                    MessageBox.Show("Book Detail Succesfully Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMBDelete_Click(object sender, EventArgs e)
        {
            if (txtMB_Id.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "DELETE FROM Book WHERE BookID=@BID";
                    cmd.Parameters.AddWithValue("@BID", txtMB_Id.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MBClear();
                    AutoGenID();
                    MessageBox.Show("Book Details Succesfully Removed!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Member ID Required!\nPlease Enter a Valid Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
