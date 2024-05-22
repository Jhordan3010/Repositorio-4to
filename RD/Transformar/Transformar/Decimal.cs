using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformar
{
    internal class Decimal
    {
        
        
            public string ConvertToBinary(int decimalNumber)
            {
                if (decimalNumber == 0) return "0";
                string binary = "";
                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % 2;
                    binary = remainder + binary;
                    decimalNumber /= 2;
                }
                return binary;
            }

            public string ConvertToOctal(int decimalNumber)
            {
                if (decimalNumber == 0) return "0";
                string octal = "";
                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % 8;
                    octal = remainder + octal;
                    decimalNumber /= 8;
                }
                return octal;
            }

            public string ConvertToHexadecimal(int decimalNumber)
            {
                if (decimalNumber == 0) return "0";
                string hexadecimal = "";
                string hexCharacters = "0123456789ABCDEF";
                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % 16;
                    hexadecimal = hexCharacters[remainder] + hexadecimal;
                    decimalNumber /= 16;
                }
                return hexadecimal;
            }
        

    }
}
