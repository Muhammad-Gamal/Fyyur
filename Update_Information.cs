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
    public partial class Update_Information : Form
    {
        SqlConnection con = new SqlConnection(" Data Source = DESKTOP-E599AND ; Initial Catalog = Clinic ; Integrated Security = true");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlDataReader dr;
        public Update_Information()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform mainfrm = new mainform();
            mainfrm.Show();
            updatePanel.Visible = false;
            groupBox2.Visible = false;
        }

        private void Update_Information_Load(object sender, EventArgs e)
        {
            updatePanel.Visible = true;
            groupBox2.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand(" select Name , Age , Gender , Material_Status , Drugs , Reports , Phone , Address , Emergency_Name , Emergency_Phone , Emergency_Address from Patient_TB  where UID = '" + txtSrch.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                txtPName.Text = dr["Name"].ToString();
                txtPAge.Text = dr["Age"].ToString();
                txtPGender.Text = dr["Gender"].ToString();
                txtPMS.Text = dr["Material_Status"].ToString();
                txtPDrugs.Text = dr["Drugs"].ToString();
                txtPReports.Text = dr["Reports"].ToString();
                txtPPhone.Text = dr["Phone"].ToString();
                txtPAddress.Text = dr["Address"].ToString();
                txtEmgName.Text = dr["Emergency_Name"].ToString();
                txtEmgPhone.Text = dr["Emergency_Phone"].ToString();
                txtEmgAddress.Text = dr["Emergency_Address"].ToString();


            }
            catch//(Exception ex)
            {
                MessageBox.Show("Not found ! \n"/*+ ex.Message*/, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd1 = new SqlCommand(" update Patient_TB set Name = '" + txtPName.Text + "' , Age = '" + txtPAge.Text + "' , Gender = '" + txtPGender.Text + "' , Material_Status = '" + txtPMS.Text + "' , Drugs = '" + txtPDrugs.Text + "' , Reports = '" + txtPReports.Text + "' , Phone = '" + txtPPhone.Text + "' , Address = '" + txtPAddress.Text + "' , Emergency_Name = '" + txtEmgName.Text + "' , Emergency_Phone = '" + txtEmgPhone.Text + "' , Emergency_Address =  '" + txtEmgAddress.Text + "'", con);
                con.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show(" Updated Successfully ! ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd2 = new SqlCommand(" Delete from Patient_TB Where UID = '" + txtSrch.Text + "'", con);
                con.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show(" Deleted Successfully ! ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch //(Exception ex)
            {
                MessageBox.Show(/*ex.Message*/ " Delete Failed ! ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }
    }
}
