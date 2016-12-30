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
    public partial class Credits : Form
    {
        static int credits;

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        public Credits()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Home f = new Home();
            this.Hide();
            f.Show();
            credits = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            credits++;
            if (credits == 1)
            {
                label1.Text = "-- Project Developed By --";
            }
            else if (credits == 2)
            {
                label2.Text = "Raihan, Faisal";
            }
            else if (credits == 3)
            {
                label3.Text = "Noman, Asif Al";
            }
            else if (credits == 4)
            {
                label4.Text = "Ruman, Md. Saifuddin";
            }
            else if (credits > 4)
            {
                timer1.Stop();
                credits = 0;
            }
        }

        private void Credits_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            timer1.Start();
        }
    }
}
