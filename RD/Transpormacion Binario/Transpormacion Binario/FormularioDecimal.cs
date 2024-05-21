using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void btnBinario_Click(object sender, EventArgs e)
        {
            string numeroDecimal = txtNumeroDecimal.Text;
            string resultadoDecimal = cD.DecimalABinario(); // Utiliza el objeto cd en lugar de cD
            txtImprimirResultadoDecimal.Text = resultadoDecimal;
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            string numeroDecimal = txtNumeroDecimal.Text;
            string resultadoDecimal= cD.DecimalAOctal(); // Utiliza el objeto cd en lugar de cD
            txtImprimirResultadoDecimal.Text = resultadoDecimal;
        }

        private void btnHexadecimal_Click(object sender, EventArgs e)
        {
            string numeroDecimal = txtNumeroDecimal.Text;
            string resultadoDecimal = cD.DecimalAHexadecimal(); // Utiliza el objeto cd en lugar de cD
            txtImprimirResultadoDecimal.Text = resultadoDecimal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumeroDecimal.Text, out int decimalNumber) && int.TryParse(txtNumeroDecimal.Text, out int baseValue))
            {
                if (baseValue < 2 || baseValue > 16)
                {
                    MessageBox.Show("Base no soportada. Por favor ingrese un valor entre 2 y 16.");
                    return;
                }

                // Convertir el número y mostrar los pasos
                StringBuilder resultado = new StringBuilder();
                int numero = decimalNumber;
                int iteracion = 1; // Contador de iteraciones

                while (numero > 0)
                {
                    int residuo = numero % baseValue;
                    char digito = (residuo < 10) ? (char)('0' + residuo) : (char)('A' + residuo - 10);

                    textBox1.AppendText($"Iteración {iteracion}:\r\n");
                    textBox1.AppendText($"Número actual: {numero}\r\n");
                    textBox1.AppendText($"Residuo: {residuo} -> Dígito: {digito}\r\n");
                    textBox1.AppendText($"Número después de la división: {numero / baseValue}\r\n");
                    textBox1.AppendText("\r\n");

                    resultado.Insert(0, digito);
                    numero /= baseValue;
                    iteracion++;
                }

                if (resultado.Length == 0)
                {
                    resultado.Append('0');
                }

                // Mostrar el resultado final
                textBox1.AppendText($"Resultado final: {resultado.ToString()}\r\n");
            }
            else
            {
                MessageBox.Show("Por favor ingrese valores válidos para el número decimal y la base.");
            }
        }
    }
}
