using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepMeFixed
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void WindowSelector_Tick(object sender, EventArgs e)
        {
            if (RepMeFixed.Properties.Settings.Default.Public_Tick >= 4000)
            {
                switch (RepMeFixed.Properties.Settings.Default.Window)
                {
                    case 1:
                        bunifuTransition1.HideSync(login1);
                        bunifuTransition1.ShowSync(dashboard1);
                        break;
                    case 2:
                        bunifuTransition1.HideSync(login1);
                        bunifuTransition1.ShowSync(dashboard1);
                        break;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }   
    }
}
