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
        popUpBox3 popUp = new popUpBox3();

        // life reducing functionality
        public void lifeReduce()
        {
            if (gameLife == 2)
            {
                lifepic[2].Image = LevelThree3.Properties.Resources.heart2;
            }
            else if (gameLife == 1)
            {
                lifepic[1].Image = LevelThree3.Properties.Resources.heart2;
            }
            else if (gameLife == 0)
            {
                lifepic[0].Image = LevelThree3.Properties.Resources.heart2;
                player.Dispose();
                starAndScoreCount();
            }
        }

        // score updating functionality
        public void scoreUpdate()
        {
            gameScore += 15;

            scorelabel.Text = "Score: " + gameScore;

            afterGhostDispose();
        }

        // functionality after ghosts disposed
        public void afterGhostDispose()
        {
            // after first ghost disposed
            if (ghost1.IsDisposed)
            {
                firstGhostTimer.Stop();
            }

            // after second ghosts disposed

            for (int i = 0; i < 3; i++)
            {
                if (Secondghostpics[i].IsDisposed)
                {
                    secondGhostTimers[i].Stop();
                }
            }

            // after third ghosts disposed

            for (int i = 0; i < 3; i++)
            {
                if (Thirdghostpics[i].IsDisposed)
                {
                    thirdGhostTimers[i].Stop();
                }
            }

            // after forth ghost disposed
            if (ghost4.IsDisposed)
            {
                forthGhostTimer.Stop();
            }

            // after fifth ghost disposed
            if (ghost5.IsDisposed)
            {
                fifthGhostTimer.Stop();
            }

            // after sixth ghost disposed
            if (ghost6.IsDisposed)
            {
                sixthGhostTimer.Stop();
            }

            // after seventh ghost disposed
            if (ghost7.IsDisposed)
            {
                seventhGhostTimer.Stop();
            }

            // after boss disposed
            if (bossPicture.IsDisposed)
            {
                bossGhostTimer.Stop();
            }

          }
       }
    }
