using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpormacion_Binario
{
    internal class ConversorHexadecimal
    {        
            private string _hexadecimal;

            public ConversorHexadecimal(string hexadecimal)
            {
                if (!EsHexadecimal(hexadecimal))
                {
                    throw new ArgumentException("Invalid hexadecimal string.");
                }

                _hexadecimal = hexadecimal.ToUpper(); // Convert to uppercase for consistent processing
            }

            public bool EsHexadecimal(string str)
            {
                foreach (char c in str)
                {
                    if (!char.IsDigit(c) && !(c >= 'A' && c <= 'F')) // Use inclusive range for valid hex characters
                    {
                        return false;
                    }
                }
                return true;
            }

            public string HexadecimalADecimal(string valorHexa) // Renamed for clarity
            {
                if (!EsHexadecimal(valorHexa))
                {
                    throw new ArgumentException("Invalid hexadecimal string.");
                }

                int decimalResult = 0;
                for (int i = 0; i < valorHexa.Length; i++)
                {
                    char hexDigit = valorHexa[valorHexa.Length - 1 - i]; // Process from right to left (most significant digit first)
                    int decimalValue;

                    if (char.IsDigit(hexDigit))
                    {
                        decimalValue = hexDigit - '0';
                    }
                    else
                    {
                        decimalValue = char.ToUpper(hexDigit) - 'A' + 10;
                    }

                    decimalResult += decimalValue * (int)Math.Pow(16, i);
                }
                return decimalResult.ToString();
            }

            public string HexadecimalABinario()
            {
                string decimalString = HexadecimalADecimal(_hexadecimal); // Use internal value for consistency
                int decimalValue = int.Parse(decimalString);
                return new ConversorDecimal(decimalValue).DecimalABinario(); // Assuming ConversorDecimal exists
            }

            public string HexadecimalAOctal()
            {
                string decimalString = HexadecimalADecimal(_hexadecimal); // Use internal value for consistency
                int decimalValue = int.Parse(decimalString);
                return new ConversorDecimal(decimalValue).DecimalAOctal(); // Assuming ConversorDecimal exists
            }

            public string GetHexadecimal()
            {
                return _hexadecimal;
            }
    }
}
