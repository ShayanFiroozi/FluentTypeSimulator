using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentTypeSimulator.BackEnd
{
    internal static class TypeSimulatorCopyPasteMode
    {


        public static async Task StartCopyPasting(string TextToCopyPaste, int NewLineDelayInMilliSedonds)
        {
            string[] LinesToCopyPaste = Parser.StringToStringArray(TextToCopyPaste);

            if (LinesToCopyPaste.Length == 0)
            {
                throw new Exception("No lines to copy/paste !");
            }

            foreach (string line in LinesToCopyPaste)
            {
                // Handle the wmpty lines
                if (string.IsNullOrEmpty(line))
                {
                    KeyBoardSimulator.PressEnter();

                    if (NewLineDelayInMilliSedonds > 0)
                    {
                        await Task.Delay(NewLineDelayInMilliSedonds);
                    }
                    continue;
                }


                // Put the line to clipboard
                Clipboard.Clear();
                Clipboard.SetText(line);

                // Bring the cursor to the begin of the new line
                KeyBoardSimulator.PressHome();

                await Task.Delay(1);

                // Paste Data from clipboard
                KeyBoardSimulator.PressCtrlV();

                await Task.Delay(1);

                // Go to the new linw
                KeyBoardSimulator.PressEnter();

                if (NewLineDelayInMilliSedonds > 0)
                {
                    await Task.Delay(NewLineDelayInMilliSedonds);
                }



            }

        }






    }
}
