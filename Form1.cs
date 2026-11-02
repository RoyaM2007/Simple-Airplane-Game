using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace PlaneGame
{
    public partial class Form1 : Form
    {
        private bool isGas = false;
        private bool isLightOn = true;
        private SoundPlayer soundPlayer = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                soundPlayer.SoundLocation = Application.StartupPath + "\\sound.wav";
            }
            catch
            {
            }
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            isGas = true;
            timer1.Start();
            try
            {
                soundPlayer.PlayLooping();
            }
            catch
            {
                SystemSounds.Beep.Play();
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            isGas = false;
            timer1.Stop();
            try
            {
                soundPlayer.Stop();
            }
            catch
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGas && pbPlane.Top > 10)
            {
                pbPlane.Top -= 3;
                pbLight.Top -= 3;
            }
            else
            {
                timer1.Stop();
                isGas = false;
                try
                {
                    soundPlayer.Stop();
                }
                catch
                {
                }
            }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (isLightOn)
            {
                isLightOn = false;
                pbLight.Visible = false;
                btnOnOff.Text = "OFF";
            }
            else
            {
                isLightOn = true;
                pbLight.Visible = true;
                btnOnOff.Text = "ON";
            }
        }

        private void btnEnis_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void btnTurbulans_Click(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
        }

        private void btnKemerler_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
        }

        private void btnTesekkurler_Click(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }
    }
}
