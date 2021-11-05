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
    public partial class manageMembers : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ALIENWARE\SQLExpress;Initial Catalog=LibHelperDB;Integrated Security=True");
        DateTime dateConvert;

        public manageMembers()
        {
            InitializeComponent();
            AutoGenID();
        }

        private void btnMMClear_Click(object sender, EventArgs e)
        {
            MMClear();
            AutoGenID();
        }

        private void AutoGenID()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(MemberID AS INT)),0)+1 FROM Member",con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtMM_Id.Text = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Member ID Aut0 Genaration Failed!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MMClear()
        {
            txtMM_Id.Text = "";
            txtMM_Nic.Text = "";
            txtMM_FName.Text = "";
            txtMM_LName.Text = "";
            dateTimePickerMM_DoB.Value = DateTime.Now;
            radioBtnMale.Checked = false;
            radioBtnFemale.Checked = false;
            txtMM_ConNo.Text = "";
            txtMM_Email.Text = "";
            txtMM_Add.Text = "";
        }

        private void btnMMSave_Click(object sender, EventArgs e)
        {
            if (txtMM_Id.Text == "" || txtMM_Nic.Text == "" || txtMM_FName.Text == "" || txtMM_LName.Text == "" || dateTimePickerMM_DoB.Value == DateTime.Now)
            {
                MessageBox.Show("Empty Fields Found!\nPlease Fill All Required Fields That Marked *.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioBtnMale.Checked == false && radioBtnFemale.Checked == false)
            {
                MessageBox.Show("Gender Not Selected!\nPlease Select Your Gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "INSERT INTO Member VALUES (@ID,@NIC,@FName,@LName,@DOB,@Sex,@Con,@Email,@Adrs)";
                    cmd.Parameters.AddWithValue("@ID", txtMM_Id.Text);
                    cmd.Parameters.AddWithValue("@NIC", txtMM_Nic.Text);
                    cmd.Parameters.AddWithValue("@FName", txtMM_FName.Text);
                    cmd.Parameters.AddWithValue("@LName", txtMM_LName.Text);
                    cmd.Parameters.AddWithValue("@DOB", dateTimePickerMM_DoB.Value);
                    cmd.Parameters.AddWithValue("@Con", txtMM_ConNo.Text);
                    cmd.Parameters.AddWithValue("@Email", txtMM_Email.Text);
                    cmd.Parameters.AddWithValue("@Adrs", txtMM_Add.Text);

                    if (radioBtnMale.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Sex", radioBtnMale.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Sex", radioBtnFemale.Text);
                    }
                    
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MMClear();
                    AutoGenID();

                    MessageBox.Show("New Member Succesfully Added!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtMM_ConNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar)){
                e.Handled = true;
            }
        }

        private void txtMM_FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMM_LName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnMMSearchX_Click(object sender, EventArgs e)
        {
            if (txtMM_Id.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT * FROM Member WHERE MemberID=@MID";
                    cmd.Parameters.AddWithValue("@MID", txtMM_Id.Text);

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
                            txtMM_Nic.Text = dr["NIC"].ToString();
                            txtMM_FName.Text = dr["FName"].ToString();
                            txtMM_LName.Text = dr["LName"].ToString();
                            txtMM_ConNo.Text = dr["ContactNo"].ToString();
                            txtMM_Email.Text = dr["Email"].ToString();
                            txtMM_Add.Text = dr["Adrs"].ToString();
                            
                            dateConvert = DateTime.Parse(dr["DOB"].ToString());
                            dateTimePickerMM_DoB.Value = dateConvert;
                            
                            if (dr["Sex"].ToString() != "Female") 
                                radioBtnMale.Checked = true;
                            else if (dr["Sex"].ToString() == "Female")
                                radioBtnFemale.Checked = true;
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

        private void btnMMUpdate_Click(object sender, EventArgs e)
        {
            if (txtMM_Id.Text == "" || txtMM_Nic.Text == "" || txtMM_FName.Text == "" || txtMM_LName.Text == "" || dateTimePickerMM_DoB.Value == DateTime.Now)
            {
                MessageBox.Show("Empty Fields Found!\nPlease Fill All Required Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioBtnMale.Checked == false && radioBtnFemale.Checked == false)
            {
                MessageBox.Show("Gender Not Selected!\nPlease Select Your Gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    
                    cmd.CommandText = "UPDATE Member SET NIC=@NIC,FName=@FName,LName=@LName,DOB=@DOB,Sex=@Sex,ContactNo=@Con,Email=@Email,Adrs=@Adrs WHERE MemberID=@MID";
                    cmd.Parameters.AddWithValue("@MID", txtMM_Id.Text);
                    cmd.Parameters.AddWithValue("@NIC", txtMM_Nic.Text);
                    cmd.Parameters.AddWithValue("@FName", txtMM_FName.Text);
                    cmd.Parameters.AddWithValue("@LName", txtMM_LName.Text);
                    cmd.Parameters.AddWithValue("@DOB", dateTimePickerMM_DoB.Value);
                    cmd.Parameters.AddWithValue("@Con", txtMM_ConNo.Text);
                    cmd.Parameters.AddWithValue("@Email", txtMM_Email.Text);
                    cmd.Parameters.AddWithValue("@Adrs", txtMM_Add.Text);

                    if (radioBtnMale.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Sex", radioBtnMale.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Sex", radioBtnFemale.Text);
                    }

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MMClear();
                    AutoGenID();

                    MessageBox.Show("Member Detail Succesfully Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMMDelete_Click(object sender, EventArgs e)
        {
            if (txtMM_Id.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "DELETE FROM Member WHERE MemberID=@MID";
                    cmd.Parameters.AddWithValue("@MID", txtMM_Id.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MMClear();
                    AutoGenID();
                    MessageBox.Show("Member Details Succesfully Removed!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
