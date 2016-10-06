using System;
using System.Linq;

namespace SmartUtils
{
    public static class StringHelper
    {
        public static string NTimes(this string word, int times)
        {
            return String.Join(String.Empty, Enumerable.Repeat(word, times));
        }
    }
}
