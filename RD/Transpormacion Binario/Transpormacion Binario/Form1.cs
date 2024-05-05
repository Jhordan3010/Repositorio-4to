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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ConversorOctal cO;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string numeroOctal = txtnNumeroOctal.Text;
            cO = new ConversorOctal(numeroOctal);

            if (string.IsNullOrEmpty(numeroOctal))
            {
                txtImprimirResultadoOctal.Text = "Por favor, ingrese un número Octal";
                btnBinario.Enabled = false;
                btnDecimal.Enabled = false;
                btnHexadecimal.Enabled = false;

            }
            else if (cO.EsOctal(numeroOctal))
            {
                txtImprimirResultadoOctal.Text = "Número Octal Ingresado Correctamente";
                btnBinario.Enabled = true;
                btnDecimal.Enabled = true;
                btnHexadecimal.Enabled = true;
            }
            else
            {
                txtImprimirResultadoOctal.Text = "No es un número Octal válido";
                btnBinario.Enabled = false;
                btnDecimal.Enabled = false;
                btnHexadecimal.Enabled = false;
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            int resultadoDecimal = cO.OctalADecimal();
            txtImprimirResultadoOctal.Text = resultadoDecimal.ToString();
        }

    }
}
