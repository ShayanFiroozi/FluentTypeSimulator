using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentTypeSimulator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {

        }

        private void BtnOpenFile_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Title = "Open an ASCII file";
            openFileDialog1.Filter = "All ASCII Files|*.*";
            openFileDialog1.DefaultExt = "*.*";

            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(openFileDialog1.FileName))
                {
                    if (File.Exists(openFileDialog1.FileName))
                    {
                        txtSource.Text = File.ReadAllText(openFileDialog1.FileName);
                    }
                }


            }

        }

        private async void BtnStart_Click(object sender, System.EventArgs e)
        {

            if (!ValidateInputData()) return;

            // Wait before start the typing silulation
            await Task.Delay((int)(numericStartDelay.Value * 1_000));
        }


        private bool ValidateInputData()
        {
            // Validate Source Data
            if (string.IsNullOrWhiteSpace(txtSource.Text) || txtSource.Text.Length < 10)
            {

                MessageBox.Show("Invalid source", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            // Validate Typing Speed
            if (numericTypeSpeed.Value < 1 && numericTypeSpeed.Value > 20)
            {
                MessageBox.Show("Invalid Typing Speed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }


            // Validate New Line Delay
            if (numericNewLineDelay.Value < 1 && numericNewLineDelay.Value > 10)
            {
                MessageBox.Show("Invalid New Line Delay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }


            // Validate Start Delay
            if (numericStartDelay.Value < 1 && numericStartDelay.Value > 20)
            {
                MessageBox.Show("Invalid Start Delay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }


            return true;

        }



    }
}
