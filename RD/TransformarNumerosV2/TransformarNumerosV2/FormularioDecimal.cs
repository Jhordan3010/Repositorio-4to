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
                string binary = converter.ConvertToBinary(decimalNumber);
                string octal = converter.ConvertToOctal(decimalNumber);
                string hexadecimal = converter.ConvertToHexadecimal(decimalNumber);

                lblBinarioResul.Text = $"Binario: {binary}";
                lblOctalResul.Text = $"Octal: {octal}";
                lblHexadecimalResul.Text = $"Hexadecimal: {hexadecimal}";

                string binarySteps = converter.PrintConversionSteps(decimalNumber, 2);
                string octalSteps = converter.PrintConversionSteps(decimalNumber, 8);
                string hexSteps = converter.PrintConversionSteps(decimalNumber, 16, "0123456789ABCDEF");

                lblPasos.Text = $"Pasos para Binario:{Environment.NewLine}{binarySteps}{Environment.NewLine}{Environment.NewLine}{octalSteps}{Environment.NewLine}{Environment.NewLine}{hexSteps}";
            
            }
            else
            {
                MessageBox.Show("Ingrese un número decimal válido.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
