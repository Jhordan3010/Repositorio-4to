using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformar
{
    internal class Binario
    {
        public int ConvertirADecimal(string numeroBinario, out List<string> pasos)
        {
            pasos = new List<string>();

            // Verificar si el número es válido
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
            int decimalNumber = ConvertirADecimal(numeroBinario, out pasos);
            return ConvertirDecimalABase(decimalNumber, 8, out pasos);
        }

        public string ConvertirAHexadecimal(string numeroBinario, out List<string> pasos)
        {
            int decimalNumber = ConvertirADecimal(numeroBinario, out pasos);
            return ConvertirDecimalABase(decimalNumber, 16, out pasos);
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
            if (numeroDecimal == 0) return "0";
            string resultado = "";
            while (numeroDecimal > 0)
            {
                int residuo = numeroDecimal % baseNum;
                resultado = residuo + resultado;
                pasos.Add($"{numeroDecimal} ÷ {baseNum} = {numeroDecimal / baseNum} residuo {residuo}");
                numeroDecimal /= baseNum;
            }
            return resultado;
        }
       
    }
}
