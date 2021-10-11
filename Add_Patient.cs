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
    public partial class Add_Patient : Form
    {
        SqlConnection con = new SqlConnection(" Data Source = DESKTOP-E599AND ; Initial Catalog = Clinic ; Integrated Security = true");

        public Add_Patient()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            addPanel.Visible = false;
            groupBox2.Visible = false;

            mainform mainfrm = new mainform();
            mainfrm.Show();
        }

        private void Add_Patient_Load(object sender, EventArgs e)
        {
            addPanel.Visible = true;
            groupBox2.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(" insert Patient_TB values ('" + txtp_ID.Text + "' , '" + txtPName.Text + "' , '" + txtPAge.Text + "' , '" + cbGender.Text + "' , '" + cbMS.Text + "' , '" + txtPDrugs.Text + "' , '" + txtPReports.Text + "' , '" + txtPPhone.Text + "' , '" + txtPAddress.Text + "' , '" + txtEmgName.Text + "' , '" + txtEmgPhone.Text + "' , '" + txtEmgAddress.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
     
                MessageBox.Show(" Added Successfully ! ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(" Added Failed ! ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
