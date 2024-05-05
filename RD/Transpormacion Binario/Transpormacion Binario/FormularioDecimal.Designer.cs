namespace Transpormacion_Binario
{
    partial class FormularioDecimal
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
            this.txtImprimirResultadoDecimal = new System.Windows.Forms.TextBox();
            this.txtNumeroDecimal = new System.Windows.Forms.TextBox();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnHexadecimal = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnIngrsar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImprimirResultadoDecimal
            // 
            this.txtImprimirResultadoDecimal.Location = new System.Drawing.Point(105, 338);
            this.txtImprimirResultadoDecimal.Name = "txtImprimirResultadoDecimal";
            this.txtImprimirResultadoDecimal.Size = new System.Drawing.Size(184, 22);
            this.txtImprimirResultadoDecimal.TabIndex = 11;
            // 
            // txtNumeroDecimal
            // 
            this.txtNumeroDecimal.Location = new System.Drawing.Point(105, 95);
            this.txtNumeroDecimal.Name = "txtNumeroDecimal";
            this.txtNumeroDecimal.Size = new System.Drawing.Size(184, 22);
            this.txtNumeroDecimal.TabIndex = 10;
            // 
            // btnOctal
            // 
            this.btnOctal.Location = new System.Drawing.Point(148, 269);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(99, 23);
            this.btnOctal.TabIndex = 9;
            this.btnOctal.Text = "Octal";
            this.btnOctal.UseVisualStyleBackColor = true;
            this.btnOctal.Click += new System.EventHandler(this.btnOctal_Click);
            // 
            // btnHexadecimal
            // 
            this.btnHexadecimal.Location = new System.Drawing.Point(277, 208);
            this.btnHexadecimal.Name = "btnHexadecimal";
            this.btnHexadecimal.Size = new System.Drawing.Size(88, 23);
            this.btnHexadecimal.TabIndex = 8;
            this.btnHexadecimal.Text = "Hexadecimal";
            this.btnHexadecimal.UseVisualStyleBackColor = true;
            this.btnHexadecimal.Click += new System.EventHandler(this.btnHexadecimal_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(73, 208);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(75, 23);
            this.btnBinario.TabIndex = 7;
            this.btnBinario.Text = "Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // btnIngrsar
            // 
            this.btnIngrsar.Location = new System.Drawing.Point(159, 150);
            this.btnIngrsar.Name = "btnIngrsar";
            this.btnIngrsar.Size = new System.Drawing.Size(75, 23);
            this.btnIngrsar.TabIndex = 6;
            this.btnIngrsar.Text = "Ingresar";
            this.btnIngrsar.UseVisualStyleBackColor = true;
            this.btnIngrsar.Click += new System.EventHandler(this.btnIngrsar_Click);
            // 
            // FormularioDecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.txtImprimirResultadoDecimal);
            this.Controls.Add(this.txtNumeroDecimal);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnHexadecimal);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnIngrsar);
            this.Name = "FormularioDecimal";
            this.Text = "FormularioDecimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImprimirResultadoDecimal;
        private System.Windows.Forms.TextBox txtNumeroDecimal;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnHexadecimal;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnIngrsar;
    }
}