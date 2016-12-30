using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LevelOne1;

namespace Spell_And_Save
{
    static class Program
    {
        // level1 directory
        public static void levelOneDirectory()
        {
            try
            {
                // new directory path
                string newpath = System.IO.Path.Combine(@"C:\Users\Public\Documents\", "Level1");

                // new directory creation for level 1
                System.IO.Directory.CreateDirectory(newpath);
            }
            catch
            {
                MessageBox.Show("Error!!");
            }
        }

        // level2 directory
        public static void levelTwoDirectory()
        {
            try
            {
                // new directory path
                string newpath = System.IO.Path.Combine(@"C:\Users\Public\Documents\", "Level2");

                // new directory creation for level 2
                System.IO.Directory.CreateDirectory(newpath);
            }
            catch
            {
                MessageBox.Show("Error!!");
            }
        }

        // level3 directory
        public static void levelThreeDirectory()
        {
            try
            {
                // new directory path
                string newpath = System.IO.Path.Combine(@"C:\Users\Public\Documents\", "Level3");

                // new directory creation for level 3
                System.IO.Directory.CreateDirectory(newpath);
            }
            catch
            {
                MessageBox.Show("Error!!");
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "music.wav";

            levelOneDirectory();
            levelTwoDirectory();
            levelThreeDirectory();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Loading(player));

        }
    }
}
