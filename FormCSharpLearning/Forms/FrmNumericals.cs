using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace FormCSharpLearning.Forms
{
    public partial class FrmNumericals : Form
    {
        private NumbersController _numbers;
        private int _counter = 0;

        public FrmNumericals()
        {
            InitializeComponent();
            _numbers = new NumbersController();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            Calculate(tbAdd1.Text, tbAdd2.Text, "Add");
        }

        private void btnSubtract_Click(object sender, System.EventArgs e)
        {
            try
            {
                double valueOne = Convert.ToDouble(tbSub1.Text);
                double valueTwo = Convert.ToDouble(tbSub2.Text);
                double total = _numbers.Subtract(valueOne, valueTwo);
                tbOutputSub.Text = $"{total}";
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Numbers only", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMultiply_Click(object sender, System.EventArgs e)
        {
            try
            {
                double valueOne = Convert.ToDouble(tbMult1.Text);
                double valueTwo = Convert.ToDouble(tbMult2.Text);
                double total = _numbers.Multiply(valueOne, valueTwo);
                tbOutputMult.Text = $"{total}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Numbers only", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDivide_Click(object sender, System.EventArgs e)
        {
            try
            {
                double valueOne = Convert.ToDouble(tbDiv1.Text);
                double valueTwo = Convert.ToDouble(tbDiv2.Text);
                double total = _numbers.Divide(valueOne, valueTwo);
                tbOutputDiv.Text = $"{total}";
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Numbers only", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calculate(string strValueOne, string strValueTwo, string arithmeticType)
        {
            try
            {
                double valueOne = Convert.ToDouble(strValueOne);
                double valueTwo = Convert.ToDouble(strValueTwo);
                double total = 0;

                switch (arithmeticType)
                {
                    case "Add":
                        total = _numbers.Add(valueOne, valueTwo);
                        tbOutputAdd.Text = $"{total}";
                        break;
                    case "Subtract":
                        total = _numbers.Subtract(valueOne, valueTwo);
                        tbOutputSub.Text = $"{total}";
                        break;
                    case "Multiply":
                        total = _numbers.Subtract(valueOne, valueTwo);
                        tbOutputMult.Text = $"{total}";
                        break;
                    case "Divide":
                        total = _numbers.Subtract(valueOne, valueTwo);
                        tbOutputDiv.Text = $"{total}";
                        break;
                    default:
                        MessageBox.Show("Could not calculate");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Numbers only", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGreaterThan_Click(object sender, EventArgs e)
        {
            try
            {
                double valueOne = Convert.ToDouble(tbGTInputOne.Text);
                double valueTwo = Convert.ToDouble(tbGTInputTwo.Text);

                if (valueOne > valueTwo)
                {
                    // true statement
                    tbGTInputOne.BackColor = Color.Green;
                }
                else
                {
                    // false statement
                    tbGTInputOne.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }

        private void btnGreaterThanEqual_Click(object sender, EventArgs e)
        {
            try
            {
                double valueOne = Convert.ToDouble(tbGTEInputOne.Text);
                double valueTwo = Convert.ToDouble(tbGTEInputTwo.Text);

                if (valueOne >= valueTwo)
                {
                    // true statement
                    tbGTEInputOne.BackColor = Color.Green;
                }
                else
                {
                    // false statement
                    tbGTEInputOne.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }

        private void btnLessThan_Click(object sender, EventArgs e)
        {
            try
            {
                double valueOne = Convert.ToDouble(tbLTInputOne.Text);
                double valueTwo = Convert.ToDouble(tbLTInputTwo.Text);

                if (valueOne < valueTwo)
                {
                    // true statement
                    tbLTInputOne.BackColor = Color.Green;
                }
                else
                {
                    // false statement
                    tbLTInputOne.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }

        private void btnLessThanEqual_Click(object sender, EventArgs e)
        {
            try
            {
                double valueOne = Convert.ToDouble(tbLTEInputOne.Text);
                double valueTwo = Convert.ToDouble(tbLTEInputTwo.Text);

                if (valueOne <= valueTwo)
                {
                    // true statement
                    tbLTEInputOne.BackColor = Color.Green;
                }
                else
                {
                    // false statement
                    tbLTEInputOne.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                double valueOne = Convert.ToDouble(tbEInputOne.Text);
                double valueTwo = Convert.ToDouble(tbEInputTwo.Text);

                if (valueOne == valueTwo)
                {
                    // true statement
                    tbEInputOne.BackColor = Color.Green;
                }
                else
                {
                    // false statement
                    tbEInputOne.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }

        private void btnNotEquals_Click(object sender, EventArgs e)
        {
            try
            {
                double valueOne = Convert.ToDouble(tbNEInputOne.Text);
                double valueTwo = Convert.ToDouble(tbNEInputTwo.Text);

                if (valueOne != valueTwo)
                {
                    // true statement
                    tbNEInputOne.BackColor = Color.Green;
                }
                else
                {
                    // false statement
                    tbNEInputOne.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }

        private void btnAddCounter_Click(object sender, EventArgs e)
        {
            try
            {
                int countByAmount = Convert.ToInt32(tbCounterInput.Text);
                _counter += countByAmount;
                tbCounterOutput.Text = _counter.ToString();
            }
            catch
            {

            }
        }

        private void btnMinusCounter_Click(object sender, EventArgs e)
        {
            try
            {
                int countByAmount = Convert.ToInt32(tbCounterInput.Text);
                _counter -= countByAmount;
                tbCounterOutput.Text = _counter.ToString();
            }
            catch
            {

            }
        }

        private void btnMultiplyCounter_Click(object sender, EventArgs e)
        {
            try
            {
                int countByAmount = Convert.ToInt32(tbCounterInput.Text);
                _counter *= countByAmount;
                tbCounterOutput.Text = _counter.ToString();
            }
            catch
            {

            }
        }

        private void btnDivideCounter_Click(object sender, EventArgs e)
        {
            try
            {
                int countByAmount = Convert.ToInt32(tbCounterInput.Text);
                _counter /= countByAmount;
                tbCounterOutput.Text = _counter.ToString();
            }
            catch
            {

            }
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            _counter++;
            tbCounterOutput.Text = _counter.ToString();
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            _counter--;
            tbCounterOutput.Text = _counter.ToString();
        }
    }
}
