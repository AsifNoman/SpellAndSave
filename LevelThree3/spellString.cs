using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelThree3
{
    class spellString
    {
        public static string getOneRandomChar()
        {
            string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            char []stringChars = new char[1];
            Random random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string finalString = new String(stringChars);

            return finalString;
        }

        public static string getdoubleRandomChar()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] stringChars = new char[2];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new string(stringChars);

            return finalString;
        }

        public static string getdoubleRandomChar2()
        {
            string chars = "abcgfewqpl1230987";
            char[] stringChars = new char[2];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new string(stringChars);

            return finalString;
        }

        public static string getThreeRandomChar()
        {
            string chars = "][/-abcdeuvwxyz0123456789AVCBOPK";
            char[] stringChars = new char[3];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            return finalString;
        }

        public static string getthreeRandomChar2()
        {
            string chars = "][/-abcdeuvwxyz0123456789";
            char[] stringChars = new char[3];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            return finalString;
        }

        public static string getthreeRandomChar3()
        {
            string chars = "ABCDEFGHIJKL34567";
            char[] stringChars = new char[3];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            return finalString;
        }

        public static string getthreeRandomChar4()
        {
            string chars = "ABCDEFGHIJKL3456789MNOPQRS";
            char[] stringChars = new char[3];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            return finalString;
        }

        public static string getFiveRandomChar()
        {
            string chars = "][/-WQXZabcdeuvwxyz0123456789ABCRIWURI";
            char[] stringChars = new char[5];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            return finalString;
        }

        public static string getSixRandomChar()
        {
            string chars = "][/-WQXZabcdeuvwxyz0123456789ABCRIWURI?<>";
            char[] stringChars = new char[6];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            return finalString;
        }

        public static string getSixRandomChar2()
        {
            string chars = "][/-?><)(AVBRopqrstuv18593-+";
            char[] stringChars = new char[6];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            return finalString;
        }
    }
}
