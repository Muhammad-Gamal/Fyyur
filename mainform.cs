using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psycatric_Clinic
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want to exit the program ?", "Exit", MessageBoxButtons.YesNo , MessageBoxIcon.Hand);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            mainform back = new mainform();
            back.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainform save = new mainform();
            save.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Patient add = new Add_Patient();
            add.Show();
            this.Hide();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            mainform back = new mainform();
            back.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Checkup_Patient check_up = new Checkup_Patient();
            check_up.Show();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update_Information Update_info = new Update_Information();
            Update_info.Show();
            this.Hide();           
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            mainform save = new mainform();
            save.Show();
 
            this.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            mainform back = new mainform();
            back.ShowDialog();

            this.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
