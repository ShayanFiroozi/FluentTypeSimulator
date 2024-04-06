using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentTypeSimulator.BackEnd
{
    internal static class TypeSimulator
    {


        public static async Task SimulateTyping(string TextToType, int KeyPressDelayInMilliSeconds, int NewLineDelayInMilliSedonds)
        {
            char[] CharsToType = Parser.StringToCharArray(TextToType);

            if (CharsToType.Length == 0)
            {
                throw new Exception("No word to type !");
            }

            foreach (char character in CharsToType)
            {
             
                await SimulateKeyPress(character, NewLineDelayInMilliSedonds);

                if (KeyPressDelayInMilliSeconds > 0)
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
                    KeyBoardSimulator.PressEnter();

                    // Bring the cursor to the begin of the new line
                    KeyBoardSimulator.PressHome();

                    await Task.Delay(NewLineDelayInMilliSedonds);
                    break;

                case ' ':
                    // Simulate pressing Space
                    KeyBoardSimulator.PressSpace();
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
                        KeyBoardSimulator.PressSpecialCharacter(character.ToString());
                    }

                    break;
            }
        }





    }
}
