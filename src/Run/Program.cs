using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartUtils;
using System.IO;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IntHelper.NTimes

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- IntHelper.NTimes -------");
            Console.WriteLine(1.NTimes(3));
            Console.WriteLine("------- IntHelper.NTimes ------->");

            #endregion

            #region StringHelper.NTimes

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- StringHelper.NTimes -------");
            Console.WriteLine("a".NTimes(3));
            Console.WriteLine("------- StringHelper.NTimes ------->");

            #endregion

            #region StringHelper.SplitCharByChar

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- StringHelper.SplitCharByChar -------");

            string nome = "SmartUtils";

            string[] letras = nome.SplitCharByChar();

            foreach (var item in letras)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------- StringHelper.SplitCharByChar ------->");

            #endregion

            #region DirectoryHelper.GetDirectories

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- DirectoryHelper.GetDirectories -------");

            string[] directories = DirectoryHelper.GetDirectories(@"C:\temp", "*packages*|*node_modules*|*bin*|*obj*", SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Console.WriteLine("------- DirectoryHelper.GetDirectories ------->");

            #endregion

            #region StringHelper.GetHash

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- StringHelper.GetHash -------");
            Console.WriteLine("SmartUtils".GetHash());
            Console.WriteLine("------- StringHelper.GetHash ------->");

            #endregion

            #region StringHelper.NormalizeWhitespace

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- StringHelper.NormalizeWhitespace -------");
            Console.WriteLine("        SmartUtils    is     a cool        thing!".NormalizeWhitespace());
            Console.WriteLine("   is     a cool        thing  is    a       SmartUtils".NormalizeWhitespace());
            Console.WriteLine("------- StringHelper.NormalizeWhitespace ------->");

            #endregion

            #region StringHelper.Numbers

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- StringHelper.Numbers -------");
            Console.WriteLine("Smart4Utils2".Numbers());
            Console.WriteLine("------- StringHelper.Numbers ------->");

            #endregion

            #region StringHelper.Join

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- StringHelper.Join -------");

            Console.WriteLine(StringHelper.Join(", ", ((Func<string, bool>)((word) => !String.IsNullOrEmpty(word) && !String.IsNullOrWhiteSpace(word))) , new string[] { "Smart", "Utils", "   ", "" }));

            Console.WriteLine("------- StringHelper.Join ------->");

            #endregion

            #region StringHelper.JoinWithoutNullOrEmpty

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- StringHelper.JoinWithoutNullOrEmpty -------");

            Console.WriteLine(StringHelper.JoinWithoutNullOrEmpty(", ", new string[] { "Smart", "Utils", "   ", "" }));

            Console.WriteLine("------- StringHelper.JoinWithoutNullOrEmpty ------->");

            #endregion

            Console.ReadKey();
        }
    }
}
