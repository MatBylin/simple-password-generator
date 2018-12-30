using System;
using PassGenerator;
using System.Windows.Forms;

namespace PassGeneratorUI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            if (Validation.LenghtRangeValidation(int.Parse(PassLenght.Text)))
                return;
            GetData();
            Password pass = new Password(lenght, specialChars, lowerChars, upperChars, numberChars);
            string password = pass.GeneratePassword();
            PassBox.Text = password;
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            //Copy text to the clipboard
            Clipboard.SetText(PassBox.Text);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Validate Lenght
        private void PassLenght_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyDigit(sender, e);
        }

        //Data from the UI
        int lenght;
        bool lowerChars, upperChars, specialChars, numberChars;

        private void GetData()
        {
            lenght = int.Parse(PassLenght.Text);
            lowerChars = LowerCheck.Checked;
            upperChars = UpperCheck.Checked;
            specialChars = SpecialCheck.Checked;
            numberChars = NumbersCheck.Checked;
        }

        //Menu function
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Password Generator v.1.00 \n" +
                "matbylin@gmail.com\n" +
                "https://github.com/MatBylin/", "Info");
        }
    }
}
