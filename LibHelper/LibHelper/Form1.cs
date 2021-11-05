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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ALIENWARE\SQLExpress;Initial Catalog=LibHelperDB;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            sidePanel1.Height = btnBB.Height;
            sidePanel1.Top = btnBB.Top;
            borrowBooks.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel1.Height = btnBB.Height;
            sidePanel1.Top = btnBB.Top;
            borrowBooks.BringToFront();
        }

        private void btnRB_Click(object sender, EventArgs e)
        {
            sidePanel1.Height = btnRB.Height;
            sidePanel1.Top = btnRB.Top;
            returnBooks1.BringToFront();
        }

        private void btnMB_Click(object sender, EventArgs e)
        {
            sidePanel1.Height = btnMB.Height;
            sidePanel1.Top = btnMB.Top;
            manageBooks1.BringToFront();
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            sidePanel1.Height = btnMM.Height;
            sidePanel1.Top = btnMM.Top;
            manageMembers1.BringToFront();
        }

        private void btnVD_Click(object sender, EventArgs e)
        {
            sidePanel1.Height = btnMU.Height;
            sidePanel1.Top = btnMU.Top;
            manageUsers1.BringToFront();
        }

        private void btnMU_Click(object sender, EventArgs e)
        {
            sidePanel1.Height = btnVD.Height;
            sidePanel1.Top = btnVD.Top;
            viewData1.BringToFront();
        }

        private void btnLO_Click(object sender, EventArgs e)
        {
            sidePanel1.Height = btnLO.Height;
            sidePanel1.Top = btnLO.Top;
            this.Hide();
            new Form2().ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}