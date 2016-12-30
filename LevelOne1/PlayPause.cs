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
        static int playPause;
        List<Timer> timerlist = new List<Timer>();

        // Timer initialize in arraylist
        private void timerInitialize()
        {
            timerlist.Add(firstGhostTimer);

            for (int i = 0; i < 3; i++)
            {
                timerlist.Add(secondGhostTimers[i]);
                timerlist.Add(thirdGhostTimers[i]);
            }

            timerlist.Add(forthGhostTimer);
            timerlist.Add(fifthGhostTimer);
            timerlist.Add(sixthGhostTimer);
            timerlist.Add(seventhGhostTimer);
            timerlist.Add(bossGhostTimer);
        }

        // timer check for ghosts dispose
        private void checkTimer()
        {
            timerInitialize();

            if(ghost1.IsDisposed)
            {
                timerlist.Remove(firstGhostTimer);
            }

            if(Secondghostpics[0].IsDisposed)
            {
                timerlist.Remove(secondGhostTimers[0]);
            }

            if (Secondghostpics[1].IsDisposed)
            {
                timerlist.Remove(secondGhostTimers[1]);
            }

            if (Secondghostpics[2].IsDisposed)
            {
                timerlist.Remove(secondGhostTimers[2]);
            }

            if(Thirdghostpics[0].IsDisposed)
            {
                timerlist.Remove(thirdGhostTimers[0]);
            }

            if (Thirdghostpics[1].IsDisposed)
            {
                timerlist.Remove(thirdGhostTimers[1]);
            }

            if (Thirdghostpics[2].IsDisposed)
            {
                timerlist.Remove(thirdGhostTimers[2]);
            }

            if(ghost4.IsDisposed)
            {
                timerlist.Remove(forthGhostTimer);
            }

            if(ghost5.IsDisposed)
            {
                timerlist.Remove(fifthGhostTimer);
            }

            if(ghost6.IsDisposed)
            {
                timerlist.Remove(sixthGhostTimer);
            }

            if(ghost7.IsDisposed)
            {
                timerlist.Remove(seventhGhostTimer);
            }

            if(bossPicture.IsDisposed)
            {
                timerlist.Remove(bossGhostTimer);
            }
        }

        // play pause button
        private void playpause_Click(object sender, EventArgs e)
        {
            checkTimer();

            if (playPause == 0)
            {
                playpause.Image = LevelOne1.Properties.Resources.play;

                foreach (var timer in timerlist)
                {
                    timer.Stop();
                }

                spellText.Enabled = false;
                playPause = 1;
            }

            else if (playPause == 1)
            {
                playpause.Image = LevelOne1.Properties.Resources.Pause;

                foreach (var timer in timerlist)
                {
                    timer.Start();
                }

               firstGhostTimer.Start();
               spellText.Enabled = true;
               playPause = 0;
            }
        }
    }
}
