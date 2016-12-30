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
    public partial class popUpBox3 : Form
    {
        static int starcount;

        public popUpBox3()
        {
            InitializeComponent();
        }

        private void popUpBox_Load(object sender, EventArgs e)
        {
            try
            {
                starcount = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveCurrentStar.txt"));
            }
            catch
            {
                MessageBox.Show("Error!!");
            }

            // Score show
            scoreLabel.Text = "Score:"+levelThree.getGameScore.ToString();

            // Star show
            if(starcount==3)
            {
                star1.Image = LevelThree3.Properties.Resources._1star;
                star2.Image = LevelThree3.Properties.Resources._1star;
                star3.Image = LevelThree3.Properties.Resources._1star;
            }
            else if (starcount == 2)
            {
                star1.Image = LevelThree3.Properties.Resources._1star;
                star2.Image = LevelThree3.Properties.Resources._1star;
            }
            else if (starcount == 1)
            {
                star1.Image = LevelThree3.Properties.Resources._1star;
            }
            else if (starcount == 0)
            {
                star1.Image = LevelThree3.Properties.Resources.no_star;
                star2.Image = LevelThree3.Properties.Resources.no_star;
                star3.Image = LevelThree3.Properties.Resources.no_star;
            }
            else 
            {
                star1.Image = LevelThree3.Properties.Resources.no_star;
                star2.Image = LevelThree3.Properties.Resources.no_star;
                star3.Image = LevelThree3.Properties.Resources.no_star;
            }
        }

        private void levelsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
