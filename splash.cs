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
    public partial class splash : Form
    {
        private int count = 20;
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                OUTFade.Enabled = false;
                this.Close();
                return;
            }
            this.Opacity -= 0.01;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                timer1.Enabled = false;
                OUTFade.Enabled = true;
                return;
            }
            count -= 1;
        }

        private void INFade_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                INFade.Enabled = false;
                timer1.Enabled = true;
                return;
            }
            this.Opacity += 0.01;
        }
    }
}
