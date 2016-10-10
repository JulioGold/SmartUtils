using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace SmartUtils
{
    public static class StringHelper
    {
        public static string NTimes(this string word, int times) => String.Join(String.Empty, Enumerable.Repeat(word, times));

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
        public static string NormalizeWhitespace(this string inputText) => Regex.Replace(inputText, @"\s{2,}", " ");

        /// <summary>
        /// Retira caracteres diversos, deixando apenas números.
        /// </summary>
        /// <param name="texto">String qualquer.</param>
        /// <returns>Retorna o número contido na string passada. A sequência é definida conforme a sequência da string passada.</returns>
        public static string Numbers(this string inputText) => String.Join(null, Regex.Split(inputText, "[^\\d]"));

        public static string Join(string separator, Func<string, bool> predicate, params string[] values) => String.Join(separator, values.Where(predicate));
        public static string Join(string separator, Func<object, bool> predicate, params object[] values) => String.Join(separator, values.Where(predicate));
        public static string Join(string separator, Func<string, bool> predicate, IEnumerable<string> values) => String.Join(separator, values.Where(predicate));
        public static string Join(string separator, Func<string, bool> predicate, String[] value, int startIndex, int count) => String.Join(separator, value.Where(predicate), startIndex, count);
        public static string Join<T>(string separator, Func<T, bool> predicate, IEnumerable<T> values) => String.Join(separator, values.Where(predicate));
    }
}
