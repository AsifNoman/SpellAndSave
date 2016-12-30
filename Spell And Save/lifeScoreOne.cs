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
        // life reducing functionality
        public void lifeReduce()
        {
            if (gameLife == 3)
            {
                lifepic[3].Image = LevelOne.Properties.Resources.heart2;
            }
            else if (gameLife == 2)
            {
                lifepic[2].Image = LevelOne.Properties.Resources.heart2;
            }
            else if (gameLife == 1)
            {
                lifepic[1].Image = LevelOne.Properties.Resources.heart2;
            }
            else if (gameLife == 0)
            {
                lifepic[0].Image = LevelOne.Properties.Resources.heart2;
                player.Dispose();
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
                ghostTimer.Stop();
            }

            // after second ghosts disposed

            for (int i = 0; i < 3; i++)
            {
                if (Secondghostpics[i].IsDisposed)
                {
                    multipleGhostTimer[i].Stop();
                }
            }

            // after third ghost disposed
            if (ghost3.IsDisposed)
            {
                ghost3Timer.Stop();
            }

            // after forth ghost disposed
            if (ghost4.IsDisposed)
            {
                ghost4Timer.Stop();
            }

            // after boss disposed
            if (bossPicture.IsDisposed)
            {
                bossTimer.Stop();
            }

          }
       }
    }
