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
    public partial class FormularioBinario : Form
    {
        public FormularioBinario()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string numeroBinario = txtNumeroBinario.Text;
            ConversosBinario convertidor = new ConversosBinario();         
            int decimalResult = convertidor.ConvertirADecimal(numeroBinario, out List<string> pasosDecimal);   
            lblResuladoDecimal.Text = $"Decimal: {decimalResult}";
            lblPasos.Text += string.Join("\r\n", pasosDecimal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroBinario = txtNumeroBinario.Text;
            ConversosBinario convertidor = new ConversosBinario();
            string octalResult = convertidor.ConvertirAOctal(numeroBinario, out List<string> pasosOctal);
            lblResuladoOctal.Text = $"Octal: {octalResult}";
            lblPasos.Text += string.Join("\r\n", pasosOctal);
        }

        private void btnHexadecimal_Click(object sender, EventArgs e)
        {
            string numeroBinario = txtNumeroBinario.Text;
            ConversosBinario convertidor = new ConversosBinario();
            string hexadecimalResult = convertidor.ConvertirAHexadecimal(numeroBinario, out List<string> pasosHexadecimal);
            lblResuladoHexadecimal.Text = $"Hexadecimal: {hexadecimalResult}";
            lblPasos.Text += string.Join("\r\n", pasosHexadecimal);
        }
    }
}
