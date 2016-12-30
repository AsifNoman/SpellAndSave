using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using LevelOne1;

namespace Spell_And_Save
{
    public partial class achivements : Form
    {
        /*************************** Level 1 High Score *****************************/

        // score check
        private void scoreCheck()
        {
            if (currentScore >= storeScore)
            {
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level1\SpellAndSaveStoreScore.txt", currentScore.ToString());

                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }

            else if (currentScore <= storeScore)
            {
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level1\SpellAndSaveStoreScore.txt", storeScore.ToString());
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }

        }

        // Show Score
        private void showScore()
        {
            try
            {
                // score show
                scoreLabel1.Text = System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level1\SpellAndSaveStoreScore.txt");
            }
            catch
            {
                scoreLabel1.Text = "0";
            }
        }


        /*************************** Level 2 High Score *****************************/

        // score check
        private void scoreCheck2()
        {
            if (currentScore2 >= storeScore2)
            {
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level2\SpellAndSaveStoreScore.txt", currentScore2.ToString());

                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }

            else if (currentScore2 <= storeScore2)
            {
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level2\SpellAndSaveStoreScore.txt", storeScore2.ToString());
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }

        }

        // Show Score
        private void showScore2()
        {
            try
            {
                // score show
                scoreLabel2.Text = System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level2\SpellAndSaveStoreScore.txt");
            }
            catch
            {
                scoreLabel2.Text = "0";
            }
        }

        /*************************** Level 3 High Score *****************************/

        // score check
        private void scoreCheck3()
        {
            if (currentScore3 >= storeScore3)
            {
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveStoreScore.txt", currentScore3.ToString());

                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }

            else if (currentScore3 <= storeScore3)
            {
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveStoreScore.txt", storeScore3.ToString());
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }

        }

        // Show Score
        private void showScore3()
        {
            try
            {
                // score show
                scoreLabel3.Text = System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveStoreScore.txt");
            }
            catch
            {
                scoreLabel3.Text = "0";
            }
        }
    }
}
