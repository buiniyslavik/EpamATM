using System;
using System.Linq;
using System.Windows.Forms;

namespace epamATM
{
    public partial class PinForm : Form
    {
        public string pin { get; private set; }
        public PinForm()
        {
            InitializeComponent();
        }

        private void PinForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void entryBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string input = entryBox.Text;
            if (input.Length != 4 || !input.All(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(entryBox, "наркоман штоле?");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(entryBox, string.Empty);
            }
        }

        private void entryBox_Validated(object sender, EventArgs e)
        {
            pin = entryBox.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
