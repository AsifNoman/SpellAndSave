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
        static int gameLife = 3;
        static int gameScore, gameStart;

        // spell for destroying first ghost
        string spell = spellString.getOneRandomChar();

        // spell for second ghosts  destruction
        string secondSpell = spellString.getdoubleRandomChar();

        // spell for third ghost's  destruction
        string thirdSpell = spellString.getdoubleRandomChar2();

        // spell for forth ghost's  destruction
        string forthSpell = spellString.getThreeRandomChar();

        // spell for fifth ghost's  destruction
        string fifthSpell = spellString.getthreeRandomChar2();

        // spell for sixth ghost's  destruction
        string sixthSpell = spellString.getthreeRandomChar3();

        // spell for seventh ghost's  destruction
        string seventhSpell = spellString.getthreeRandomChar4();

        // spell for boss's  destruction
        string bossSpell1 = spellString.getFiveRandomChar();

        // spell for boss's  destruction
        string bossSpell2 = spellString.getSixRandomChar();

        // spell for boss's  destruction
        string bossSpell3 = spellString.getSixRandomChar2();

        // life count picturebox
        PictureBox[] lifepic = new PictureBox[3];

        // second ghosts pictureboxs
        PictureBox[] Secondghostpics = new PictureBox[3];

        // third ghosts pictureboxs
        PictureBox[] Thirdghostpics = new PictureBox[3];

        public levelOne()
        {
            InitializeComponent();

            // first ghost timer initialize
            firstGhostTimerMethod();

            // second ghosts timers initialize
            secondGhostsTimerMethod();

            // third ghosts timers initialize
            thirdGhostsTimerMethod();

            // forth ghosts timer initialize
            forthGhostTimerMethod();

            // fifth ghosts timer initialize
            fifthGhostTimerMethod();

            // sixth ghosts timer initialize
            sixthGhostTimerMethod();

            // seventh ghosts timer initialize
            seventhGhostTimerMethod();

            //boss ghots timer initialize
            bossGhostTimerMethod();

            // disable maximize button
            this.MaximizeBox = false;
        }

        private void levelOne_Load(object sender, EventArgs e)
        {
            // score label
            scorelabel.Text = "Score: " + gameScore;

            // life count pics
            for (int i = 0, top = 92; i < 3; i++, top = top + 55)
            {
                lifepic[i] = new PictureBox();
                lifepic[i].BackColor = Color.Transparent;
                lifepic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                lifepic[i].ClientSize = new Size(52, 31);
                lifepic[i].Location = new Point(top, 15);
                lifepic[i].Image = LevelOne1.Properties.Resources.heart;
                this.Controls.Add(lifepic[i]);
            }

            //ghostPictureboxes initializing functionality
            ghostPictureboxes();
        }

        // initialize ghostPictureboxes
        private void ghostPictureboxes()
        {
            //first ghost
            ghost1.Visible = false;

            // Second ghosts
            for (int i = 0, top = 750, left = 60; i < 3; i++, top += 60, left += 150)
            {
                Secondghostpics[i] = new PictureBox();
                Secondghostpics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Secondghostpics[i].ClientSize = new Size(75, 89);
                Secondghostpics[i].Location = new Point(top, left);
                Secondghostpics[i].Image = LevelOne1.Properties.Resources.g2;
                Secondghostpics[i].BackColor = Color.Transparent;
                this.Controls.Add(Secondghostpics[i]);
                Secondghostpics[i].BackColor = Color.Transparent;
                Secondghostpics[i].Paint += new PaintEventHandler(secondghost_Paint);
                Secondghostpics[i].Visible = false;
            }

            // third ghosts
            for (int i = 0, top = 50, left = 90; i < 3; i++, top += 60, left += 150)
            {
                Thirdghostpics[i] = new PictureBox();
                Thirdghostpics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Thirdghostpics[i].ClientSize = new Size(75, 89);
                Thirdghostpics[i].Location = new Point(top, left);
                Thirdghostpics[i].Image = LevelOne1.Properties.Resources.ghost1;
                Thirdghostpics[i].BackColor = Color.Transparent;
                this.Controls.Add(Thirdghostpics[i]);
                Thirdghostpics[i].BackColor = Color.Transparent;
                Thirdghostpics[i].Paint += new PaintEventHandler(Thirdghost_Paint);
                Thirdghostpics[i].Visible = false;
            }

            //forth ghost
            ghost4.Visible = false;

            //fifth ghost
            ghost5.Visible = false;

            //sixth ghost
            ghost6.Visible = false;

            //seventh ghost
            ghost7.Visible = false;

            //boss ghost
            bossPicture.Visible = false;
        }

        // retun game score
        public static int getGameScore
        {
            get { return gameScore; }
        }

    }
}
