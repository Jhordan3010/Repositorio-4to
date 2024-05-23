namespace TransformarNumerosV2
{
    partial class FormularioHexadecimal
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
            this.lblPasos = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtNumeroHexadecimal = new System.Windows.Forms.TextBox();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.lblOctal = new System.Windows.Forms.Label();
            this.lblBinario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Location = new System.Drawing.Point(13, 161);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(46, 16);
            this.lblPasos.TabIndex = 12;
            this.lblPasos.Text = "Pasos";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(170, 10);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(100, 28);
            this.btnConvertir.TabIndex = 11;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtNumeroHexadecimal
            // 
            this.txtNumeroHexadecimal.Location = new System.Drawing.Point(13, 13);
            this.txtNumeroHexadecimal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroHexadecimal.Name = "txtNumeroHexadecimal";
            this.txtNumeroHexadecimal.Size = new System.Drawing.Size(132, 22);
            this.txtNumeroHexadecimal.TabIndex = 7;
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(13, 53);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(0, 16);
            this.lblDecimal.TabIndex = 13;
            // 
            // lblOctal
            // 
            this.lblOctal.AutoSize = true;
            this.lblOctal.Location = new System.Drawing.Point(13, 84);
            this.lblOctal.Name = "lblOctal";
            this.lblOctal.Size = new System.Drawing.Size(0, 16);
            this.lblOctal.TabIndex = 14;
            // 
            // lblBinario
            // 
            this.lblBinario.AutoSize = true;
            this.lblBinario.Location = new System.Drawing.Point(13, 121);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(0, 16);
            this.lblBinario.TabIndex = 15;
            // 
            // FormularioHexadecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 707);
            this.Controls.Add(this.lblBinario);
            this.Controls.Add(this.lblOctal);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtNumeroHexadecimal);
            this.Name = "FormularioHexadecimal";
            this.Text = "FormularioHexadecimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtNumeroHexadecimal;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Label lblOctal;
        private System.Windows.Forms.Label lblBinario;
    }
}