using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformarNumerosV2
{
    internal class ConversorHexadecimal
    {
        public int ConvertirADecimal(string numeroHexadecimal, out List<string> pasos)
        {
            pasos = new List<string>();

            // Verificar si el número es válido
            if (!EsNumeroHexadecimal(numeroHexadecimal))
            {
                throw new ArgumentException("El número ingresado no es un número hexadecimal válido.");
            }

            int resultado = 0;
            numeroHexadecimal = numeroHexadecimal.ToUpper();
            for (int i = numeroHexadecimal.Length - 1, j = 0; i >= 0; i--, j++)
            {
                int digito = CharHexADecimal(numeroHexadecimal[i]);
                int producto = digito * (int)Math.Pow(16, j);
                resultado += producto;
                pasos.Add($"{digito} * 16^{j} = {producto}");
            }
            return resultado;
        }

        public string ConvertirAOctal(string numeroHexadecimal, out List<string> pasos)
        {
            int decimalNumber = ConvertirADecimal(numeroHexadecimal, out pasos);
            return ConvertirDecimalABase(decimalNumber, 8, out pasos);
        }

        public string ConvertirABinario(string numeroHexadecimal, out List<string> pasos)
        {
            int decimalNumber = ConvertirADecimal(numeroHexadecimal, out pasos);
            return ConvertirDecimalABase(decimalNumber, 2, out pasos);
        }

        private bool EsNumeroHexadecimal(string numero)
        {
            foreach (char digito in numero)
            {
                if (!((digito >= '0' && digito <= '9') || (digito >= 'A' && digito <= 'F') || (digito >= 'a' && digito <= 'f')))
                {
                    return false;
                }
            }
            return true;
        }

        private int CharHexADecimal(char c)
        {
            if (c >= '0' && c <= '9')
                return c - '0';
            else if (c >= 'A' && c <= 'F')
                return c - 'A' + 10;
            else
                return c - 'a' + 10;
        }

        private string ConvertirDecimalABase(int numeroDecimal, int baseNum, out List<string> pasos)
        {
            pasos = new List<string>();
            if (numeroDecimal == 0) return "0";
            string resultado = "";
            int originalNumero = numeroDecimal;
            while (numeroDecimal > 0)
            {
                int residuo = numeroDecimal % baseNum;
                resultado = residuo + resultado;
                pasos.Add($"{numeroDecimal} ÷ {baseNum} = {numeroDecimal / baseNum} residuo {residuo}");
                numeroDecimal /= baseNum;
            }
            pasos.Add($"\nLeyendo los residuos de abajo hacia arriba, {originalNumero} en base {baseNum} es {resultado}.\n");
            return resultado;
        }
    }
}
