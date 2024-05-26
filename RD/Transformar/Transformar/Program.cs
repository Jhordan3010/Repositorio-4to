using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Ingrese un número decimal:");
            //    int decimalNumber = int.Parse(Console.ReadLine());

            //    Decimal converter = new Decimal();

            //    string binary = converter.ConvertToBinary(decimalNumber);
            //    string octal = converter.ConvertToOctal(decimalNumber);
            //    string hexadecimal = converter.ConvertToHexadecimal(decimalNumber);

            //    Console.WriteLine($"Decimal: {decimalNumber}");
            //    Console.WriteLine($"Binario: {binary}");
            //    Console.WriteLine($"Octal: {octal}");
            //    Console.WriteLine($"Hexadecimal: {hexadecimal}");

            //    // Detalle del proceso de conversión para el ejemplo
            //    Console.WriteLine();
            //    Console.WriteLine("Ejemplo detallado de conversiones para el número ", decimalNumber, ":");

            //    Console.WriteLine("Decimal a Binario:");
            //    PrintConversionSteps(decimalNumber, 2);

            //    Console.WriteLine("Decimal a Octal:");
            //    PrintConversionSteps(decimalNumber, 8);

            //    Console.WriteLine("Decimal a Hexadecimal:");
            //    PrintConversionSteps(decimalNumber, 16, "0123456789ABCDEF");
            //}

            //static void PrintConversionSteps(int decimalNumber, int baseNum, string baseChars = "0123456789")
            //{
            //    int number = decimalNumber;
            //    string result = "";
            //    string steps = "";

            //    while (number > 0)
            //    {
            //        int remainder = number % baseNum;
            //        result = baseChars[remainder] + result;
            //        steps += $"{number} ÷ {baseNum} = {number / baseNum} residuo {baseChars[remainder]}\n";
            //        number /= baseNum;
            //    }

            //    Console.WriteLine(steps);
            //    Console.WriteLine($"Leyendo los residuos de abajo hacia arriba, {decimalNumber} en base {baseNum} es {result}.");
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Ingrese un número octal:");
            //string numeroOctal = Console.ReadLine();

            //Octal convertidor = new Octal();

            //try
            //{
            //    int decimalResult = convertidor.ConvertirADecimal(numeroOctal, out List<string> pasosDecimal);
            //    string binarioResult = convertidor.ConvertirABinario(numeroOctal, out List<string> pasosBinario);
            //    string hexadecimalResult = convertidor.ConvertirAHexadecimal(numeroOctal, out List<string> pasosHexadecimal);

            //    Console.WriteLine($"Decimal: {decimalResult}");
            //    Console.WriteLine($"Binario: {binarioResult}");
            //    Console.WriteLine($"Hexadecimal: {hexadecimalResult}");

            //    Console.WriteLine("Pasos de conversión a decimal:");
            //    foreach (string paso in pasosDecimal)
            //    {
            //        Console.WriteLine(paso);
            //    }

            //    Console.WriteLine("Pasos de conversión a binario:");
            //    foreach (string paso in pasosBinario)
            //    {
            //        Console.WriteLine(paso);
            //    }

            //    Console.WriteLine("Pasos de conversión a hexadecimal:");
            //    foreach (string paso in pasosHexadecimal)
            //    {
            //        Console.WriteLine(paso);
            //    }
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //    string numeroOctal = "25"; // Ingresa aquí el número octal que deseas convertir

            //    Octal convertidor = new Octal();

            //    try
            //    {
            //        int decimalResult = convertidor.ConvertirADecimal(numeroOctal, out List<string> pasosDecimal);
            //        string binarioResult = convertidor.ConvertirABinario(numeroOctal, out List<string> pasosBinario);
            //        string hexadecimalResult = convertidor.ConvertirAHexadecimal(numeroOctal, out List<string> pasosHexadecimal);

            //        Console.WriteLine($"Decimal: {decimalResult}");
            //        Console.WriteLine($"Binario: {binarioResult}");
            //        Console.WriteLine($"Hexadecimal: {hexadecimalResult}");

            //        Console.WriteLine("Pasos de conversión a decimal:");
            //        foreach (string paso in pasosDecimal)
            //        {
            //            Console.WriteLine(paso);
            //        }

            //        Console.WriteLine("Pasos de conversión a binario:");
            //        foreach (string paso in pasosBinario)
            //        {
            //            Console.WriteLine(paso);
            //        }

            //        Console.WriteLine("Pasos de conversión a hexadecimal:");
            //        foreach (string paso in pasosHexadecimal)
            //        {
            //            Console.WriteLine(paso);
            //        }
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }


            Console.WriteLine("Ingrese un número binario:");
            string numeroBinario = Console.ReadLine();

            Binario convertidor = new Binario();

            try
            {
                int decimalResult = convertidor.ConvertirADecimal(numeroBinario, out List<string> pasosDecimal);
                string octalResult = convertidor.ConvertirAOctal(numeroBinario, out List<string> pasosOctal);
                string hexadecimalResult = convertidor.ConvertirAHexadecimal(numeroBinario, out List<string> pasosHexadecimal);

                Console.WriteLine($"Decimal: {decimalResult}");
                Console.WriteLine($"Octal: {octalResult}");
                Console.WriteLine($"Hexadecimal: {hexadecimalResult}");

                Console.WriteLine("Pasos de conversión a decimal:");
                foreach (string paso in pasosDecimal)
                {
                    Console.WriteLine(paso);
                }

                Console.WriteLine("Pasos de conversión a octal:");
                foreach (string paso in pasosOctal)
                {
                    Console.WriteLine(paso);
                }

                Console.WriteLine("Pasos de conversión a hexadecimal:");
                foreach (string paso in pasosHexadecimal)
                {
                    Console.WriteLine(paso);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    
}
