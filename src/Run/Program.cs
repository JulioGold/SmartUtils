﻿using System;
using System.Collections.Generic;
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

            #region StringHelper.JoinWithoutNullOrEmptyOrWhiteSpace

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- StringHelper.JoinWithoutNullOrEmptyOrWhiteSpace -------");

            Console.WriteLine(StringHelper.JoinWithoutNullOrEmptyOrWhiteSpace(", ", new string[] { "Smart", "Utils", "   ", "" }));

            Console.WriteLine("------- StringHelper.JoinWithoutNullOrEmptyOrWhiteSpace ------->");

            #endregion

            #region StringHelper.RemoveAccents

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- StringHelper.RemoveAccents -------");

            Console.WriteLine("áéíóú,àèìòù,äëïöü,âêîôû,ÁÉÍÓÚ,ÀÈÌÒÙ,ÄËÏÖÜ,ÂÊÎÔÛ".RemoveAccents());

            Console.WriteLine("------- StringHelper.RemoveAccents ------->");

            #endregion

            #region IntHelper.IsPrime

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- IntHelper.IsPrime -------");
            Console.WriteLine(7.IsPrime());
            Console.WriteLine(14.IsPrime());
            Console.WriteLine(19.IsPrime());
            Console.WriteLine("------- IntHelper.IsPrime ------->");

            #endregion

            #region SmartUtils.CheckHasNull

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- SmartUtils.CheckHasNull -------");
            Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(null, 1));
            Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(null, null));
            Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(1, "A"));
            Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(1, null));
            Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(new List<object> { null, 1 }));
            Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(new List<object> { null, null }));
            Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(new List<object> { 1, "A" }));
            Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(new List<object> { 1, null }));
            Console.WriteLine("------- SmartUtils.CheckHasNull ------->");

            #endregion

            #region StringHelper.BtoA

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- StringHelper.BtoA -------");

            Console.WriteLine(StringHelper.BtoA("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));

            Console.WriteLine("------- StringHelper.BtoA ------->");

            #endregion

            #region StringHelper.AtoB

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("<!------- StringHelper.AtoB -------");

            Console.WriteLine(StringHelper.AtoB("QUJDREVGR0hJSktMTU5PUFFSU1RVVldYWVo="));

            Console.WriteLine("------- StringHelper.AtoB ------->");

            #endregion

            Console.ReadKey();
        }
    }
}
