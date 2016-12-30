using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelThree3
{
    public partial class levelThree : Form
    {
        public void starAndScoreCount()
        {
            try
            {
                // writing score in a file
                System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveCurrentScore.txt", gameScore.ToString());

                // writing star in a file
                System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveCurrentStar.txt", gameLife.ToString());
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
