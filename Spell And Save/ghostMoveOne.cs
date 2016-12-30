using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelOne
{
    public partial class levelOne : Form
    {
        // first ghost moving timer
        private void ghostTimer_Tick(object sender, EventArgs e)
        {
            gameStart++;

            if (gameStart == 15)
            {
                ghost1.Visible = true;
            }

            // first ghost movement functionality
            firstGhostMove();
        }

        // first ghost movement functionality
        public void firstGhostMove()
        {
            if (ghost1.Bounds.IntersectsWith(player.Bounds))
            {
                ghostTimer.Stop();
                ghost1.Dispose();
                gameLife--;
                lifeReduce();
            }
            else
            {
                ghost1.Top += 3;
                ghost1.Left += 3;
            }
        }

        //second step first ghost functionality
        private void multipleGhostTimer_Tick(object sender, EventArgs e)
        {
           if(ghost1.IsDisposed)
            {
                multipleGhostTimer[0].Interval = 300;
                Secondghostpics[0].Visible = true;
            }

            // second step first ghost movement functionality
            secondFirstGhostMove();
        }

       //second step second ghost functionality
        private void multipleGhostTimer1_Tick(object sender, EventArgs e)
        {
            if (ghost1.IsDisposed)
            {
                multipleGhostTimer[1].Interval = 40;
                Secondghostpics[1].Visible = true;
            }

            // second step second ghost movement functionality
            secondFirstGhostMove2();
        }

        //second step third ghost functionality
        private void multipleGhostTimer2_Tick(object sender, EventArgs e)
        {
            if (ghost1.IsDisposed)
            {
                multipleGhostTimer[2].Interval = 40;
                Secondghostpics[2].Visible = true;
            }

            // second step third ghost movement functionality
            secondFirstGhostMove3();
        } 

        // second step first ghost movement functionality
        private void secondFirstGhostMove()
        {
                if (Secondghostpics[0].Bounds.IntersectsWith(player.Bounds))
                {
                    multipleGhostTimer[0].Stop();
                    Secondghostpics[0].Dispose();
                    gameLife--;
                    lifeReduce();
                }
                else
                {
                    Secondghostpics[0].Top += 3;
                    Secondghostpics[0].Left -= 20;
                }
        }

        // second step second ghost movement functionality
        private void secondFirstGhostMove2()
        {
                if (Secondghostpics[1].Bounds.IntersectsWith(player.Bounds))
                {
                    multipleGhostTimer[1].Stop();
                    Secondghostpics[1].Dispose();
                    gameLife--;
                    lifeReduce();
                }
                else
                {
                    Secondghostpics[1].Top += 3;
                    Secondghostpics[1].Left -= 10;
                }
        }

        // second step third ghost movement functionality
        public void secondFirstGhostMove3()
        {
            if (Secondghostpics[2].Bounds.IntersectsWith(player.Bounds))
            {
                multipleGhostTimer[2].Stop();
                Secondghostpics[2].Dispose();
                gameLife--;
                lifeReduce();
            }
            else
            {
                Secondghostpics[2].Top += 3;
                Secondghostpics[2].Left -= 10;
            }
        }

        // third ghost movement timer
        private void ghost3Timer_Tick(object sender, EventArgs e)
        {
            if (ghost1.IsDisposed)
            {
                ghost3.Visible = true;
                ghost3Timer.Interval = 30;
            }

            // third ghost movement functionality
            thirdGhostMove();
        }

        // forth ghost movement timer
        private void ghost4Timer_Tick(object sender, EventArgs e)
        {
            if (ghost3.IsDisposed)
            {
                ghost4.Visible = true;
                ghost4Timer.Interval = 350;
            }

            // forth ghost movement functionality
            forthGhostMove();
        } 

        // third ghost movement  functionality
        public void thirdGhostMove()
        {
            if (ghost3.Bounds.IntersectsWith(player.Bounds))
            {
                ghost3Timer.Stop();
                ghost3.Dispose();
                gameLife--;
                lifeReduce();
            }
            else
            {
                ghost3.Top -= 3;
                ghost3.Left += 4;
            }
        }

        // forth ghost movement  functionality
        public void forthGhostMove()
        {
            if (ghost4.Bounds.IntersectsWith(player.Bounds))
            {
                ghost4Timer.Stop();
                ghost4.Dispose();
                gameLife--;
                lifeReduce();
            }
            else
            {
                ghost4.Top -= 3;
                ghost4.Left -= 10;
            }
        }
    }
}
