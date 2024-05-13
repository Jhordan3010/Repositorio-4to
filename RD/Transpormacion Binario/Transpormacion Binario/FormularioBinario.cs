using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transpormacion_Binario
{
    public partial class FormularioBinario : Form
    {
        public FormularioBinario()
        {
            InitializeComponent();
        }
        private ConversorBinario cB;
        private void btnIngrsar_Click(object sender, EventArgs e)
        {
            string numeroBinario = txtNumeroBinario.Text;
            cB = new ConversorBinario (numeroBinario);

            if (string.IsNullOrEmpty(numeroBinario))
            {
                txtImprimirResultadoBinario.Text = "Por favor, ingrese un número Decimal";
                btnDecimalB.Enabled = false;
                btnOctal.Enabled = false;
                btnHexadecimal.Enabled = false;
            }
            else if (cB.EsBinario(numeroBinario))
            {
                txtImprimirResultadoBinario.Text = "Número Decimal Ingresado Correctamente";
                btnDecimalB.Enabled = true;
                btnOctal.Enabled = true;
                btnHexadecimal.Enabled = true;
            }
            else
            {
                txtImprimirResultadoBinario.Text = "No es un número decimal válido";
                btnDecimalB.Enabled = false;
                btnOctal.Enabled = false;
                btnHexadecimal.Enabled = false;
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            string numeroBinario = txtNumeroBinario.Text;
            ConversorBinario cb = new ConversorBinario(numeroBinario);
            int resultadoDecimal = cb.BinarioADecimal(numeroBinario);
            txtImprimirResultadoBinario.Text = resultadoDecimal.ToString();

        }

        private void btnHexadecimal_Click(object sender, EventArgs e)
        {
            string numeroBinario = txtNumeroBinario.Text;
            string resultadoHexadecimal = cB.BinarioAHexadecimal(numeroBinario);
            txtImprimirResultadoBinario.Text = resultadoHexadecimal;

        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            string numeroBinario = txtNumeroBinario.Text;
            string resultadoOctal = cB.BinarioAOctal(numeroBinario);
            txtImprimirResultadoBinario.Text = resultadoOctal;

        }
    }
}
