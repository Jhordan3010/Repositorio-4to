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

            try
            {
                int decimalResult = convertidor.ConvertirADecimal(numeroBinario, out List<string> pasosDecimal);
                string octalResult = convertidor.ConvertirAOctal(numeroBinario, out List<string> pasosOctal);
                string hexadecimalResult = convertidor.ConvertirAHexadecimal(numeroBinario, out List<string> pasosHexadecimal);

                lblResuladoDecimal.Text = $"Decimal: {decimalResult}";
                lblResuladoOctal.Text = $"Octal: {octalResult}";
                lblResuladoHexadecimal.Text = $"Hexadecimal: {hexadecimalResult}";


                lblPasos.Text += string.Join("\r\n", pasosDecimal);

                lblPasos.Text += string.Join("\r\n", pasosOctal);

                lblPasos.Text += string.Join("\r\n", pasosHexadecimal);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
