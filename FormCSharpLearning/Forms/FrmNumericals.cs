using FormCSharpLearning.Numbers;
using System.Windows.Forms;
using System;
using System.ComponentModel;

namespace FormCSharpLearning.Forms
{
    public partial class FrmNumericals : Form
    {
        private NumbersController _numbers;

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
    }
}
