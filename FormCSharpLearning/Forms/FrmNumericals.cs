using FormCSharpLearning.Numbers;
using System.Windows.Forms;

namespace FormCSharpLearning.Forms
{
    public partial class FrmNumericals : Form
    {
        private NumbersController _numbers;

        public FrmNumericals()
        {
            InitializeComponent();
            _numbers = new NumbersController();

            _numbers.Age = 0;
            int value = NumbersHelper.ReturnNumber();
        }
    }
}
