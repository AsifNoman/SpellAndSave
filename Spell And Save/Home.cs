using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spell_And_Save
{
    public partial class Home : Form
    {
        static int musicPlay = 0;
        static System.Media.SoundPlayer p;

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
        public Home()
        {
            InitializeComponent();
        }

        public Home(System.Media.SoundPlayer player)
        {
            p = player;
            InitializeComponent();
        }


        private void Form0_Load(object sender, EventArgs e)
        {
            p.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Levels l = new Levels();
            this.Hide();
            l.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help o = new Help();
            this.Hide();
            o.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            achivements a = new achivements();
            this.Hide();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Credits c = new Credits();
            this.Hide();
            c.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (musicPlay == 0)
            {
                p.Stop();
                pictureBox1.Image = Spell_And_Save.Properties.Resources.SoundOff;
                musicPlay = 1;
            }
            else if (musicPlay == 1)
            {
                p.Play();
                pictureBox1.Image = Spell_And_Save.Properties.Resources.SoundOn;
                musicPlay = 0;
            }

        }
    }
}
