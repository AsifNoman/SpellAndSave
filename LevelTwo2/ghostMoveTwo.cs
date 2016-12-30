using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelTwo2
{
    public partial class levelTwo : Form
    {
        // first ghost moving timer
        private void firstGhostTimer_Tick(object sender, EventArgs e)
        {
            gameStart++;

            if (gameStart == 12)
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
                firstGhostTimerMethod().Stop();
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

        /********************** Bonus Ghost Timer **********************/

        // bonus ghost moving timer
        private void bonusGhostTimer_Tick(object sender, EventArgs e)
        {
            if (ghost1.IsDisposed)
            {
                bonusGhost.Visible = true;
            }

            // bonus ghost movement functionality
            bonusGhostMove();
        }

        // bonus ghost movement functionality
        public void bonusGhostMove()
        {
            if (bonusGhost.Bounds.IntersectsWith(wall1.Bounds))
            {
                bonusGhost.Top += 3;
            }
            else if (bonusGhost.Bounds.IntersectsWith(wall2.Bounds))
            {
                bonusGhost.Top -= 5;
            }
            else
            {
                bonusGhost.Top -= 3;
            }
        }


        /* ***************** Second Step ghosts ************************ */

        //second step first ghost functionality
        private void secondGhostTimers_Tick(object sender, EventArgs e)
        {
           if(ghost1.IsDisposed)
            {
                secondGhostTimers[0].Interval = 40;
                Secondghostpics[0].Visible = true;
            }

            // second step first ghost movement functionality
            secondFirstGhostMove();
        }

       //second step second ghost functionality
        private void secondGhostTimers1_Tick(object sender, EventArgs e)
        {
            if (ghost1.IsDisposed)
            {
                secondGhostTimers[1].Interval = 40;
                Secondghostpics[1].Visible = true;
            }

            // second step second ghost movement functionality
            secondSecondGhostMove();
        }

        //second step third ghost functionality
        private void secondGhostTimers2_Tick(object sender, EventArgs e)
        {
            if (ghost1.IsDisposed)
            {
                secondGhostTimers[2].Interval = 40;
                Secondghostpics[2].Visible = true;
            }

            // second step third ghost movement functionality
            secondThirdGhostMove();
        } 

        // second step first ghost movement functionality
        private void secondFirstGhostMove()
        {
                if (Secondghostpics[0].Bounds.IntersectsWith(player.Bounds))
                {
                    secondGhostTimers[0].Stop();
                    Secondghostpics[0].Dispose();
                    gameLife--;
                    lifeReduce();
                }
                else
                {
                    Secondghostpics[0].Top += 10;
                    Secondghostpics[0].Left -= 20;
                }
        }

        // second step second ghost movement functionality
        private void secondSecondGhostMove()
        {
                if (Secondghostpics[1].Bounds.IntersectsWith(player.Bounds))
                {
                    secondGhostTimers[1].Stop();
                    Secondghostpics[1].Dispose();
                    gameLife--;
                    lifeReduce();
                }
                else
                {
                    Secondghostpics[1].Top += 2;
                    Secondghostpics[1].Left -= 15;
                }
        }

        // second step third ghost movement functionality
        public void secondThirdGhostMove()
        {
            if (Secondghostpics[2].Bounds.IntersectsWith(player.Bounds))
            {
                secondGhostTimers[2].Stop();
                Secondghostpics[2].Dispose();
                gameLife--;
                lifeReduce();
            }
            else
            {
                Secondghostpics[2].Top -= 3;
                Secondghostpics[2].Left -= 10;
            }
        }


        /* ***************** Third Step ghosts ************************ */

        //third step first ghost functionality
        private void thirdGhostTimers_Tick(object sender, EventArgs e)
        {
            if (ghost1.IsDisposed)
            {
                thirdGhostTimers[0].Interval = 40;
                Thirdghostpics[0].Visible = true;
            }

            // third step first ghost movement functionality
            thirdGhostMove();
        }

        //third step second ghost functionality
        private void thirdGhostTimers1_Tick(object sender, EventArgs e)
        {
            if (ghost1.IsDisposed)
            {
                thirdGhostTimers[1].Interval = 40;
                Thirdghostpics[1].Visible = true;
            }

            // third step second ghost movement functionality
            thirdGhostMove2();
        }

        //third step third ghost functionality
        private void thirdGhostTimers2_Tick(object sender, EventArgs e)
        {
            if (ghost1.IsDisposed)
            {
                thirdGhostTimers[2].Interval = 40;
                Thirdghostpics[2].Visible = true;
            }

            // third step third ghost movement functionality
            thirdGhostMove3();
        }

        // third step first ghost movement functionality
        private void thirdGhostMove()
        {
            if (Thirdghostpics[0].Bounds.IntersectsWith(player.Bounds))
            {
                thirdGhostTimers[0].Stop();
                Thirdghostpics[0].Dispose();
                gameLife--;
                lifeReduce();
            }
            else
            {
                Thirdghostpics[0].Top += 10;
                Thirdghostpics[0].Left += 20;
            }
        }

        // third step second ghost movement functionality
        private void thirdGhostMove2()
        {
            if (Thirdghostpics[1].Bounds.IntersectsWith(player.Bounds))
            {
                thirdGhostTimers[1].Stop();
                Thirdghostpics[1].Dispose();
                gameLife--;
                lifeReduce();
            }
            else
            {
                Thirdghostpics[1].Top -= 1;
                Thirdghostpics[1].Left += 20;
            }
        }

        // third step third ghost movement functionality
        private void thirdGhostMove3()
        {
            if (Thirdghostpics[2].Bounds.IntersectsWith(player.Bounds))
            {
                thirdGhostTimers[2].Stop();
                Thirdghostpics[2].Dispose();
                gameLife--;
                lifeReduce();
            }
            else
            {
                Thirdghostpics[2].Top -= 10;
                Thirdghostpics[2].Left += 20;
            }
        }

        /* ***************** Forth ghost ************************ */

        // forth ghost movement timer
        private void forthGhostTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3;i++)
            {
                if (Secondghostpics[i].IsDisposed && Thirdghostpics[i].IsDisposed)
                {
                    ghost4.Visible = true;
                    forthGhostTimer.Interval = 30;
                }
            }

            // forth ghost movement functionality
            forthGhostMove();
        }

        // forth ghost movement  functionality
        public void forthGhostMove()
        {
            if (ghost4.Bounds.IntersectsWith(player.Bounds))
            {
                forthGhostTimer.Stop();
                ghost4.Dispose();
                gameLife--;
                lifeReduce();
            }
            else
            {
                ghost4.Top -= 5;
                ghost4.Left += 6;
            }
        }

        /* ***************** Fifth ghost ************************ */

        // fifth ghost movement timer
        private void fifthGhostTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Secondghostpics[i].IsDisposed && Thirdghostpics[i].IsDisposed)
                {
                    ghost5.Visible = true;
                    fifthGhostTimer.Interval = 30;
                }
            }

            // fifth ghost movement functionality
            fifthGhostMove();
        }

        // fifth ghost movement  functionality
        public void fifthGhostMove()
        {
            if (ghost5.Bounds.IntersectsWith(player.Bounds))
            {
                fifthGhostTimer.Stop();
                ghost5.Dispose();
                gameLife--;
                lifeReduce();
            }
            else
            {
                ghost5.Top -= 5;
                ghost5.Left -= 10;
            }
        }

        /* ***************** Sixth ghost ************************ */

        // sixth ghost movement timer
        private void sixthGhostTimer_Tick(object sender, EventArgs e)
        {
                if (ghost4.IsDisposed)
                {
                    ghost6.Visible = true;
                    sixthGhostTimer.Interval = 30;
                }

            // sixth ghost movement functionality
            sixthGhostMove();
        }

        // sixth ghost movement  functionality
        public void sixthGhostMove()
        {
            if (ghost6.Bounds.IntersectsWith(player.Bounds))
            {
                sixthGhostTimer.Stop();
                ghost6.Dispose();
                gameLife--;
                lifeReduce();
            }
            else
            {
                ghost6.Top += 5;
                ghost6.Left += 10;
            }
        }

        /* ***************** Seventh ghost ************************ */

        // seventh ghost movement timer
        private void seventhGhostTimer_Tick(object sender, EventArgs e)
        {
            if  (ghost5.IsDisposed)
                {
                    ghost7.Visible = true;
                    seventhGhostTimer.Interval = 30;
                }

            // seventh ghost movement functionality
            seventhGhostMove();
        }

        // seventh ghost movement  functionality
        public void seventhGhostMove()
        {
            if (ghost7.Bounds.IntersectsWith(player.Bounds))
            {
                seventhGhostTimer.Stop();
                ghost7.Dispose();
                gameLife--;
                lifeReduce();
            }
            else
            {
                ghost7.Top += 5;
                ghost7.Left -= 11;
            }
        }
    }
}
