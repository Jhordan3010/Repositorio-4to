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
                int decimalResult = convertidor.ConvertirADecimal(numeroHexadecimal, out List<string> pasosDecimal);
                string octalResult = convertidor.ConvertirAOctal(numeroHexadecimal, out List<string> pasosOctal);
                string binarioResult = convertidor.ConvertirABinario(numeroHexadecimal, out List<string> pasosBinario);

                lblDecimal.Text = $"Decimal: {decimalResult}";
                lblOctal.Text = $"Octal: {octalResult}";
                lblBinario.Text = $"Binario: {binarioResult}";

                lblPasos.Text += string.Join("\r\n", pasosDecimal);

                lblPasos.Text += string.Join("\r\n", pasosOctal);

                lblPasos.Text += string.Join("\r\n", pasosBinario);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
