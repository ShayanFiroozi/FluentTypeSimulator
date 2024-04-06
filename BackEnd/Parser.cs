using System;
using System.Linq;

namespace FluentTypeSimulator.BackEnd
{


    internal static class Parser
    {
        public static char[] StringToCharArray(string inputData)
        {
            if (string.IsNullOrWhiteSpace(inputData))
            {
                throw new ArgumentException($"'{nameof(inputData)}' cannot be null or whitespace.", nameof(inputData));
            }

            return inputData.ToCharArray().Where(c => c != '\r').ToArray();
        }


        public static string[] StringToStringArray(string inputData)
        {
            if (string.IsNullOrWhiteSpace(inputData))
            {
                throw new ArgumentException($"'{nameof(inputData)}' cannot be null or whitespace.", nameof(inputData));
            }

            return inputData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        }


    }



}
