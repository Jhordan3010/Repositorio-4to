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
    public partial class FormularioHexadecimal : Form
    {
        public FormularioHexadecimal()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string numeroHexadecimal = txtNumeroHexadecimal.Text;
            ConversorHexadecimal convertidor = new ConversorHexadecimal();

            try
            {
                
                
                string binarioResult = convertidor.ConvertirABinario(numeroHexadecimal, out List<string> pasosBinario);

                
                
                lblBinario.Text = $"Binario: {binarioResult}";

                

                

                lblPasos.Text += string.Join("\r\n", pasosBinario);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            string numeroHexadecimal = txtNumeroHexadecimal.Text;
            ConversorHexadecimal convertidor = new ConversorHexadecimal();

            string octalResult = convertidor.ConvertirAOctal(numeroHexadecimal, out List<string> pasosOctal);
            lblOctal.Text = $"Octal: {octalResult}";
            lblPasos.Text += string.Join("\r\n", pasosOctal);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            string numeroHexadecimal = txtNumeroHexadecimal.Text;
            ConversorHexadecimal convertidor = new ConversorHexadecimal();

            int decimalResult = convertidor.ConvertirADecimal(numeroHexadecimal, out List<string> pasosDecimal);
            lblDecimal.Text = $"Decimal: {decimalResult}";
            lblPasos.Text += string.Join("\r\n", pasosDecimal);
        }
    }
}
