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
    public partial class FormularioDecimal : Form
    {
        public FormularioDecimal()
        {
            InitializeComponent();
        }
        private ConversorDecimal cD;
        private void btnIngrsar_Click(object sender, EventArgs e)
        {
            string numeroDecimal = txtNumeroDecimal.Text;
            cD = new ConversorDecimal(numeroDecimal);

            if (string.IsNullOrEmpty(numeroDecimal))
            {
                txtImprimirResultadoDecimal.Text = "Por favor, ingrese un número Decimal";
                btnBinario.Enabled = false;
                btnOctal.Enabled = false;
                btnHexadecimal.Enabled = false;
            }
            else if (cD.EsNumeroDecimal(numeroDecimal))
            {
                txtImprimirResultadoDecimal.Text = "Número Decimal Ingresado Correctamente";
                btnBinario.Enabled = true;
                btnOctal.Enabled = true;
                btnHexadecimal.Enabled = true;
            }
            else
            {
                txtImprimirResultadoDecimal.Text = "No es un número decimal válido";
                btnBinario.Enabled = false;
                btnOctal.Enabled = false;
                btnHexadecimal.Enabled = false;
            }
        }
    }
}
