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
    public partial class Help : Form
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
        public Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Hide();
            f.Show();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            label1.Text = "To Kill ghosts , type the characters which is" + "\n" + "shown on the head of the ghosts.";
        }
    }
}
