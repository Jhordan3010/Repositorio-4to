using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformarNumerosV2
{
    internal class ConversosBinario
    {
        public int ConvertirADecimal(string numeroBinario, out List<string> pasos)
        {
            pasos = new List<string>();

            if (!EsNumeroBinario(numeroBinario))
            {
                throw new ArgumentException("El número ingresado no es un número binario válido.");
            }

            int resultado = 0;
            for (int i = numeroBinario.Length - 1, j = 0; i >= 0; i--, j++)
            {
                int digito = int.Parse(numeroBinario[i].ToString());
                int producto = digito * (int)Math.Pow(2, j);
                resultado += producto;
                pasos.Add($"{digito} * 2^{j} = {producto}");
            }
            return resultado;
        }

        public string ConvertirAOctal(string numeroBinario, out List<string> pasos)
        {
            int decimalNumber = ConvertirADecimal(numeroBinario, out List<string> pasosDecimal);
            string resultado = ConvertirDecimalABase(decimalNumber, 8, out List<string> pasosOctal);

            pasos = new List<string>(pasosDecimal);
            pasos.Add("\nPasos de conversión a octal:");
            pasos.AddRange(pasosOctal);

            return resultado;
        }

        public string ConvertirAHexadecimal(string numeroBinario, out List<string> pasos)
        {
            int decimalNumber = ConvertirADecimal(numeroBinario, out List<string> pasosDecimal);
            string resultado = ConvertirDecimalABase(decimalNumber, 16, out List<string> pasosHexadecimal);

            pasos = new List<string>(pasosDecimal);
            pasos.Add("\nPasos de conversión a hexadecimal:");
            pasos.AddRange(pasosHexadecimal);

            return resultado;
        }

        private bool EsNumeroBinario(string numero)
        {
            foreach (char digito in numero)
            {
                if (digito != '0' && digito != '1')
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
            int originalDecimal = numeroDecimal;

            while (numeroDecimal > 0)
            {
                int residuo = numeroDecimal % baseNum;
                residuos.Add(residuo);
                pasos.Add($"{numeroDecimal} ÷ {baseNum} = {numeroDecimal / baseNum} residuo {residuo}");
                numeroDecimal /= baseNum;
            }

            residuos.Reverse();
            resultado = string.Join("", residuos);

            pasos.Add($"\nLeyendo los residuos de abajo hacia arriba, {originalDecimal} en base {baseNum} es {resultado}.\n");

            return resultado;
        }
    }
}
