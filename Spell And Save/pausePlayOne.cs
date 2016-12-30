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
        // play and pause  button action event
        private void playpause_Click(object sender, EventArgs e)
        {
            if (playPause == 0)
             {
                 ghostTimer.Stop();
                 playpause.Image = LevelOne.Properties.Resources.play;
                 playPause = 1;
                spellText.Enabled = false;
             }
             else if (playPause == 1)
             {
                 if (ghost1.IsDisposed)
                 {
                     playpause.Image = LevelOne.Properties.Resources.Pause;
                 }
                 else
                 {
                     spellText.Enabled = true;
                     ghostTimer.Start();
                     playpause.Image = LevelOne.Properties.Resources.Pause;
                     playPause = 0;
                 }
             }
        }
    }
}
