using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Psycatric_Clinic
{
    public partial class Regestration : Form
    {
        SqlConnection con = new SqlConnection(" Data Source = DESKTOP-E599AND ; Initial Catalog = Clinic ; Integrated Security = true");
        
        public Regestration()
        {
            Thread t = new Thread(new ThreadStart(startform));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void startform()
        {
            Application.Run(new splash());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want to exit the program ?", "message", MessageBoxButtons.YesNo , MessageBoxIcon.Hand);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void Regestration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sign_up sign = new sign_up();
            sign.ShowDialog();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dr = new SqlDataAdapter(" select * from Users_TB where Username = '" + txtLoginName.Text + "' and Password = '" + txtLoginPass.Text + "' and Role = '" + cbLoginUsertype.Text + "'", con);
                con.Open();
                DataTable dt = new DataTable();
                dr.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successfully ! ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // this.Hide();
                   // mainform main = new mainform();
                   // main.Show();
                }

                else
                {
                    MessageBox.Show(" Incorrect username or password , Please Try Again ! ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (cbLoginUsertype.Text == "Secretary")
                {
                    this.Hide();
                    mainsecretary mainsec = new mainsecretary();
                    mainsec.Show();
                    
                }
                else
                {
                    this.Hide();
                    mainform main = new mainform();
                    main.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }



        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show(" The connection is : " + con.State.ToString());
            con.Close();
        }
    }
}
