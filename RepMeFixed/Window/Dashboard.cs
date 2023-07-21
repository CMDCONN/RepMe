using RepMeFixed.Properties;
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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void selection()
        {
            panel5.Visible = true;
            switch (RepMeFixed.Properties.Settings.Default.doctor_id)
            {
                case 1:
                    {
                        RepMeFixed.Properties.Settings.Default.doctor_name = "DRMon";
                        RepMeFixed.Properties.Settings.Default.doctor_age = 60;
                        label8.Text = RepMeFixed.Properties.Settings.Default.doctor_name;
                    }
                    break;

                case 2:
                    {
                        RepMeFixed.Properties.Settings.Default.doctor_name = "DRKahn";
                        RepMeFixed.Properties.Settings.Default.doctor_age = 70;
                        label8.Text = RepMeFixed.Properties.Settings.Default.doctor_name;

                    }
                    break;

                case 3:
                    {
                        RepMeFixed.Properties.Settings.Default.doctor_name = "DRBonk";
                        RepMeFixed.Properties.Settings.Default.doctor_age = 30;
                        label8.Text = RepMeFixed.Properties.Settings.Default.doctor_name;
                    }
                    break;
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://repme.rf.gd/group.php?username=" + RepMeFixed.Properties.Settings.Default.username);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            RepMeFixed.Properties.Settings.Default.doctor_id = 3;
            selection();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            RepMeFixed.Properties.Settings.Default.doctor_id = 2;
            selection();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            RepMeFixed.Properties.Settings.Default.doctor_id = 1;
            selection();
        }

        private void dopeSwitch()
        {
            switch(RepMeFixed.Properties.Settings.Default.doctor_ratings)
            {
                case 1:
                    label1.ForeColor = Color.Green;
                    label10.ForeColor = Color.Black;
                    label13.ForeColor = Color.Black;
                    label12.ForeColor = Color.Black;
                    label11.ForeColor = Color.Black;
                    break;
                case 2:
                    label1.ForeColor = Color.Green;
                    label10.ForeColor = Color.Green;
                    label13.ForeColor = Color.Black;
                    label12.ForeColor = Color.Black;
                    label11.ForeColor = Color.Black;
                    break;
                case 3:
                    label1.ForeColor = Color.Green;
                    label10.ForeColor = Color.Green;
                    label13.ForeColor = Color.Black;
                    label12.ForeColor = Color.Black;
                    label11.ForeColor = Color.Green;
                    break;
                case 4:
                    label1.ForeColor = Color.Green;
                    label10.ForeColor = Color.Green;
                    label12.ForeColor = Color.Green;
                    label11.ForeColor = Color.Green;
                    label13.ForeColor = Color.Black;
                    break;
                case 5:
                    label1.ForeColor = Color.Green;
                    label10.ForeColor = Color.Green;
                    label13.ForeColor = Color.Green;
                    label12.ForeColor = Color.Green;
                    label11.ForeColor = Color.Green;
                    break;
            }
        }
 
        private void label1_Click(object sender, EventArgs e)
        {
            RepMeFixed.Properties.Settings.Default.doctor_ratings = 1;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            RepMeFixed.Properties.Settings.Default.doctor_ratings = 2;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            RepMeFixed.Properties.Settings.Default.doctor_ratings = 3;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            RepMeFixed.Properties.Settings.Default.doctor_ratings = 4;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            RepMeFixed.Properties.Settings.Default.doctor_ratings = 5;
        }

        private void ratings_Tick(object sender, EventArgs e)
        {
            dopeSwitch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://repme.rf.gd/SET/setReviewRate.php?name=" + RepMeFixed.Properties.Settings.Default.doctor_name  + "&review_rate=" + RepMeFixed.Properties.Settings.Default.doctor_ratings);
            webBrowser1.Navigate("http://repme.rf.gd/SET/setReviewComment.php?name=" + RepMeFixed.Properties.Settings.Default.doctor_name + "&comments=" + richTextBox1.Text + "\n" + richTextBox2.Text + "\n" + richTextBox3.Text + "\n" + richTextBox4.Text + "\n" + richTextBox5.Text + "\n" + richTextBox6.Text);
        }

            private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        


        private void button4_Click(object sender, EventArgs e)
        {
            adminPanel1.Visible = true;

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser2.DocumentText.Contains("1"))
            {
                adminButton.Visible = false;

            }
            else if (webBrowser2.DocumentText.Contains("2"))
            {
                adminButton.Visible = false;

            }
            else if (webBrowser2.DocumentText.Contains("3"))
            {
                adminButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Your account is unregistered your actions are limited!");
            }
        }

        private void adminPanel1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reVIEW1.Visible= true;
        }
    }
}
