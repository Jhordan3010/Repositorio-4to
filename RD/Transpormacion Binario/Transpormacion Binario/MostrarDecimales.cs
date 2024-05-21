using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpormacion_Binario
{
    internal class MostrarDecimales
    {
        public class Conversor
        {
            private int _decimal;

            public Conversor(int numeroDecimal)
            {
                _decimal = numeroDecimal;
            }

            public string ConvertirABase(int baseValue)
            {
                if (baseValue < 2 || baseValue > 16)
                {
                    throw new ArgumentException("Base no soportada");
                }

                StringBuilder resultado = new StringBuilder();
                int numero = _decimal;
                int iteracion = 1;  // Para contar las iteraciones

                while (numero > 0)
                {
                    int residuo = numero % baseValue;
                    char digito = (residuo < 10) ? (char)('0' + residuo) : (char)('A' + residuo - 10);

                    // Muestra los pasos en la consola
                    Console.WriteLine($"Iteración {iteracion}:");
                    Console.WriteLine($"Número actual: {numero}");
                    Console.WriteLine($"Residuo: {residuo} -> Dígito: {digito}");
                    Console.WriteLine($"Número después de la división: {numero / baseValue}");
                    Console.WriteLine();

                    resultado.Insert(0, digito);
                    numero /= baseValue;
                    iteracion++;
                }

                if (resultado.Length == 0)
                {
                    resultado.Append('0');
                }

                return resultado.ToString();
            }
        }

    }
}
