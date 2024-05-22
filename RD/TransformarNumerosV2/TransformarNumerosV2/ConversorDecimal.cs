using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformarNumerosV2
{
    internal class ConversorDecimal
    {
        public string ConvertToBinary(int decimalNumber)
        {
            return ConvertToBase(decimalNumber, 2);
        }

        public string ConvertToOctal(int decimalNumber)
        {
            return ConvertToBase(decimalNumber, 8);
        }

        public string ConvertToHexadecimal(int decimalNumber)
        {
            return ConvertToBase(decimalNumber, 16, "0123456789ABCDEF");
        }

        private string ConvertToBase(int decimalNumber, int baseNum, string baseChars = "0123456789")
        {
            if (decimalNumber == 0) return "0";
            string result = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % baseNum;
                result = baseChars[remainder] + result;
                decimalNumber /= baseNum;
            }
            return result;
        }

        public string PrintConversionSteps(int decimalNumber, int baseNum, string baseChars = "0123456789")
        {
            int number = decimalNumber;
            string result = "";
            string steps = "";

            while (number > 0)
            {
                int remainder = number % baseNum;
                result = baseChars[remainder] + result;
                steps += $"{number} ÷ {baseNum} = {number / baseNum} residuo {baseChars[remainder]}\n";
                number /= baseNum;
            }

            steps += $"\nLeyendo los residuos de abajo hacia arriba, {decimalNumber} en base {baseNum} es {result}.\n";
            return steps;
        }
    }
}
