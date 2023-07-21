using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepMeFixed.Window
{
    public partial class reVIEW : UserControl
    {
        public reVIEW()
        {
            InitializeComponent();
        }

        private void reVIEW_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RepMeFixed.Properties.Settings.Default.username == "admin")
            {
                nameLabel.Text = "admin";
                label2.Text = "You're admin, you don't have anything to display";

            }
            else if (RepMeFixed.Properties.Settings.Default.username == "DRBonk")
            {
                nameLabel.Text = "DRBonk";
                webBrowser1.Navigate("http://repme.rf.gd/GET/getReviewComment.php?Name=DRBonk");
                pictureBox1.Image = Properties.Resources.doctor2;
            }
            else if (RepMeFixed.Properties.Settings.Default.username == "DRKahn")
            {
                nameLabel.Text = "DRKahn";
                webBrowser1.Navigate("http://repme.rf.gd/GET/getReviewComment.php?Name=DRKahn");
                pictureBox1.Image = Properties.Resources.download;
            }
            else if (RepMeFixed.Properties.Settings.Default.username == "DRMon")
            {
                nameLabel.Text = "DRMon";
                webBrowser1.Navigate("http://repme.rf.gd/GET/getReviewComment.php?Name=DRMon");
                pictureBox1.Image = Properties.Resources.doctor1;
            }
        }
    }
}
