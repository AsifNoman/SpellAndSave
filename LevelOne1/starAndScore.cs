using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelOne1
{
    public partial class levelOne : Form
    {
        public void starAndScoreCount()
        {
            try
            {
                // writing score in a file
                System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level1\SpellAndSaveCurrentScore.txt", gameScore.ToString());

                // writing star in a file
                System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level1\SpellAndSaveCurrentStar.txt", gameLife.ToString());
            }
            catch
            {
                MessageBox.Show("Error!!!");
            }

            // score and star show
            popUp.Show();
            this.Hide();
        }
    }
}
