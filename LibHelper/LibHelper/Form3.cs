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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ALIENWARE\SQLExpress;Initial Catalog=LibHelperDB;Integrated Security=True");
        
        public Form3()
        {
            InitializeComponent();
            comboBoxReGen.SelectedIndex = 0;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LoadBookReport();
        }

        private void LoadBookReport()
        {
            try
            {
                con.Open();
                DataSet1 ds = new DataSet1();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM Book";

                cmd.ExecuteNonQuery();
                con.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds.Book);

                CrystalReportBook bookReport = new CrystalReportBook();
                bookReport.SetDataSource(ds);
                crystalReportViewer.ReportSource = bookReport;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMemberReport()
        {
            try
            {
                con.Open();
                DataSet1 ds = new DataSet1();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM Member";

                cmd.ExecuteNonQuery();
                con.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds.Members);

                CrystalReportMember MemberReport = new CrystalReportMember();
                MemberReport.SetDataSource(ds);
                crystalReportViewer.ReportSource = MemberReport;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxReGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            String txt = comboBoxReGen.Text;

            if (txt == "Book Details")
            {
                LoadBookReport();
            }
            else if (txt == "Member Details")
            {
                LoadMemberReport();
            }
        }
    }
}
