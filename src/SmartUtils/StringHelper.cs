﻿using System;
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
        public static string JoinWithoutNullOrEmpty(string separator, params string[] values) => String.Join(separator, values.Where(item => !String.IsNullOrEmpty(item)));
        public static string JoinWithoutNullOrEmptyOrWhiteSpace(string separator, params string[] values) => String.Join(separator, values.Where(item => !String.IsNullOrEmpty(item) && !String.IsNullOrWhiteSpace(item)));

        public static string RemoveAccents(this string inputString)
        {
            inputString = new Regex("[á|à|ä|â|Á|À|Ä|Â]", RegexOptions.Compiled).Replace(inputString, "a");
            inputString = new Regex("[é|è|ë|ê|É|È|Ë|Ê]", RegexOptions.Compiled).Replace(inputString, "e");
            inputString = new Regex("[í|ì|ï|î|Í|Ì|Ï|Î]", RegexOptions.Compiled).Replace(inputString, "i");
            inputString = new Regex("[ó|ò|ö|ô|Ó|Ò|Ö|Ô]", RegexOptions.Compiled).Replace(inputString, "o");
            inputString = new Regex("[ú|ù|ü|û|Ú|Ù|Ü|Û]", RegexOptions.Compiled).Replace(inputString, "u");
            inputString = new Regex("[´|']", RegexOptions.Compiled).Replace(inputString, " ");

            return inputString;
        }

        /// <summary>
        /// Method like a BTOA from javascript.
        /// </summary>
        /// <param name="regularText"></param>
        /// <returns></returns>
        public static string BtoA(string regularText)
        {
            Func<string, byte[]> GetBytes = (text) =>
            {
                int length = text.Length;

                byte[] byteArr = new byte[length];

                for (int i = 0; i < length; i++)
                {
                    byteArr[i] = (byte)text[i];
                }

                return byteArr;
            };

            return Convert.ToBase64String(GetBytes(regularText));
        }

        /// <summary>
        /// Method like a ATOB from javascript.
        /// </summary>
        /// <param name="base64Encoded"></param>
        /// <returns></returns>
        public static string AtoB(string base64Encoded)
        {
            Func<byte[], string> GetString = (bytes) =>
            {
                int length = bytes.Length;

                char[] charArr = new char[length];

                for (int i = 0; i < length; i++)
                {
                    charArr[i] = (char)bytes[i];
                }

                return new string(charArr);
            };

            return GetString(System.Convert.FromBase64String(base64Encoded));
        }
    }
}
