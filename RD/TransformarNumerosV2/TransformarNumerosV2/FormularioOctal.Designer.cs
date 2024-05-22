namespace TransformarNumerosV2
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblDecimalResul = new System.Windows.Forms.Label();
            this.lblBinarioResul = new System.Windows.Forms.Label();
            this.lblHexadecimalResul = new System.Windows.Forms.Label();
            this.txtNumeroOctal = new System.Windows.Forms.TextBox();
            this.lblPasos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(279, 60);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click_1);
            // 
            // lblDecimalResul
            // 
            this.lblDecimalResul.AutoSize = true;
            this.lblDecimalResul.Location = new System.Drawing.Point(60, 104);
            this.lblDecimalResul.Name = "lblDecimalResul";
            this.lblDecimalResul.Size = new System.Drawing.Size(0, 16);
            this.lblDecimalResul.TabIndex = 1;
            // 
            // lblBinarioResul
            // 
            this.lblBinarioResul.AutoSize = true;
            this.lblBinarioResul.Location = new System.Drawing.Point(60, 151);
            this.lblBinarioResul.Name = "lblBinarioResul";
            this.lblBinarioResul.Size = new System.Drawing.Size(0, 16);
            this.lblBinarioResul.TabIndex = 2;
            // 
            // lblHexadecimalResul
            // 
            this.lblHexadecimalResul.AutoSize = true;
            this.lblHexadecimalResul.Location = new System.Drawing.Point(60, 207);
            this.lblHexadecimalResul.Name = "lblHexadecimalResul";
            this.lblHexadecimalResul.Size = new System.Drawing.Size(0, 16);
            this.lblHexadecimalResul.TabIndex = 3;
            // 
            // txtNumeroOctal
            // 
            this.txtNumeroOctal.Location = new System.Drawing.Point(78, 59);
            this.txtNumeroOctal.Name = "txtNumeroOctal";
            this.txtNumeroOctal.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroOctal.TabIndex = 4;
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Location = new System.Drawing.Point(60, 266);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(0, 16);
            this.lblPasos.TabIndex = 7;
            // 
            // FormularioOctal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 686);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.txtNumeroOctal);
            this.Controls.Add(this.lblHexadecimalResul);
            this.Controls.Add(this.lblBinarioResul);
            this.Controls.Add(this.lblDecimalResul);
            this.Controls.Add(this.btnConvertir);
            this.Name = "FormularioOctal";
            this.Text = "FormularioOctal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblDecimalResul;
        private System.Windows.Forms.Label lblBinarioResul;
        private System.Windows.Forms.Label lblHexadecimalResul;
        private System.Windows.Forms.TextBox txtNumeroOctal;
        private System.Windows.Forms.Label lblPasos;
    }
}