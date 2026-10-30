using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    internal class aritmetica
    {



        /// <summary>
        /// Operação Soma
        /// </summary>
        /// <returns>Retorna a soma de 2 números</returns>
        public static int Somar (int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Operação Subtrair
        /// </summary>
        /// <returns>Retorna a subtração de 2 números</returns>
        public static int Subtrair (int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Operação de multiplicação
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retorna a multiplicação de 2 números</returns>
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
    }
}
