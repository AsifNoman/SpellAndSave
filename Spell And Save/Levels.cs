using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LevelOne1;
using LevelTwo2;
using LevelThree3;

namespace Spell_And_Save
{
    public partial class Levels : Form
    {
        static int storeStar,storeStar2,storeStar3;
        static int CurrentStar, CurrentStar2, CurrentStar3;

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        public Levels()
        {
            InitializeComponent();

            try
            {
                // Level1 Star
                storeStar = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level1\SpellAndSaveStoreStar.txt"));
                CurrentStar = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level1\SpellAndSaveCurrentStar.txt"));

                // Level2 Star
                storeStar2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level2\SpellAndSaveStoreStar.txt"));
                CurrentStar2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level2\SpellAndSaveCurrentStar.txt"));

                // Level3 Star
                storeStar3 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveStoreStar.txt"));
                CurrentStar3 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveCurrentStar.txt"));
            }
            catch
            {
                storeStar = 0;
                storeStar2 = 0;
                storeStar3 = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // For Level1

            checkStarLevel1();

            storeStar = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level1\SpellAndSaveStoreStar.txt"));

            compareStarLevel1();

            // For Level2

            checkStarLevel2();

            storeStar2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level2\SpellAndSaveStoreStar.txt"));

            compareStarLevel2();

            // For Level3

            checkStarLevel3();

            storeStar3 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveStoreStar.txt"));

            compareStarLevel3();

        }

        // Level One Button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            levelOne l = new levelOne();
            l.Show();
            this.Hide();
        }

        // Level One Button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           levelTwo l2 = new levelTwo();

           if (storeStar == 3 || storeStar == 2 || storeStar == 1)
           {
               l2.Show();
               this.Hide();
           }

        }

        // leve3 picturebox
        private void levelLockPic2_Click(object sender, EventArgs e)
        {
            levelThree l3 = new levelThree();

            if (storeStar2 == 3 || storeStar2 == 2 || storeStar2 == 1)
            {
                l3.Show();
                this.Hide();
            }
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Hide();
            f.Show();
        }

        
    }
}
