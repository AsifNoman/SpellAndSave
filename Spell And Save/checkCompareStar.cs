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

        /**************** For Level One ********************/

        public void checkStarLevel1()
        {
            if (storeStar <= CurrentStar)
            {
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level1\SpellAndSaveStoreStar.txt", CurrentStar.ToString());
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
            else if (storeStar >= CurrentStar)
            {
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level1\SpellAndSaveStoreStar.txt", storeStar.ToString());
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        public void compareStarLevel1()
        {
            if (storeStar == 3)
            {
                firstStar.Image = Spell_And_Save.Properties.Resources.star1;
                secondStar.Image = Spell_And_Save.Properties.Resources.star1;
                thirdStar.Image = Spell_And_Save.Properties.Resources.star1;
                levelLockPic.Image = Spell_And_Save.Properties.Resources.level2;
            }
            else if (storeStar == 2)
            {
                firstStar.Image = Spell_And_Save.Properties.Resources.star1;
                secondStar.Image = Spell_And_Save.Properties.Resources.star1;
                levelLockPic.Image = Spell_And_Save.Properties.Resources.level2;
            }
            else if (storeStar == 1)
            {
                firstStar.Image = Spell_And_Save.Properties.Resources.star1;
                levelLockPic.Image = Spell_And_Save.Properties.Resources.level2;
            }
            else if (storeStar == 0)
            {
                firstStar.Image = Spell_And_Save.Properties.Resources.star0;
                secondStar.Image = Spell_And_Save.Properties.Resources.star0;
                thirdStar.Image = Spell_And_Save.Properties.Resources.star0;
            }
        }

        /**************** For Level Two ********************/

        public void checkStarLevel2()
        {
            if (storeStar2 <= CurrentStar2)
            {
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level2\SpellAndSaveStoreStar.txt", CurrentStar2.ToString());
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
            else if (storeStar2 >= CurrentStar2)
            {
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level2\SpellAndSaveStoreStar.txt", storeStar2.ToString());
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        public void compareStarLevel2()
        {
            if (storeStar2 == 3)
            {
                firstStarTwo.Image = Spell_And_Save.Properties.Resources.star1;
                secondStarTwo.Image = Spell_And_Save.Properties.Resources.star1;
                thirdStarTwo.Image = Spell_And_Save.Properties.Resources.star1;
                levelLockPic2.Image = Spell_And_Save.Properties.Resources.level3;
            }
            else if (storeStar2 == 2)
            {
                firstStarTwo.Image = Spell_And_Save.Properties.Resources.star1;
                secondStarTwo.Image = Spell_And_Save.Properties.Resources.star1;
                levelLockPic2.Image = Spell_And_Save.Properties.Resources.level3;
            }
            else if (storeStar2 == 1)
            {
                firstStarTwo.Image = Spell_And_Save.Properties.Resources.star1;
                levelLockPic2.Image = Spell_And_Save.Properties.Resources.level3;
            }
            else if (storeStar2 == 0)
            {
                firstStarTwo.Image = Spell_And_Save.Properties.Resources.star0;
                secondStarTwo.Image = Spell_And_Save.Properties.Resources.star0;
                thirdStarTwo.Image = Spell_And_Save.Properties.Resources.star0;
            }
        }

        /**************** For Level Three ********************/

        public void checkStarLevel3()
        {
            if (storeStar3 <= CurrentStar3)
            {
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveStoreStar.txt", CurrentStar3.ToString());
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
            else if (storeStar3 >= CurrentStar3)
            {
                try
                {
                    System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Level3\SpellAndSaveStoreStar.txt", storeStar3.ToString());
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        public void compareStarLevel3()
        {
            if (storeStar3 == 3)
            {
                firstStarThree.Image = Spell_And_Save.Properties.Resources.star1;
                secondStarThree.Image = Spell_And_Save.Properties.Resources.star1;
                thirdStarThree.Image = Spell_And_Save.Properties.Resources.star1;
            }
            else if (storeStar3 == 2)
            {
                firstStarThree.Image = Spell_And_Save.Properties.Resources.star1;
                secondStarThree.Image = Spell_And_Save.Properties.Resources.star1;
            }
            else if (storeStar3 == 1)
            {
                firstStarThree.Image = Spell_And_Save.Properties.Resources.star1;
                levelLockPic.Image = Spell_And_Save.Properties.Resources.level2;
            }
            else if (storeStar3 == 0)
            {
                firstStarThree.Image = Spell_And_Save.Properties.Resources.star0;
                secondStarThree.Image = Spell_And_Save.Properties.Resources.star0;
                thirdStarThree.Image = Spell_And_Save.Properties.Resources.star0;
            }
        }
    }
}
