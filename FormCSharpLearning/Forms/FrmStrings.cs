using FormCSharpLearning.Strings;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormCSharpLearning.Forms
{
    public partial class FrmStrings : Form
    {
        private List<DataModel> _csvData = new List<DataModel>();

        public FrmStrings()
        {
            InitializeComponent();
            _csvData = StringValidation.GetCustomerDataFromCsvFile();

            Random random = new Random();
            int randomIndex = random.Next(1, 500);

            tbFullName.Text = $"{_csvData[randomIndex].FirstName} {_csvData[randomIndex].LastName}";
        }

        private void btnDisplayString_Click(object sender, EventArgs e)
        {
            tbStringOutput.Text = tbStringInput.Text;
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            tbStringOutput.Text = tbStringInput.Text.ToUpper();
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            tbStringOutput.Text = tbStringInput.Text.ToLower();
        }

        private void btnConcatStrings_Click(object sender, EventArgs e)
        {
            //to show how bad concat is
            int characterLevel = 85;
            string className = "Warrior";
            DateTime currentDate = DateTime.Now;

            string valueOne = tbConcatInputOne.Text;
            string valueTwo = tbConcatInputTwo.Text;
            // this is ugly - don't do this
            string concatString = "Class Name:" + " " + className + " " + "Player Name:" + valueOne + " " + valueTwo + " " + "Character Level:" + " " + characterLevel.ToString() + " " + "DateTime:" + " " + currentDate.ToString();

            tbConcatStringOutput.Text = concatString;
            //short-hand
            //tbConcatStringOutput.Text = string.Concat(valueOne, valueTwo);
        }

        private void btnInterpolateString_Click(object sender, EventArgs e)
        {
            int characterLevel = 85;
            string className = "Warrior";
            DateTime currentDate = DateTime.Now;

            string valueOne = tbInterpValueOne.Text;
            string valueTwo = tbInterpValueTwo.Text;
            // interpolated strings will automatically convert whatever it finds
            // inside { } (square brackets) ToString()
            string interpolatedString = $"Character Level: {characterLevel}, " +
                $"Class Name: {className}, DateTime: {currentDate}, Player Name: {valueOne} {valueTwo}";

            tbInterpOutput.Text = interpolatedString;
        }

        private void btnGetLastName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFullName.Text))
            {
                return;
            }

            tbLastName.Text = StringValidation.GetLastName(tbFullName.Text);
        }
    }
}
