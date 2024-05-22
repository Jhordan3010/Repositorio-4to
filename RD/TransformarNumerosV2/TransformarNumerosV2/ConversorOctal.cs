using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformarNumerosV2
{
    internal class ConversorOctal
    {
        public int ConvertirADecimal(string numeroOctal, out List<string> pasos)
        {
            pasos = new List<string>();

            // Verificar si el número es válido
            if (!EsNumeroOctal(numeroOctal))
            {
                throw new ArgumentException("El número ingresado no es un número octal válido.");
            }

            int resultado = 0;
            for (int i = numeroOctal.Length - 1, j = 0; i >= 0; i--, j++)
            {
                int digito = int.Parse(numeroOctal[i].ToString());
                int producto = digito * (int)Math.Pow(8, j);
                resultado += producto;
                pasos.Add($"{digito} * 8^{j} = {producto}");
            }
            return resultado;
        }

        public string ConvertirABinario(string numeroOctal, out List<string> pasos)
        {
            int decimalNumber = ConvertirADecimal(numeroOctal, out pasos);
            return ConvertirDecimalABase(decimalNumber, 2, out pasos);
        }

        public string ConvertirAHexadecimal(string numeroOctal, out List<string> pasos)
        {
            int decimalNumber = ConvertirADecimal(numeroOctal, out pasos);
            return ConvertirDecimalABase(decimalNumber, 16, out pasos);
        }

        private bool EsNumeroOctal(string numero)
        {
            foreach (char digito in numero)
            {
                if (digito < '0' || digito > '7')
                {
                    return false;
                }
            }
            return true;
        }

        private string ConvertirDecimalABase(int numeroDecimal, int baseNum, out List<string> pasos)
        {
            pasos = new List<string>();
            if (numeroDecimal == 0)
            {
                pasos.Add("0");
                return "0";
            }

            string resultado = "";
            List<int> residuos = new List<int>();

            while (numeroDecimal > 0)
            {
                int residuo = numeroDecimal % baseNum;
                residuos.Add(residuo);
                pasos.Add($"{numeroDecimal} ÷ {baseNum} = {numeroDecimal / baseNum} residuo {residuo}");
                numeroDecimal /= baseNum;
            }

            residuos.Reverse();
            resultado = string.Join("", residuos);

            pasos.Add($"\nLeyendo los residuos de abajo hacia arriba, {numeroDecimal} en base {baseNum} es {resultado}.\n");

            return resultado;
        }
    }
}
