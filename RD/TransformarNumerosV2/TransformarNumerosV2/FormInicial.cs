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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnDecima_Click(object sender, EventArgs e)
        {
            FormularioDecimal fDecimal = new FormularioDecimal();
            fDecimal.Show();
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            FormularioOctal fOctal = new FormularioOctal();
            fOctal.Show();
        }
    }
}
