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
        private SoundPlayer engineSoundPlayer = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            engineSoundPlayer.SoundLocation = Application.StartupPath + "\\sound.wav";
        }

        private void PlayCustomSound(string fileName)
        {
            SoundPlayer sp = new SoundPlayer(Application.StartupPath + "\\" + fileName);
            sp.Play();
        }

        private void btnEnis_Click(object sender, EventArgs e)
        {
            PlayCustomSound("inishazirliklari.wav");
        }

        private void btnTurbulans_Click(object sender, EventArgs e)
        {
            PlayCustomSound("turbulans.wav");
        }

        private void btnKemerler_Click(object sender, EventArgs e)
        {
            PlayCustomSound("kemerler.wav");
        }

        private void btnTesekkurler_Click(object sender, EventArgs e)
        {
            PlayCustomSound("tesekkurler.wav");
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            PlayCustomSound("beep.wav");
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            PlayCustomSound("isikacmakapamasesi.wav");

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

        private void btnGas_Click(object sender, EventArgs e)
        {
            isGas = true;
            timer1.Start();
            engineSoundPlayer.PlayLooping();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            isGas = false;
            timer1.Stop();
            engineSoundPlayer.Stop();
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
                engineSoundPlayer.Stop();
            }
        }
    }
}
