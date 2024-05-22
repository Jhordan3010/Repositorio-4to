namespace TransformarNumerosV2
{
    partial class FormularioDecimal
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
            this.txtNumeroDecimal = new System.Windows.Forms.TextBox();
            this.lblBinarioResul = new System.Windows.Forms.Label();
            this.lblOctalResul = new System.Windows.Forms.Label();
            this.lblHexadecimalResul = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblPasos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeroDecimal
            // 
            this.txtNumeroDecimal.Location = new System.Drawing.Point(16, 15);
            this.txtNumeroDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroDecimal.Name = "txtNumeroDecimal";
            this.txtNumeroDecimal.Size = new System.Drawing.Size(132, 22);
            this.txtNumeroDecimal.TabIndex = 0;
            // 
            // lblBinarioResul
            // 
            this.lblBinarioResul.AutoSize = true;
            this.lblBinarioResul.Location = new System.Drawing.Point(16, 55);
            this.lblBinarioResul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBinarioResul.Name = "lblBinarioResul";
            this.lblBinarioResul.Size = new System.Drawing.Size(0, 16);
            this.lblBinarioResul.TabIndex = 1;
            // 
            // lblOctalResul
            // 
            this.lblOctalResul.AutoSize = true;
            this.lblOctalResul.Location = new System.Drawing.Point(16, 92);
            this.lblOctalResul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOctalResul.Name = "lblOctalResul";
            this.lblOctalResul.Size = new System.Drawing.Size(0, 16);
            this.lblOctalResul.TabIndex = 2;
            // 
            // lblHexadecimalResul
            // 
            this.lblHexadecimalResul.AutoSize = true;
            this.lblHexadecimalResul.Location = new System.Drawing.Point(16, 129);
            this.lblHexadecimalResul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHexadecimalResul.Name = "lblHexadecimalResul";
            this.lblHexadecimalResul.Size = new System.Drawing.Size(0, 16);
            this.lblHexadecimalResul.TabIndex = 3;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(173, 12);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(100, 28);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Location = new System.Drawing.Point(16, 163);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(46, 16);
            this.lblPasos.TabIndex = 6;
            this.lblPasos.Text = "Pasos";
            // 
            // FormularioDecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 598);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblHexadecimalResul);
            this.Controls.Add(this.lblOctalResul);
            this.Controls.Add(this.lblBinarioResul);
            this.Controls.Add(this.txtNumeroDecimal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioDecimal";
            this.Text = "Conversor Decimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroDecimal;
        private System.Windows.Forms.Label lblBinarioResul;
        private System.Windows.Forms.Label lblOctalResul;
        private System.Windows.Forms.Label lblHexadecimalResul;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblPasos;
    }
}

