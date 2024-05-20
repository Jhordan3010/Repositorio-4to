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
    public partial class FormularioHexadecimal : Form
    {
        public FormularioHexadecimal()
        {
            InitializeComponent();
        }
        ConversorHexadecimal ch;
        private void btnIngrsar_Click(object sender, EventArgs e)
        {
            string numeroHexadecimal = txtNumeroHexadecimal.Text;
            ConversorHexadecimal ch = new ConversorHexadecimal(numeroHexadecimal);

            if (string.IsNullOrEmpty(numeroHexadecimal))
            {
                txtImprimirResultadoHexadecimal.Text = "Por favor, ingrese un número hexadecimal";
                btnBinarioH.Enabled = false;
                btnDecimalH.Enabled = false;
                btnOctalH.Enabled = false;
            }
            else if (ch.EsHexadecimal(numeroHexadecimal))
            {
                txtImprimirResultadoHexadecimal.Text = "Número hexadecimal Ingresado Correctamente";
                btnBinarioH.Enabled = true;
                btnDecimalH.Enabled = true;
                btnOctalH.Enabled = true;
            }
            else
            {
                txtImprimirResultadoHexadecimal.Text = "No es un número hexadecimal válido";
                btnBinarioH.Enabled = false;
                btnDecimalH.Enabled = false;
                btnOctalH.Enabled = false;
            }
        }

        private void btnDecimalH_Click(object sender, EventArgs e)
        {
            int resultadoHexadecimal = ch.HexadecimalADecimal();
            txtImprimirResultadoHexadecimal.Text = resultadoHexadecimal.ToString();
            
        }

        private void btnOctalH_Click(object sender, EventArgs e)
        {
            String resultadoOctal = ch.HexadecimalAOctal();
            txtImprimirResultadoHexadecimal.Text += resultadoOctal.ToString();
        }
    }
}
