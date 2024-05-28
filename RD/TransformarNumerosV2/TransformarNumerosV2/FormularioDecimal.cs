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
    public partial class FormularioDecimal : Form
    {
        private ConversorDecimal converter;
        public FormularioDecimal()
        {
            InitializeComponent();
            converter = new ConversorDecimal();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumeroDecimal.Text, out int decimalNumber))
            {
                string numeroDecimal = txtNumeroDecimal.Text;
                ConversorHexadecimal convertidor = new ConversorHexadecimal();

                string octal = converter.ConvertToOctal(decimalNumber);
                

                
                lblOctalResul.Text = $"Octal: {octal}";
                
                string DecimalResult = convertidor.ConvertirABinario(numeroDecimal, out List<string> pasosOctal);


                


                lblPasos.Text += string.Join("\r\n", pasosOctal);
            }
            
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            string numeroDecimal = txtNumeroDecimal.Text;
            ConversorHexadecimal convertidor = new ConversorHexadecimal();
            string DecimalResult = convertidor.ConvertirABinario(numeroDecimal, out List<string> pasosBinario);
            lblBinarioResul.Text = $"Binario: {DecimalResult}";
            lblPasos.Text += string.Join("\r\n", pasosBinario);
        }

        private void btnHexadecimal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumeroDecimal.Text, out int decimalNumber))
            {
                string hexadecimal = converter.ConvertToHexadecimal(decimalNumber);
                lblHexadecimalResul.Text = $"Hexadecimal: {hexadecimal}";
                string hexSteps = converter.PrintConversionSteps(decimalNumber, 16, "0123456789ABCDEF");


                
            }
        }
    }
}
