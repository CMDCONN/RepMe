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
    public partial class AdminPanel : UserControl
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        { 
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string selection;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "DRMon")
            {
                selection = "DRMon";
                webBrowser1.Navigate("http://repme.rf.gd/GET/getReviewComment.php?Name=" + selection);
                informationTextBox.Text = selection;
            }
            else if (textBox1.Text == "DRBonk")
            {
                selection = "DRBonk";
                webBrowser1.Navigate("http://repme.rf.gd/GET/getReviewComment.php?Name=" + selection);
                informationTextBox.Text = selection;
            }
            else if (textBox1.Text == "DRKahn")
            {
                selection = "DRKahn";
                webBrowser1.Navigate("http://repme.rf.gd/GET/getReviewComment.php?Name=" + selection);
                informationTextBox.Text = selection;
            }
        }
    }
}
