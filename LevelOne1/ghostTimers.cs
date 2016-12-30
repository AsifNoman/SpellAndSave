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
        //Timer for first ghost
        Timer firstGhostTimer = new Timer();

        // Timer for second ghosts
        Timer[] secondGhostTimers = new Timer[3];

        // Timer for third ghosts
        Timer[] thirdGhostTimers = new Timer[3];

        //Timer for forth ghost
        Timer forthGhostTimer = new Timer();

        //Timer for fifth ghost
        Timer fifthGhostTimer = new Timer();

        //Timer for sixth ghost
        Timer sixthGhostTimer = new Timer();

        //Timer for seventh ghost
        Timer seventhGhostTimer = new Timer();

        //Timer for boss ghost
        Timer bossGhostTimer = new Timer();

        // functionality for first ghost timer
        private Timer firstGhostTimerMethod()
        {
            firstGhostTimer.Interval += 30;
            firstGhostTimer.Tick += new EventHandler(firstGhostTimer_Tick);
            firstGhostTimer.Start();

            return firstGhostTimer;
        }

        //functionality for second ghosts timer
        private Timer[] secondGhostsTimerMethod()
        {
            for (int i = 0; i < 3; i++)
            {
                secondGhostTimers[i] = new Timer();
                secondGhostTimers[i].Interval = 3000;
                secondGhostTimers[i].Start();
            }

            secondGhostTimers[0].Tick += new EventHandler(secondGhostTimers_Tick);
            secondGhostTimers[1].Tick += new EventHandler(secondGhostTimers1_Tick);
            secondGhostTimers[2].Tick += new EventHandler(secondGhostTimers2_Tick);

            return secondGhostTimers;
        }

        //functionality for third ghosts timer
        private Timer[] thirdGhostsTimerMethod()
        {
            for (int i = 0; i < 3; i++)
            {
                thirdGhostTimers[i] = new Timer();
                thirdGhostTimers[i].Interval = 3000;
                thirdGhostTimers[i].Start();
            }

            thirdGhostTimers[0].Tick += new EventHandler(thirdGhostTimers_Tick);
            thirdGhostTimers[1].Tick += new EventHandler(thirdGhostTimers1_Tick);
            thirdGhostTimers[2].Tick += new EventHandler(thirdGhostTimers2_Tick);

            return thirdGhostTimers;
        }

        // functionality for forth ghost timer
        private Timer forthGhostTimerMethod()
        {
            forthGhostTimer.Interval += 3500;
            forthGhostTimer.Tick += new EventHandler(forthGhostTimer_Tick);
            forthGhostTimer.Start();

            return forthGhostTimer;
        }

        // functionality for fifth ghost timer
        private Timer fifthGhostTimerMethod()
        {
            fifthGhostTimer.Interval += 3500;
            fifthGhostTimer.Tick += new EventHandler(fifthGhostTimer_Tick);
            fifthGhostTimer.Start();

            return fifthGhostTimer;
        }

        // functionality for sixth ghost timer
        private Timer sixthGhostTimerMethod()
        {
            sixthGhostTimer.Interval += 4000;
            sixthGhostTimer.Tick += new EventHandler(sixthGhostTimer_Tick);
            sixthGhostTimer.Start();

            return sixthGhostTimer;
        }

        // functionality for seventh ghost timer
        private Timer seventhGhostTimerMethod()
        {
            seventhGhostTimer.Interval += 4000;
            seventhGhostTimer.Tick += new EventHandler(seventhGhostTimer_Tick);
            seventhGhostTimer.Start();

            return seventhGhostTimer;
        }

        //functionality for boss ghost Timer
        private Timer bossGhostTimerMethod()
        {
            bossGhostTimer.Interval += 5000;
            bossGhostTimer.Tick += new EventHandler(bossGhostTimer_Tick);
            bossGhostTimer.Start();

            return bossGhostTimer;
        }
    }
}
