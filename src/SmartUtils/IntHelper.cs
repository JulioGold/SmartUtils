using System;
using System.Linq;

namespace SmartUtils
{
    public static class IntHelper
    {
        public static string NTimes(this int number, int times) => String.Join(String.Empty, Enumerable.Repeat(number, times));

        /// <summary>
        /// Verifica se o número passado é ou não é um número primo.
        /// Check if the passed number is prime numebr or not.
        /// Prime number
        /// </summary>
        /// <param name="number">Número à ser verificado se é ou não um número primo.</param>
        /// <returns>True se é primo ou False se não é primo.</returns>
        public static bool IsPrime(this long number)
        {
            //Por convenção 1 e 0 não são números primos. Então se menor ou igual a 1 não é um número primo.
            if (number <= 1)
            {
                return false;
            }

            if ((number % 2) == 0 & number != 2) /*Se o número é par então não é primo, o único número primo par é 2. Isto é para otimização de performance.*/
            {
                return false;
            }

            for (long i = 2; number > i; i++) /*i não deve iniciar em 1, pois o resto da divisão por 1 será zero e será exibido como errado.*/
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Verifica se o número passado é ou não é um número primo.
        /// Check if the passed number is prime numebr or not.
        /// Prime number
        /// </summary>
        /// <param name="number">Número à ser verificado se é ou não um número primo.</param>
        /// <returns>True se é primo ou False se não é primo.</returns>
        public static bool IsPrime(this int number) => ((long)number).IsPrime();
    }
}
