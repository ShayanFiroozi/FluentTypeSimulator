using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentTypeSimulator.BackEnd
{
    internal static class KeyboardSimulator
    {


        public static async Task SimulateTyping(string TextToType, int KeyPressDelayInMilliSeconds, int NewLineDelayInMilliSedonds)
        {
            char[] CharsToType = Parser.ParseString(TextToType);

            if (CharsToType.Length == 0)
            {
                throw new Exception("No word to type !");
            }

            foreach (char character in CharsToType)
            {
                await SimulateKeyPress(character, NewLineDelayInMilliSedonds);

                if (NewLineDelayInMilliSedonds > 0)
                {
                    await Task.Delay(KeyPressDelayInMilliSeconds);
                }
            }

        }

        private static async Task SimulateKeyPress(char character, int NewLineDelayInMilliSedonds)
        {

            switch (character)
            {
                case '\n':
                    // Simulate pressing Enter
                    SendKeys.Send("{ENTER}");
                    await Task.Delay(NewLineDelayInMilliSedonds);
                    break;

                case ' ':
                    // Simulate pressing Space
                    SendKeys.Send(" ");
                    break;
                default:
                    // Simulate other character

                    if (char.IsLetter(character) || char.IsDigit(character) || char.IsNumber(character))
                    {
                        // Letter or number characters
                        SendKeys.Send(character.ToString());
                    }
                    else
                    {
                        // Special characters
                        SendKeys.Send($"{{{character}}}");
                    }

                    break;
            }
        }





    }
}
