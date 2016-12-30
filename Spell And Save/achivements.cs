using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using LevelOne1;

namespace Spell_And_Save
{
    public partial class achivements : Form
    {
        static int storeScore, storeScore2, storeScore3;
        static int currentScore, currentScore2, currentScore3;

        public achivements()
        {
            InitializeComponent();

            try
            {
                // For level 1
                storeScore = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level1\SpellAndSaveStoreScore.txt"));
                currentScore = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level1\SpellAndSaveCurrentScore.txt"));

                // For level 2
                storeScore2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level2\SpellAndSaveStoreScore.txt"));
                currentScore2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level2\SpellAndSaveCurrentScore.txt"));

                // For level 3
                storeScore3 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveStoreScore.txt"));
                currentScore3 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveCurrentScore.txt"));
            }
            catch
            {
                scoreLabel1.Text = "0";
                scoreLabel2.Text = "0";
                scoreLabel3.Text = "0";
            }
        }

        // Back button
        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void achivements_Load(object sender, EventArgs e)
        {
            // Level1 score check
            scoreCheck();

            // Level1 score show
            showScore();

            // Level2 score check
            scoreCheck2();

            // Level2 score show
            showScore2();

            // Level3 score check
            scoreCheck3();

            // Level3 score show
            showScore3();
        }

    }
}
