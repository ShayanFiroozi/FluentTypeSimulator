using System;
using System.Linq;
using System.Windows.Forms;

namespace FluentTypeSimulator.BackEnd
{
    internal static class Parser
    {
        public static char[] ParseString(string inputData)
        {
            if (string.IsNullOrWhiteSpace(inputData))
            {
                throw new ArgumentException($"'{nameof(inputData)}' cannot be null or whitespace.", nameof(inputData));
            }

            return inputData.ToCharArray().Where(c => c != '\r').ToArray();

            

        }



    }
}
