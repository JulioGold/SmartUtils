using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartUtils
{
    public static class StringHelper
    {
        public static string NTimes(this string word, int times)
        {
            return String.Join(String.Empty, Enumerable.Repeat(word, times));
        }

        /// <summary>
        /// Split a string char by char creating a array of string.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string[] SplitCharByChar(this string text)
        {
            List<string> caracteres = new List<string>();

            foreach (char c in text)
            {
                caracteres.Add(c.ToString());
            }

            return caracteres.ToArray();
        }
    }
}
