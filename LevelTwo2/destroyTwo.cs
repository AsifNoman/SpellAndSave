using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LevelTwo2
{
    public partial class levelTwo : Form
    {
        int change = 0;

        // first ghost spell string
        private void ghost1_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
            {
                e.Graphics.DrawString(spell, myFont, Brushes.Red, new Point(15, -5));
            }
        }

        // bonus ghost spell string
        private void bonusGhost_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 10, FontStyle.Bold))
            {
                e.Graphics.DrawString("how many oop principles?", myFont, Brushes.Red, new Point(11, -2));
            }
        }

        // second ghosts spell string
        private void secondghost_Paint(object sender, PaintEventArgs e)
        {
               using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
                {
                    e.Graphics.DrawString(secondSpell, myFont, Brushes.Red, new Point(17, -6));
                }
        }

        // third ghosts spell string
        private void Thirdghost_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
            {
                e.Graphics.DrawString(thirdSpell, myFont, Brushes.Red, new Point(17, -6));
            }
        }

        // forth ghost spell string
        private void ghost4_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
            {
                e.Graphics.DrawString(forthSpell, myFont, Brushes.Red, new Point(-2, -5));
            }
        }

        // fifth ghost spell string
        private void ghost5_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
            {
                e.Graphics.DrawString(fifthSpell, myFont, Brushes.Red, new Point(-2, -5));
            }
        }

        // sixth ghost spell string
        private void ghost6_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
            {
                e.Graphics.DrawString(sixthSpell, myFont, Brushes.Red, new Point(-2, -5));
            }
        }

        // seventh ghost spell string
        private void ghost7_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
            {
                e.Graphics.DrawString(seventhSpell, myFont, Brushes.Red, new Point(-2, -5));
            }
        }

        // action after pressing enter in texbox
        private void spellText_TextChanged(object sender, EventArgs e)
        {
            // destruction text for first ghost
            if (spellText.Text == spell )
            {  
                ghost1.Dispose();

                scoreUpdate();

                spellText.Clear();

                change = 1;

                // player animation change
                changePlayerAnimation();

            }

            // destruction text for bonus ghost
            if (spellText.Text == "4")
            {
                bonusGhost.Dispose();

                scoreUpdate();

                spellText.Clear();

                change = 1;

                // player animation change
                changePlayerAnimation();

            }

           // destruction text for second ghost
           else if (spellText.Text == secondSpell)
           {
               for (int i = 0; i < 3; i++)
               {
                    Secondghostpics[i].Dispose();

                    scoreUpdate();
               }

               spellText.Clear();

               change = 0;

               // player animation change
               changePlayerAnimation();
           }

           // destruction text for third ghost
           else if (spellText.Text == thirdSpell)
           {
               for (int i = 0; i < 3; i++)
               {
                   Thirdghostpics[i].Dispose();

                   scoreUpdate();
               }

               spellText.Clear();

               change = 1;

               // player animation change
               changePlayerAnimation();
           }

            // destruction text for fourth ghost
            else if (spellText.Text == forthSpell)
            {
                ghost4.Dispose();

                scoreUpdate();

                spellText.Clear();

                change = 0;

                // player animation change
                changePlayerAnimation();
            }

            // destruction text for fifth ghost
            else if (spellText.Text == fifthSpell)
            {
                ghost5.Dispose();

                scoreUpdate();

                spellText.Clear();

                change = 1;

                // player animation change
                changePlayerAnimation();
            }

            // destruction text for sixth ghost
            else if (spellText.Text == sixthSpell)
            {
                ghost6.Dispose();

                scoreUpdate();

                spellText.Clear();

                change = 0;

                // player animation change
                changePlayerAnimation();
            }

            // destruction text for seveth ghost
            else if (spellText.Text == seventhSpell)
            {
                ghost7.Dispose();

                scoreUpdate();

                spellText.Clear();

                change = 1;

                // player animation change
                changePlayerAnimation();
            }

            // boss destroy 1
            else if (spellText.Text == bossSpell1)
            {
                bossPicture.Top = 471;
                bossPicture.Left = 850;
                bossPicture.Image = LevelTwo2.Properties.Resources.boss2;
                scoreUpdate();
                spellText.Clear();
                count = 1;
                bossMovement();

                change = 0;
                // player animation change
                changePlayerAnimation();
            }

             //boss destroy 2
            else if (spellText.Text == bossSpell2)
            {
                bossPicture.Top = 38;
                bossPicture.Left = 850;
                bossPicture.Image = LevelTwo2.Properties.Resources.boss2;
                scoreUpdate();
                spellText.Clear();
                count = 2;
                bossMovement();

                change = 1;
                // player animation change
                changePlayerAnimation();
            }

            //boss destroy 3
            else if (spellText.Text == bossSpell3)
            {
                bossPicture.Dispose();
                scoreUpdate();
                spellText.Clear();
                starAndScoreCount();

                change = 0;
                // player animation change
                changePlayerAnimation();
            }

        }

        // player animation change
        public void changePlayerAnimation()
        {
            if (change == 1)
            {
                player.Image = LevelTwo2.Properties.Resources.Player1;
            }
            else if(change==0)
            {
                player.Image = LevelTwo2.Properties.Resources.Player2;
            }
        }

    }
}
