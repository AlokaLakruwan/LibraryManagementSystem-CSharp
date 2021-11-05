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
    public partial class returnBooks : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ALIENWARE\SQLExpress;Initial Catalog=LibHelperDB;Integrated Security=True");
        DateTime dateConvert;
        int totDaysInt;

        public returnBooks()
        {
            InitializeComponent();
        }

        private void btnRBClear_Click(object sender, EventArgs e)
        {
            RBClear();
        }

        private void RBClear()
        {
            txtRB_Id.Text = "";
            txtRB_Nic.Text = "";
            txtRB_Bid.Text = "";
            txtRB_BTitle.Text = "";
            dateTimePickerRB_BDate.Value = DateTime.Now;
            dateTimePickerRB_Frd.Value = DateTime.Now;
            dateTimePickerRB_Rdate.Value = DateTime.Now;
            txtRB_DueDays.Text = "";
            txtRB_PPD.Text = "";
            txtRB_Tot.Text = "";
        }

        private void btnRBSearchX_Click(object sender, EventArgs e)
        {
            if (txtRB_Id.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT * FROM Borrow WHERE MemberID=@MID";
                    cmd.Parameters.AddWithValue("@MID", txtRB_Id.Text);

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
                            txtRB_Nic.Text = dr["NIC"].ToString();
                            txtRB_Bid.Text = dr["BookID"].ToString();
                            txtRB_BTitle.Text = dr["BookTitle"].ToString();

                            dateConvert = DateTime.Parse(dr["Bdate"].ToString());
                            dateTimePickerRB_BDate.Value = dateConvert;

                            dateConvert = DateTime.Parse(dr["FRdate"].ToString());
                            dateTimePickerRB_Frd.Value = dateConvert;

                            DateCal(dateConvert);
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

        private void btnRBSearchY_Click(object sender, EventArgs e)
        {
            if (txtRB_Bid.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT * FROM Borrow WHERE BookID=@BID";
                    cmd.Parameters.AddWithValue("@BID", txtRB_Bid.Text);

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
                            txtRB_Id.Text = dr["MemberID"].ToString();
                            txtRB_Nic.Text = dr["NIC"].ToString();
                            txtRB_BTitle.Text = dr["BookTitle"].ToString();

                            dateConvert = DateTime.Parse(dr["Bdate"].ToString());
                            dateTimePickerRB_BDate.Value = dateConvert;

                            dateConvert = DateTime.Parse(dr["FRdate"].ToString());
                            dateTimePickerRB_Frd.Value = dateConvert;

                            DateCal(dateConvert);
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
            else
            {
                MessageBox.Show("Book ID Required!\nPlease Enter a Valid Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int DateCal(DateTime frd)
        {
            Console.WriteLine(frd);
            DateTime returnDate = dateTimePickerRB_Rdate.Value;
            System.TimeSpan totDays = returnDate - frd;

            totDaysInt = totDays.Days;
            txtRB_DueDays.Text = totDaysInt.ToString();
            
            return totDaysInt;
        }

        private void txtRB_PPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FineCal()
        {
            try {
                int totDays = Math.Abs(totDaysInt);
                int ppdInt = Int16.Parse(txtRB_PPD.Text.ToString());
                int totFine = ppdInt * totDays;
                txtRB_Tot.Text = totFine.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRB_PPD_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtRB_PPD.Text != "")
            {
                FineCal();
            }
        }

        private void dateTimePickerRB_Rdate_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void btnRBSave_Click(object sender, EventArgs e)
        {
            if (txtRB_Id.Text == "" || txtRB_Nic.Text == "" || txtRB_Bid.Text == "" || txtRB_BTitle.Text == "")
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

                    cmd.CommandText = "INSERT INTO Returned VALUES (@MID,@NIC,@BID,@Tit,@Bdate,@FRdate,@Rdate,@DD,@PPD,@Tot)";

                    cmd.CommandText = "DELETE FROM Borrow WHERE MemberID=@MID AND BookID=@BID";

                    cmd.Parameters.AddWithValue("@MID", txtRB_Id.Text);
                    cmd.Parameters.AddWithValue("@NIC", txtRB_Nic.Text);
                    cmd.Parameters.AddWithValue("@BID", txtRB_Bid.Text);
                    cmd.Parameters.AddWithValue("@Tit", txtRB_BTitle.Text);
                    cmd.Parameters.AddWithValue("@Bdate", dateTimePickerRB_BDate.Value);
                    cmd.Parameters.AddWithValue("@FRdate", dateTimePickerRB_Frd.Value);
                    cmd.Parameters.AddWithValue("@Rdate", dateTimePickerRB_Rdate.Value);
                    cmd.Parameters.AddWithValue("@DD", txtRB_DueDays.Text);
                    cmd.Parameters.AddWithValue("@PPD", txtRB_PPD.Text);
                    cmd.Parameters.AddWithValue("@Tot", txtRB_Tot.Text);
                    
                    cmd.ExecuteNonQuery();
                    con.Close();

                    RBClear();

                    MessageBox.Show("Borrowed Book Succesfully Returned!\nAll Details Moved from Borrowed Details to Returned Details.", "Book Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRBUpdate_Click(object sender, EventArgs e)
        {
            if (txtRB_Id.Text == "" || txtRB_Nic.Text == "" || txtRB_Bid.Text == "" || txtRB_BTitle.Text == "")
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

                    cmd.CommandText = "UPDATE Borrow SET FRdate=@FRdate WHERE MemberID=@MID AND BookID=@BID";
                    cmd.Parameters.AddWithValue("@MID", txtRB_Id.Text);
                    cmd.Parameters.AddWithValue("@BID", txtRB_Bid.Text);
                    cmd.Parameters.AddWithValue("@FRdate", dateTimePickerRB_Frd.Value);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    RBClear();
                    MessageBox.Show("Final Retern Date Succesfully Extended!", "Retern Date Extended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
