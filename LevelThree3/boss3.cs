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
        static int count;

        // boss movement controler
        private void bossGhostTimer_Tick(object sender, EventArgs e)
        {
            bossGhostTimer.Interval = 350;

            if(ghost6.IsDisposed && ghost7.IsDisposed)
            {
                bossPicture.Visible = true;
                bossMovement();
            }
        }

        // boss movement
        public void bossMovement()
        {
            // first movement
            if(count==0)
            {
                bossPicture.Top -= 6;
                bossPicture.Left += 7;

                if (bossPicture.Bounds.IntersectsWith(player.Bounds))
                {
                    bossPicture.Top = 471;
                    bossPicture.Left = 850;
                    bossPicture.Image = LevelThree3.Properties.Resources.boss2;
                    gameLife--;
                    lifeReduce();
                    count = 1;
                }
            }

            // second movement
            else if(count==1)
            {
                    bossPicture.Top -= 9;
                    bossPicture.Left -= 13;

                    if (bossPicture.Bounds.IntersectsWith(player.Bounds))
                    {
                        bossPicture.Top = 38;
                        bossPicture.Left = 850;
                        bossPicture.Image = LevelThree3.Properties.Resources.boss2;
                        gameLife--;
                        lifeReduce();
                        count = 2;
                    }
            }

            // third movement
            else if (count == 2)
            {
                bossPicture.Top += 10;
                bossPicture.Left -= 17;

                if (bossPicture.Bounds.IntersectsWith(player.Bounds))
                {
                    bossPicture.Dispose();
                    gameLife--;
                    lifeReduce();
                    bossGhostTimer.Stop();
                    starAndScoreCount();
                }
            } 
        }

        // boss spell string
        private void bossPicture_Paint(object sender, PaintEventArgs e)
        {
            // first spell
            if(count==0)
            {
                using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
                {
                    e.Graphics.DrawString(bossSpell1, myFont, Brushes.Red, new Point(9, -6));
                }
            }

            // second spell
            else if(count==1)
            {
                using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
                {
                    e.Graphics.DrawString(bossSpell2, myFont, Brushes.Red, new Point(8, -6));
                }
            }

            // third spell
            else if (count == 2)
            {
                using (Font myFont = new Font("Arial", 18, FontStyle.Bold))
                {
                    e.Graphics.DrawString(bossSpell3, myFont, Brushes.Red, new Point(8, -6));
                }
            }
        }
    }
}
