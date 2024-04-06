using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentTypeSimulator.BackEnd
{
    internal static class KeyBoardSimulator
    {

        public static void PressEnter() => SendKeys.Send("{ENTER}");

        public static void PressHome() => SendKeys.Send("{HOME}");

        public static void PressSpace() => SendKeys.Send(" ");

        public static void PressCtrlA() => PressCTRLWithACharacter("a");

        public static void PressCtrlC() => PressCTRLWithACharacter("c");

        public static void PressCtrlV() => PressCTRLWithACharacter("v");


        public static void PressSpecialCharacter(string character) => SendKeys.Send($"{{{character}}}");



        public static void PressCTRLWithACharacter(string character) => SendKeys.Send($"^{character}");

    }
}
