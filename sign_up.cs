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
    public partial class sign_up : Form
    {
        SqlConnection con = new SqlConnection(" Data Source = DESKTOP-E599AND ; Initial Catalog = Clinic ; Integrated Security = true");

        public sign_up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand(" insert Users_TB values ('" + txtSignupID.Text + "' , '" + txtSignupName.Text + "' , '" + cbUsertype.Text + "' , '" + txtSignupUsername.Text + "' , '" + txtSignupPass.Text + "')", con);
                con.Open();
                com.ExecuteNonQuery();

                MessageBox.Show(" Registered Successfully ! ", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Errors Occurred ! " + ex.Message, "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            Regestration reg = new Regestration();
            reg.Show();
            this.Close();

            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want to exit the program ?", "message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
