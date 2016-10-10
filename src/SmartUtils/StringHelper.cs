using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

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

        public static string GetHash(this string input)
        {
            using (HashAlgorithm hashAlgorithm = new SHA256CryptoServiceProvider())
            {
                byte[] byteValue = System.Text.Encoding.UTF8.GetBytes(input);

                byte[] byteHash = hashAlgorithm.ComputeHash(byteValue);

                return Convert.ToBase64String(byteHash);
            }
        }

        /// <summary>
        /// Normaliza espaçamento, deixando sempre apenas um espaço entre as palavras, ou seja, os espaços adicionais são retirados.
        /// Esse comportamento é válido para o início e para o final do texto também.
        /// </summary>
        /// <param name="inputText">Texto à ser normalizado.</param>
        /// <returns>Texto com espaçamento normalizado em apenas um espaço.</returns>
        public static string NormalizeWhitespace(this string inputText)
        {
            return System.Text.RegularExpressions.Regex.Replace(inputText, @"\s{2,}", " ");
        }
    }
}
