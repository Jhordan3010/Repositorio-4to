using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpormacion_Binario
{
    internal class ConversorHexadecimal
    {
        private string hexadecimal;

        public ConversorHexadecimal(string hexadecimal)
        {
            this.hexadecimal = hexadecimal.ToUpper();
        }

        public bool EsHexadecimal(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c) && (c < 'A' || c > 'F'))
                {
                    return false;
                }
            }
            return true;
        }

        public int HexadecimalADecimal()
        {
            if (!EsHexadecimal(hexadecimal))
            {
                throw new ArgumentException("No es un número hexadecimal válido");
            }

            int decimalValue = 0;
            int length = hexadecimal.Length;

            for (int i = 0; i < length; i++)
            {
                char digit = hexadecimal[i];
                int digitValue = char.IsDigit(digit) ? (int)digit - '0' : (int)digit - 'A' + 10;
                decimalValue += digitValue * (int)Math.Pow(16, length - 1 - i);
            }

            return decimalValue;
        }

        public string HexadecimalABinario()
        {
            int decimalValue = HexadecimalADecimal();
            return new ConversorDecimal(decimalValue).DecimalABinario();
        }

        public string HexadecimalAOctal()
        {
            int decimalValue = HexadecimalADecimal();
            return new ConversorDecimal(decimalValue).DecimalAOctal();
        }

        public string GetHexadecimal()
        {
            return hexadecimal;
        }

        public void SetHexadecimal(string hexadecimal)
        {
            this.hexadecimal = hexadecimal.ToUpper();
        }
    }
}
