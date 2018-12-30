using System;
using System.Windows.Forms;

namespace PassGeneratorUI
{
    public static class Validation 
    {
        //Only digits code
        public static void OnlyDigit(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 /*&& ch != ','*/)
            {
                e.Handled = true;
            }
        }
        public static bool LenghtRangeValidation(int lenght)
        {
            if (lenght < 6 || lenght > 100)
            {
                MessageBox.Show("Lenght should be between 6 and 100 characters.");
                return true;
            }
            else
                return false;
        }
    }
}
