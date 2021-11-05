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
    public partial class borrowBooks : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ALIENWARE\SQLExpress;Initial Catalog=LibHelperDB;Integrated Security=True");

        public borrowBooks()
        {
            InitializeComponent();
        }

        private void btnBBSearchX_Click(object sender, EventArgs e)
        {
            if (txtBB_MId.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT NIC FROM Member WHERE MemberID=@MID";
                    cmd.Parameters.AddWithValue("@MID", txtBB_MId.Text);

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
                            txtBB_Nic.Text = dr["NIC"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Member ID is Invalid!\nPlease Insert a Valid Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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

        private void btnBBBorrow_Click(object sender, EventArgs e)
        {
            if (txtBB_MId.Text == "" || txtBB_Bid.Text == "" || dateTimePickerBB_Frd.Value == DateTime.Now)
            {
                MessageBox.Show("Empty Fields Found!\nPlease Fill All Required Fields That Marked *.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "INSERT INTO Borrow VALUES (@MID,@NIC,@BID,@Tit,@Bdate,@Rdate)";
                    cmd.Parameters.AddWithValue("@MID", txtBB_MId.Text);
                    cmd.Parameters.AddWithValue("@NIC", txtBB_Nic.Text);
                    cmd.Parameters.AddWithValue("@BID", txtBB_Bid.Text);
                    cmd.Parameters.AddWithValue("@Tit", txtBB_BTitle.Text);
                    cmd.Parameters.AddWithValue("@Bdate", dateTimePickerBB_BDate.Value);
                    cmd.Parameters.AddWithValue("@Rdate", dateTimePickerBB_Frd.Value);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    BBClear();

                    MessageBox.Show("Book Succesfully Borrowed!\nAll Details Saved Into Database.", "Book Borrowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBBSearchY_Click(object sender, EventArgs e)
        {
            if (txtBB_Bid.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT BookTitle FROM Book WHERE BookID=@BID";
                    cmd.Parameters.AddWithValue("@BID", txtBB_Bid.Text);

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
                            txtBB_BTitle.Text = dr["BookTitle"].ToString();
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

        private void btnBBClear_Click(object sender, EventArgs e)
        {
            BBClear();
        }

        private void BBClear()
        {
            txtBB_MId.Text = "";
            txtBB_Nic.Text = "";
            txtBB_Bid.Text = "";
            txtBB_BTitle.Text = "";
            dateTimePickerBB_BDate.Value = DateTime.Now;
            dateTimePickerBB_Frd.Value = DateTime.Now;
        }
    }
}
