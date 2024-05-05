using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpormacion_Binario
{
    internal class ConversorOctal
    {
        private string octal; // Número octal a convertir

        // Constructor que recibe un número octal
        public ConversorOctal(string octal)
        {
            this.octal = octal;
        }

        // Método para verificar si una cadena es un número octal
        public bool EsOctal(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '7')
                {
                    return false;
                }
            }
            return true;
        }

        // Método para convertir un número octal a decimal
        public int OctalADecimal()
        {
            if (!EsOctal(octal))
            {
                throw new ArgumentException("No es un número octal válido");
            }

            int decimalValue = 0;
            int longitud = octal.Length;

            // Realiza la conversión de octal a decimal
            for (int i = 0; i < longitud; i++)
            {
                char digito = octal[i];
                int valorDigito = digito - '0';
                decimalValue += valorDigito * (int)Math.Pow(8, longitud - 1 - i);
            }

            return decimalValue;
        }

        // Método para convertir un número octal a binario
        public string OctalABinario()
        {
            int decimalValue = OctalADecimal();
            return new ConversorDecimal(decimalValue).DecimalABinario();
        }

        // Método para convertir un número octal a hexadecimal
        public string OctalAHexadecimal()
        {
            int decimalValue = OctalADecimal();
            return new ConversorDecimal(decimalValue).DecimalAHexadecimal();
        }

        // Método para obtener el número octal actual
        public string GetOctal()
        {
            return octal;
        }

        // Método para establecer el número octal
        public void SetOctal(string octal)
        {
            this.octal = octal;
        }
    }
}

