namespace Transpormacion_Binario
{
    partial class FormularioOctal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngrsar = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnHexadecimal = new System.Windows.Forms.Button();
            this.txtNumeroOctal = new System.Windows.Forms.TextBox();
            this.txtImprimirResultadoOctal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIngrsar
            // 
            this.btnIngrsar.Location = new System.Drawing.Point(178, 158);
            this.btnIngrsar.Name = "btnIngrsar";
            this.btnIngrsar.Size = new System.Drawing.Size(75, 23);
            this.btnIngrsar.TabIndex = 0;
            this.btnIngrsar.Text = "Ingresar";
            this.btnIngrsar.UseVisualStyleBackColor = true;
            this.btnIngrsar.Click += new System.EventHandler(this.btnIngrsar_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(92, 216);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnDecimal.TabIndex = 1;
            this.btnDecimal.Text = "Decimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(289, 216);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(75, 23);
            this.btnBinario.TabIndex = 2;
            this.btnBinario.Text = "Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // btnHexadecimal
            // 
            this.btnHexadecimal.Location = new System.Drawing.Point(167, 277);
            this.btnHexadecimal.Name = "btnHexadecimal";
            this.btnHexadecimal.Size = new System.Drawing.Size(99, 23);
            this.btnHexadecimal.TabIndex = 3;
            this.btnHexadecimal.Text = "Hexadecimal";
            this.btnHexadecimal.UseVisualStyleBackColor = true;
            this.btnHexadecimal.Click += new System.EventHandler(this.btnHexadecimal_Click);
            // 
            // txtNumeroOctal
            // 
            this.txtNumeroOctal.Location = new System.Drawing.Point(124, 103);
            this.txtNumeroOctal.Name = "txtNumeroOctal";
            this.txtNumeroOctal.Size = new System.Drawing.Size(184, 22);
            this.txtNumeroOctal.TabIndex = 4;
            // 
            // txtImprimirResultadoOctal
            // 
            this.txtImprimirResultadoOctal.Location = new System.Drawing.Point(124, 346);
            this.txtImprimirResultadoOctal.Name = "txtImprimirResultadoOctal";
            this.txtImprimirResultadoOctal.Size = new System.Drawing.Size(184, 22);
            this.txtImprimirResultadoOctal.TabIndex = 5;
            // 
            // FormularioOctal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.txtImprimirResultadoOctal);
            this.Controls.Add(this.txtNumeroOctal);
            this.Controls.Add(this.btnHexadecimal);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnIngrsar);
            this.Name = "FormularioOctal";
            this.Text = "FormularioOctal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngrsar;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnHexadecimal;
        private System.Windows.Forms.TextBox txtNumeroOctal;
        private System.Windows.Forms.TextBox txtImprimirResultadoOctal;
    }
}