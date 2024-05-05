namespace Transpormacion_Binario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnNumeroOctal = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnHexadecimal = new System.Windows.Forms.Button();
            this.txtImprimirResultadoOctal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textTitulo
            // 
            this.textTitulo.AutoSize = true;
            this.textTitulo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textTitulo.Location = new System.Drawing.Point(201, 9);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(152, 16);
            this.textTitulo.TabIndex = 0;
            this.textTitulo.Text = "Conversión de Números";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Octal";
            // 
            // txtnNumeroOctal
            // 
            this.txtnNumeroOctal.Location = new System.Drawing.Point(159, 108);
            this.txtnNumeroOctal.Name = "txtnNumeroOctal";
            this.txtnNumeroOctal.Size = new System.Drawing.Size(214, 22);
            this.txtnNumeroOctal.TabIndex = 11;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(245, 163);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(99, 195);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnDecimal.TabIndex = 13;
            this.btnDecimal.Text = "Decimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(346, 195);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(75, 23);
            this.btnBinario.TabIndex = 14;
            this.btnBinario.Text = "Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            // 
            // btnHexadecimal
            // 
            this.btnHexadecimal.Location = new System.Drawing.Point(224, 250);
            this.btnHexadecimal.Name = "btnHexadecimal";
            this.btnHexadecimal.Size = new System.Drawing.Size(96, 23);
            this.btnHexadecimal.TabIndex = 15;
            this.btnHexadecimal.Text = "Hexadecimal";
            this.btnHexadecimal.UseVisualStyleBackColor = true;
            // 
            // txtImprimirResultadoOctal
            // 
            this.txtImprimirResultadoOctal.Location = new System.Drawing.Point(139, 350);
            this.txtImprimirResultadoOctal.Name = "txtImprimirResultadoOctal";
            this.txtImprimirResultadoOctal.Size = new System.Drawing.Size(247, 22);
            this.txtImprimirResultadoOctal.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.txtImprimirResultadoOctal);
            this.Controls.Add(this.btnHexadecimal);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtnNumeroOctal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnNumeroOctal;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnHexadecimal;
        private System.Windows.Forms.TextBox txtImprimirResultadoOctal;
    }
}

