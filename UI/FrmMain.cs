using FluentTypeSimulator.BackEnd;
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

            cmbAfterTypeEvent.SelectedIndex = 0;

        }



        private void BtnOpenFile_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Title = "Open Text file";
            openFileDialog1.Filter = "All Text Files|*.*";
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
            try
            {

                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                BtnStart.Enabled = false;

                // Validate InputData
                if (!ValidateInputData()) return;

                // Show an attention Message Box about clearing the clipboard current data
                if (ChkCopyPaste.Checked)
                {


                    if (MessageBox.Show($"The Copy/Paste mode is enable , this action will clear your current clipboard data !\n\n" +
                                      $"Do you want to continue ?",
                                      "Start Copy Pasting !",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return;
                    }


                }


                MessageBox.Show($"Typing will be started after {numericStartDelay.Value / 1_000} seconds\n\n" +
                                $"Please activate your target app and make sure to keep the focus on it.",
                                "Start Typing",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                // Wait before start the typing simulation
                await Task.Delay((int)numericStartDelay.Value);


                if (ChkCopyPaste.Checked)
                {
                    // Start copy pasting
                    await TypeSimulatorCopyPasteMode.StartCopyPasting(txtSource.Text,
                                                                     (int)numericNewLineDelay.Value);
                }
                else
                {
                    // Start typing simulation
                    await TypeSimulator.SimulateTyping(txtSource.Text,
                                                      (int)numericKeyPressDelay.Value,
                                                      (int)numericNewLineDelay.Value);
                }


                switch (cmbAfterTypeEvent.SelectedIndex)
                {
                    case 1:
                        SendKeys.Send("{F5}");
                        break;
                    case 2:
                        KeyBoardSimulator.PressCTRLWithACharacter("F5");
                        break;
                    case 3:
                        KeyBoardSimulator.PressCTRLWithACharacter("S");
                        break;
                }

            }

            finally
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                BtnStart.Enabled = true;
            }
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
            if (numericKeyPressDelay.Value < 1 && numericKeyPressDelay.Value > 20)
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
