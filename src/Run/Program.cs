using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartUtils;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IntHelper.NTimes

            Console.WriteLine("<!------- IntHelper.NTimes -------");
            Console.WriteLine(1.NTimes(3));
            Console.WriteLine("------- IntHelper.NTimes ------->");

            #endregion

            #region StringHelper.NTimes

            Console.WriteLine("<!------- StringHelper.NTimes -------");
            Console.WriteLine("a".NTimes(3));
            Console.WriteLine("------- StringHelper.NTimes ------->");

            #endregion

            #region StringHelper.SplitCharByChar

            Console.WriteLine("<!------- StringHelper.SplitCharByChar -------");

            string nome = "SmartUtils";

            string[] letras = nome.SplitCharByChar();

            foreach (var item in letras)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("<!------- StringHelper.SplitCharByChar -------");

            #endregion

            Console.ReadKey();
        }
    }
}
