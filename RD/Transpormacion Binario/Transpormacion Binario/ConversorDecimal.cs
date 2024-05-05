using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpormacion_Binario
{
    internal class ConversorDecimal
    {
        private int decimalValue; // Valor decimal a convertir

        // Constructor que recibe un valor decimal
        public ConversorDecimal(int decimalValue)
        {
            this.decimalValue = decimalValue;
        }

        // Constructor que recibe un número en formato string y lo convierte a decimal
        public ConversorDecimal(string numero)
        {
            try
            {
                this.decimalValue = int.Parse(numero); // Convierte el número string a entero
            }
            catch (FormatException)
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

            // StringBuilder para construir el resultado de la conversión
            StringBuilder resultado = new StringBuilder();
            int numero = decimalValue;

            // Realiza la división sucesiva para convertir a la base deseada
            while (numero > 0)
            {
                int residuo = numero % baseValue;
                char digito = (residuo < 10) ? (char)('0' + residuo) : (char)('A' + residuo - 10);
                resultado.Insert(0, digito); // Inserta el dígito en la posición adecuada
                numero /= baseValue;
            }

            if (resultado.Length == 0)
            {
                resultado.Append('0'); // Añade '0' si el número es 0
            }

            return resultado.ToString();
        }

        // Propiedad para obtener el valor decimal
        public int GetDecimal()
        {
            return decimalValue;
        }

        // Propiedad para establecer el valor decimal
        public void SetDecimal(int decimalValue)
        {
            this.decimalValue = decimalValue;
        }
    }
}
