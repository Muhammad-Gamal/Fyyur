using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Psycatric_Clinic
{
    public partial class Checkup_Patient : Form
    {
        SqlConnection con = new SqlConnection(" Data Source = DESKTOP-E599AND ; Initial Catalog = Clinic ; Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader dr;
        public Checkup_Patient()
        {
            InitializeComponent();
        }

        private void Updatepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform mainfrm = new mainform();
            mainfrm.Show();
            checkupPanel.Visible = false;
            groupBox2.Visible = false;

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand(" select UID , Name , Age , Gender , Material_Status , Drugs , Reports , Phone , Address , Emergency_Name , Emergency_Phone , Emergency_Address from Patient_TB  where UID = '" + txtSrch.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                lblPID.Text = dr["UID"].ToString();
                lblPName.Text = dr["Name"].ToString();
                lblPAge.Text = dr["Age"].ToString();
                lblPGender.Text = dr["Gender"].ToString();
                lblPMS.Text = dr["Material_Status"].ToString();
                lblPDrugs.Text = dr["Drugs"].ToString();
                lblPReports.Text = dr["Reports"].ToString();
                lblPPhone.Text = dr["Phone"].ToString();
                lblPAddress.Text = dr["Address"].ToString();
                lblEmgName.Text = dr["Emergency_Name"].ToString();
                lblEmgPhone.Text = dr["Emergency_Phone"].ToString();
                lblEmgAddress.Text = dr["Emergency_Address"].ToString();
                

            }
            catch//(Exception ex)
            {
                MessageBox.Show("Not found ! \n"/*+ ex.Message*/, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
                con.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblPName_Click(object sender, EventArgs e)
        {

        }

        private void lblPAge_Click(object sender, EventArgs e)
        {

        }

        private void lblPReports_Click(object sender, EventArgs e)
        {

        }

        private void lblPDrugs_Click(object sender, EventArgs e)
        {

        }

        private void lblPGender_Click(object sender, EventArgs e)
        {

        }

        private void lblPMS_Click(object sender, EventArgs e)
        {

        }

        private void lblPPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblPAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblEmgName_Click(object sender, EventArgs e)
        {

        }

        private void lblEmgPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblEmgAddress_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPID_Click(object sender, EventArgs e)
        {

        }

        private void Checkup_Patient_Load(object sender, EventArgs e)
        {
            checkupPanel.Visible = true;
            groupBox2.Visible = true;
        }
    }
}
