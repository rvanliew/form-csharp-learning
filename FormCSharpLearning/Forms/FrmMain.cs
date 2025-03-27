using FormCSharpLearning.Forms;
using System;
using System.Windows.Forms;

namespace FormCSharpLearning
{
    public partial class FrmMain : Form
    {
        private FrmNumericals _frmNumericals;
        private FrmStrings _frmStrings;

        public FrmMain()
        {
            InitializeComponent();
            lblHeader.Text = "Main Menu";
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            _frmNumericals = new FrmNumericals()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            _frmNumericals.FormBorderStyle = FormBorderStyle.None;
            ClearMainPanel();
            panelMain.Controls.Add(_frmNumericals);
            _frmNumericals.Show();
        }

        private void ClearMainPanel()
        {
            panelMain.Controls.Clear();
        }

        private void btnStrings_Click(object sender, EventArgs e)
        {
            _frmStrings = new FrmStrings()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            _frmStrings.FormBorderStyle = FormBorderStyle.None;
            ClearMainPanel();
            panelMain.Controls.Add(_frmStrings);
            _frmStrings.Show();
        }
    }
}
