using System;
using System.Collections.Generic;
using System.Text;

namespace PassGenerator
{
    public class Password
    {
        List<char> listOfChars = new List<char>();

        public int Lenght { get; private set; }
        public bool SpecialChars { get; private set; }
        public bool LowercaseChars { get; private set; }
        public bool UppercaseChars { get; private set; }
        public bool NumberChars { get; private set; }

        public Password(int lenght, bool specialChars, bool lowerChars, bool upperChars, bool numberChars)
        {
            Lenght = lenght;
            SpecialChars = specialChars;
            LowercaseChars = lowerChars;
            UppercaseChars = upperChars;
            NumberChars = numberChars;
        }

        private void GenerateList()
        {
            if (LowercaseChars)
            {
                for (char c = 'a'; c < 'z'; c++)
                {
                    listOfChars.Add(c);
                }
            }
            if (UppercaseChars)
            {
                for (char c = 'A'; c < 'Z'; c++)
                {
                    listOfChars.Add(c);
                }
            }
            if (NumberChars)
            {
                for (char c = '0'; c < '9'; c++)
                {
                    listOfChars.Add(c);
                }
            }
            if (SpecialChars)
            {
                for (char c = '!'; c < '/'; c++)
                {
                    listOfChars.Add(c);
                }
                for (char c = ':'; c < '?'; c++)
                {
                    listOfChars.Add(c);
                }
            }
        }

        public string GeneratePassword()
        {
            GenerateList();
            StringBuilder builder = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < Lenght; i++)
            {
                builder.Append(listOfChars[rnd.Next(0, listOfChars.Count)]);
            }

            return builder.ToString();
        }
    }
}
