namespace TransformarNumerosV2
{
    partial class FormularioBinario
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
            this.txtNumeroBinario = new System.Windows.Forms.TextBox();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.lblResuladoOctal = new System.Windows.Forms.Label();
            this.lblResuladoDecimal = new System.Windows.Forms.Label();
            this.lblResuladoHexadecimal = new System.Windows.Forms.Label();
            this.lblPasos = new System.Windows.Forms.Label();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnHexadecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroBinario
            // 
            this.txtNumeroBinario.Location = new System.Drawing.Point(64, 38);
            this.txtNumeroBinario.Name = "txtNumeroBinario";
            this.txtNumeroBinario.Size = new System.Drawing.Size(117, 22);
            this.txtNumeroBinario.TabIndex = 0;
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(216, 37);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnDecimal.TabIndex = 1;
            this.btnDecimal.Text = "Decimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResuladoOctal
            // 
            this.lblResuladoOctal.AutoSize = true;
            this.lblResuladoOctal.Location = new System.Drawing.Point(73, 91);
            this.lblResuladoOctal.Name = "lblResuladoOctal";
            this.lblResuladoOctal.Size = new System.Drawing.Size(0, 16);
            this.lblResuladoOctal.TabIndex = 2;
            // 
            // lblResuladoDecimal
            // 
            this.lblResuladoDecimal.AutoSize = true;
            this.lblResuladoDecimal.Location = new System.Drawing.Point(73, 136);
            this.lblResuladoDecimal.Name = "lblResuladoDecimal";
            this.lblResuladoDecimal.Size = new System.Drawing.Size(0, 16);
            this.lblResuladoDecimal.TabIndex = 3;
            // 
            // lblResuladoHexadecimal
            // 
            this.lblResuladoHexadecimal.AutoSize = true;
            this.lblResuladoHexadecimal.Location = new System.Drawing.Point(73, 178);
            this.lblResuladoHexadecimal.Name = "lblResuladoHexadecimal";
            this.lblResuladoHexadecimal.Size = new System.Drawing.Size(0, 16);
            this.lblResuladoHexadecimal.TabIndex = 4;
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Location = new System.Drawing.Point(73, 236);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(0, 16);
            this.lblPasos.TabIndex = 5;
            // 
            // btnOctal
            // 
            this.btnOctal.Location = new System.Drawing.Point(308, 38);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(75, 23);
            this.btnOctal.TabIndex = 6;
            this.btnOctal.Text = "Octal";
            this.btnOctal.UseVisualStyleBackColor = true;
            this.btnOctal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHexadecimal
            // 
            this.btnHexadecimal.Location = new System.Drawing.Point(399, 38);
            this.btnHexadecimal.Name = "btnHexadecimal";
            this.btnHexadecimal.Size = new System.Drawing.Size(75, 23);
            this.btnHexadecimal.TabIndex = 7;
            this.btnHexadecimal.Text = "Hexadecimal";
            this.btnHexadecimal.UseVisualStyleBackColor = true;
            this.btnHexadecimal.Click += new System.EventHandler(this.btnHexadecimal_Click);
            // 
            // FormularioBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 795);
            this.Controls.Add(this.btnHexadecimal);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.lblResuladoHexadecimal);
            this.Controls.Add(this.lblResuladoDecimal);
            this.Controls.Add(this.lblResuladoOctal);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.txtNumeroBinario);
            this.Name = "FormularioBinario";
            this.Text = "FormularioBinario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroBinario;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Label lblResuladoOctal;
        private System.Windows.Forms.Label lblResuladoDecimal;
        private System.Windows.Forms.Label lblResuladoHexadecimal;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnHexadecimal;
    }
}