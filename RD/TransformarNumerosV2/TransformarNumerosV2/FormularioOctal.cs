using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformarNumerosV2
{
    public partial class FormularioOctal : Form
    {
        public FormularioOctal()
        {
            InitializeComponent();
        }

        

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            string numeroOctal = txtNumeroOctal.Text;
            ConversorOctal convertidor = new ConversorOctal();

            try
            {
                // Convertir a decimal y obtener los pasos
                int decimalResult = convertidor.ConvertirADecimal(numeroOctal, out List<string> pasosDecimal);
                string binarioResult = convertidor.ConvertirABinario(numeroOctal, out List<string> pasosBinario);
                string hexadecimalResult = convertidor.ConvertirAHexadecimal(numeroOctal, out List<string> pasosHexadecimal);

                // Mostrar resultados en los labels
                lblDecimalResul.Text = $"Decimal: {decimalResult}";
                lblBinarioResul.Text = $"Binario: {binarioResult}";
                lblHexadecimalResul.Text = $"Hexadecimal: {hexadecimalResult}";

                // Mostrar pasos en un TextBox
                MostrarPasos(pasosDecimal, pasosBinario, pasosHexadecimal);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarPasos(List<string> pasosDecimal, List<string> pasosBinario, List<string> pasosHexadecimal)
        {
            // Construir el texto con los pasos
            string textoPasos = "Pasos de conversión a decimal:\n";
            foreach (string paso in pasosDecimal)
            {
                textoPasos += paso + "\n";
                
            }

            textoPasos += "\nPasos de conversión a binario:\n";
            foreach (string paso in pasosBinario)
            {
                textoPasos += paso + "\n";
                
            }

            textoPasos += "\nPasos de conversión a hexadecimal:\n";
            foreach (string paso in pasosHexadecimal)
            {
                textoPasos += paso + "\n";
                
            }

            // Mostrar los pasos en el TextBox
            lblPasos.Text = textoPasos;

        }
    }
}
