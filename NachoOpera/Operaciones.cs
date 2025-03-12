using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NachoOpera
{
    public class Operaciones
    {
        /// <summary>
        /// Método que realiza la suma de dos números enteros largos.
        /// </summary>
        /// <param name="a">Operando 1</param>
        /// <param name="b">Operando 2</param>
        /// <returns>Resultado de la suma</returns>
        public static long Sumar(long a, long b)
        {
            return a + b;
        }

        /// <summary>
        /// Método que realiza la resta de dos números enteros largos.
        /// </summary>
        /// <param name="a">Minuendo</param>
        /// <param name="b">Sustraendo</param>
        /// <returns>Resultado de la resta</returns>
        public static long Restar(long a, long b)
        {
            return a - b;
        }

        /// <summary>
        /// Método que realiza la multiplicación de dos números enteros largos.
        /// </summary>
        /// <param name="a">Factor 1</param>
        /// <param name="b">Factor 2</param>
        /// <returns>Resultado de la multiplicación</returns>
        public static long Multiplicar(long a, long b)
        {
            return a * b;
        }

        /// <summary>
        /// Método que realiza la división de dos números enteros largos.
        /// </summary>
        /// <param name="a">Dividendo</param>
        /// <param name="b">Divisor</param>
        /// <returns>Resultado de la división</returns>
        /// <exception cref="DivideByZeroException">Si el divisor es 0, lanza una excepción.</exception>
        public static double Dividir(long a, long b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir por cero.");

            return (double)a / b;
        }
    }
}
