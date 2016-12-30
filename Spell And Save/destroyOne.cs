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

namespace LevelOne
{
    public partial class levelOne : Form
    {
        int change = 0;

        // first ghost spell string
        private void ghost_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
            {
                e.Graphics.DrawString(spell, myFont, Brushes.Red, new Point(15, -5));
            }
        }

        // second ghosts spell string
        private void secondghost_Paint(object sender, PaintEventArgs e)
        {
               using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
                {
                    e.Graphics.DrawString(Secondspell, myFont, Brushes.Red, new Point(17, -6));
                }
        }

        // third ghost spell string
        private void ghost3_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
            {
                e.Graphics.DrawString(thirdspell, myFont, Brushes.Red, new Point(17, -6));
            }
        }

        // forth ghost spell string
        private void ghost4_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
            {
                e.Graphics.DrawString(forthspell, myFont, Brushes.Red, new Point(-2, -5));
            }
        }

        // action after pressing enter in texbox
        private void spellText_KeyDown(object sender, KeyEventArgs e)
        {
            if (spellText.Text == spell && e.KeyCode == Keys.Enter)
            {  
                ghost1.Dispose();

                scoreUpdate();

                spellText.Clear();

                change = 1;

                // player animation change
                changePlayerAnimation();

            }

           else if (spellText.Text == Secondspell && e.KeyCode == Keys.Enter)
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

           else if (spellText.Text == thirdspell && e.KeyCode == Keys.Enter)
           {
               ghost3.Dispose();

               scoreUpdate();

               spellText.Clear();

               change = 1;

               // player animation change
               changePlayerAnimation();
           }

            else if (spellText.Text == forthspell && e.KeyCode == Keys.Enter)
            {
                ghost4.Dispose();

                scoreUpdate();

                spellText.Clear();

                change = 0;

                // player animation change
                changePlayerAnimation();
            }

            //boss destroy 1
            else if (spellText.Text == fifthspell && e.KeyCode == Keys.Enter)
            {
                bossPicture.Top = 471;
                bossPicture.Left = 850;
                bossPicture.Image = LevelOne.Properties.Resources.boss2;
                scoreUpdate();
                spellText.Clear();
                count = 1;
                bossMovement();

                change = 1;
                // player animation change
                changePlayerAnimation();
            }

             //boss destroy 2
            else if (spellText.Text == Sixthspell && e.KeyCode == Keys.Enter)
            {
                bossPicture.Top = 38;
                bossPicture.Left = 850;
                bossPicture.Image = LevelOne.Properties.Resources.boss2;
                scoreUpdate();
                spellText.Clear();
                count = 2;
                bossMovement();

                change = 0;
                // player animation change
                changePlayerAnimation();
            }

            //boss destroy 2
            else if (spellText.Text == Sixthspell2 && e.KeyCode == Keys.Enter)
            {
                bossPicture.Dispose();
                scoreUpdate();
                spellText.Clear();

                change = 1;
                // player animation change
                changePlayerAnimation();
            }

        }

        // player animation change
        public void changePlayerAnimation()
        {
            if (change == 1)
            {
                player.Image = LevelOne.Properties.Resources.Player1;
            }
            else if(change==0)
            {
                player.Image = LevelOne.Properties.Resources.Player2;
            }
        }

    }
}
