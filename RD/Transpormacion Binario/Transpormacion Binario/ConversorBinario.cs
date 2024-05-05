using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpormacion_Binario
{
    internal class ConversorBinario
    {
        private string binario;

        // Constructor que recibe un número binario
        public ConversorBinario(string binario)
        {
            this.binario = binario;
        }

        // Método que verifica si una cadena es un número binario
        public bool EsBinario(string str)
        {
            foreach (char c in str)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        // Método que convierte el número binario a decimal
        public int BinarioADecimal(string binario)
        {
            if (!EsBinario(binario))
            {
                throw new ArgumentException("No es un número binario válido");
            }

            int decimalValue = 0;
            int longitud = binario.Length;

            for (int i = 0; i < longitud; i++)
            {
                char bit = binario[i];
                int valorBit = bit - '0'; // Convertir el carácter a un valor numérico 0 o 1
                decimalValue += valorBit * (int)Math.Pow(2, longitud - 1 - i);
            }

            return decimalValue;
        }

        // Método que convierte el número binario a octal
        public string BinarioAOctal(string binario)
        {
            int decimalValue = BinarioADecimal(binario);
            return DecimalAOctal(decimalValue);
        }

        // Método que convierte el número binario a hexadecimal
        public string BinarioAHexadecimal(string binario)
        {
            int decimalValue = BinarioADecimal(binario);
            return DecimalAHexadecimal(decimalValue);
        }

        // Método privado que convierte un número decimal a octal
        private string DecimalAOctal(int decimalValue)
        {
            StringBuilder octal = new StringBuilder();
            while (decimalValue > 0)
            {
                int residuo = decimalValue % 8;
                octal.Insert(0, residuo);
                decimalValue /= 8;
            }
            return octal.ToString();
        }

        // Método privado que convierte un número decimal a hexadecimal
        private string DecimalAHexadecimal(int decimalValue)
        {
            StringBuilder hexadecimal = new StringBuilder();
            while (decimalValue > 0)
            {
                int residuo = decimalValue % 16;
                char digitoHexadecimal = (residuo < 10) ? (char)('0' + residuo) : (char)('A' + residuo - 10);
                hexadecimal.Insert(0, digitoHexadecimal);
                decimalValue /= 16;
            }
            return hexadecimal.ToString();
        }

        // Propiedad para obtener el número binario
        public string GetBinario()
        {
            return binario;
        }

        // Propiedad para establecer el número binario
        public void SetBinario(string binario)
        {
            this.binario = binario;
        }
    }
}
