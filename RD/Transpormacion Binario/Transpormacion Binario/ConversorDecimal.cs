using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpormacion_Binario
{
    internal class ConversorDecimal
    {
        private int _decimal; // Número decimal a convertir

        // Constructor que recibe un valor decimal
        public ConversorDecimal(int numero)
        {
            _decimal = numero;
        }

        // Constructor que recibe un número en formato string y lo convierte a decimal
        public ConversorDecimal(string numero)
        {
            if (!int.TryParse(numero, out _decimal))
            {
                throw new ArgumentException("No es un número decimal válido");
            }
        }

        // Método que verifica si una cadena es un número decimal
        public bool EsNumeroDecimal(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        // Método que convierte el número decimal a binario
        public string DecimalABinario()
        {
            return ConvertirABase(2);
        }

        // Método que convierte el número decimal a hexadecimal
        public string DecimalAHexadecimal()
        {
            return ConvertirABase(16);
        }

        // Método que convierte el número decimal a octal
        public string DecimalAOctal()
        {
            return ConvertirABase(8);
        }

        // Método privado para realizar la conversión a cualquier base
        private string ConvertirABase(int baseValue)
        {
            if (baseValue < 2 || baseValue > 16)
            {
                throw new ArgumentException("Base no soportada");
            }

            StringBuilder resultado = new StringBuilder();
            int numero = _decimal;

            // Realiza la conversión a la base especificada
            while (numero > 0)
            {
                int residuo = numero % baseValue;
                char digito = (residuo < 10) ? (char)('0' + residuo) : (char)('A' + residuo - 10);
                resultado.Insert(0, digito);
                numero /= baseValue;
            }

            // Agrega un 0 si el resultado es vacío
            if (resultado.Length == 0)
            {
                resultado.Append('0');
            }

            return resultado.ToString();
        }

        // Propiedad para obtener el valor decimal
        public int GetDecimal()
        {
            return _decimal;
        }

        // Propiedad para establecer el valor decimal
        public void SetDecimal(int numero)
        {
            _decimal = numero;
        }
    }
}
