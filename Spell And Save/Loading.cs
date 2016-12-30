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
    public partial class Loading : Form
    {
        static System.Media.SoundPlayer p;

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        public Loading()
        {
            InitializeComponent();
        }

        public Loading(System.Media.SoundPlayer player)
        {
            p = player;
            // p.Play();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();

            progressBar1.Increment(1);

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Home h = new Home(p);
                h.Show();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
