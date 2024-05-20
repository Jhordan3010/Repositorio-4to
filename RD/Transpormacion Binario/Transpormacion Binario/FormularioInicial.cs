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
    public partial class FormularioInicial : Form
    {
        public FormularioInicial()
        {
            InitializeComponent();
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FormularioOctal y mostrarlo
            FormularioOctal fOct = new FormularioOctal();
            fOct.Show();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            FormularioDecimal fDecimal = new FormularioDecimal();
            fDecimal.Show();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            FormularioBinario fBinario= new FormularioBinario();
            fBinario.Show();
        }

        private void btnHexadecimal_Click(object sender, EventArgs e)
        {
            FormularioHexadecimal fHex = new FormularioHexadecimal();
            fHex.Show();
        }
    }
}
