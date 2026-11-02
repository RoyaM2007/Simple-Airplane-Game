using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace PlaneGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer sp = new SoundPlayer("sound.wav");
        bool Gas = false;
        bool light = true;

        private void btnGas_Click(object sender, EventArgs e)
        {
            sp.Play();
            Gas = true;
            timer1.Start();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            sp.Stop();
            Gas = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Gas == true && pbPlane.Location.Y > 0)
            {
                pbPlane.Location = new Point(pbPlane.Location.X, pbPlane.Location.Y - 2);
                pbLight.Location = new Point(pbLight.Location.X, pbLight.Location.Y - 2);
            }
            else
            {
                timer1.Stop();
                sp.Stop();
                MessageBox.Show("Way end");
            }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (light == false)
            {
                light = true;
                btnOnOff.Text = "ON";
                pbLight.Visible = true;
            }
            else
            {
                light = false;
                btnOnOff.Text = "OFF";
                pbLight.Visible = false;
            }
        }

        private void btnEnis_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void btnTurbulans_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void btnKemerler_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void btnTesekkurler_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }
    }
}
