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
            this.btnBinario = new System.Windows.Forms.Button();
            this.lblDecimalResul = new System.Windows.Forms.Label();
            this.lblBinarioResul = new System.Windows.Forms.Label();
            this.lblHexadecimalResul = new System.Windows.Forms.Label();
            this.txtNumeroOctal = new System.Windows.Forms.TextBox();
            this.lblPasos = new System.Windows.Forms.Label();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnHexadecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(155, 27);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(75, 23);
            this.btnBinario.TabIndex = 0;
            this.btnBinario.Text = "Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnConvertir_Click_1);
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
            this.txtNumeroOctal.Location = new System.Drawing.Point(12, 27);
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
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(254, 27);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnDecimal.TabIndex = 8;
            this.btnDecimal.Text = "Decimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnHexadecimal
            // 
            this.btnHexadecimal.Location = new System.Drawing.Point(356, 27);
            this.btnHexadecimal.Name = "btnHexadecimal";
            this.btnHexadecimal.Size = new System.Drawing.Size(75, 23);
            this.btnHexadecimal.TabIndex = 9;
            this.btnHexadecimal.Text = "Hexadecimal";
            this.btnHexadecimal.UseVisualStyleBackColor = true;
            // 
            // FormularioOctal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 702);
            this.Controls.Add(this.btnHexadecimal);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.txtNumeroOctal);
            this.Controls.Add(this.lblHexadecimalResul);
            this.Controls.Add(this.lblBinarioResul);
            this.Controls.Add(this.lblDecimalResul);
            this.Controls.Add(this.btnBinario);
            this.Name = "FormularioOctal";
            this.Text = "FormularioOctal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Label lblDecimalResul;
        private System.Windows.Forms.Label lblBinarioResul;
        private System.Windows.Forms.Label lblHexadecimalResul;
        private System.Windows.Forms.TextBox txtNumeroOctal;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnHexadecimal;
    }
}