using System;
using System.Linq;

namespace SmartUtils
{
    public static class IntHelper
    {
        public static string NTimes(this int number, int times)
        {
            return String.Join(String.Empty, Enumerable.Repeat(number, times));
        }
    }
}
