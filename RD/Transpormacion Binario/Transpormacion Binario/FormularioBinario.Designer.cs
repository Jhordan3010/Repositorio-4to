namespace Transpormacion_Binario
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
            this.txtImprimirResultadoBinario = new System.Windows.Forms.TextBox();
            this.txtNumeroBinario = new System.Windows.Forms.TextBox();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnHexadecimal = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnIngrsar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImprimirResultadoBinario
            // 
            this.txtImprimirResultadoBinario.Location = new System.Drawing.Point(47, 370);
            this.txtImprimirResultadoBinario.Name = "txtImprimirResultadoBinario";
            this.txtImprimirResultadoBinario.Size = new System.Drawing.Size(184, 22);
            this.txtImprimirResultadoBinario.TabIndex = 17;
            // 
            // txtNumeroBinario
            // 
            this.txtNumeroBinario.Location = new System.Drawing.Point(47, 127);
            this.txtNumeroBinario.Name = "txtNumeroBinario";
            this.txtNumeroBinario.Size = new System.Drawing.Size(184, 22);
            this.txtNumeroBinario.TabIndex = 16;
            // 
            // btnOctal
            // 
            this.btnOctal.Location = new System.Drawing.Point(90, 301);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(99, 23);
            this.btnOctal.TabIndex = 15;
            this.btnOctal.Text = "Octal";
            this.btnOctal.UseVisualStyleBackColor = true;
            // 
            // btnHexadecimal
            // 
            this.btnHexadecimal.Location = new System.Drawing.Point(219, 240);
            this.btnHexadecimal.Name = "btnHexadecimal";
            this.btnHexadecimal.Size = new System.Drawing.Size(118, 23);
            this.btnHexadecimal.TabIndex = 14;
            this.btnHexadecimal.Text = "Hexadecimal";
            this.btnHexadecimal.UseVisualStyleBackColor = true;
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(15, 240);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(75, 23);
            this.btnBinario.TabIndex = 13;
            this.btnBinario.Text = "Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            // 
            // btnIngrsar
            // 
            this.btnIngrsar.Location = new System.Drawing.Point(101, 182);
            this.btnIngrsar.Name = "btnIngrsar";
            this.btnIngrsar.Size = new System.Drawing.Size(75, 23);
            this.btnIngrsar.TabIndex = 12;
            this.btnIngrsar.Text = "Ingresar";
            this.btnIngrsar.UseVisualStyleBackColor = true;
            // 
            // FormularioBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.txtImprimirResultadoBinario);
            this.Controls.Add(this.txtNumeroBinario);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnHexadecimal);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnIngrsar);
            this.Name = "FormularioBinario";
            this.Text = "FormularioBinario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImprimirResultadoBinario;
        private System.Windows.Forms.TextBox txtNumeroBinario;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnHexadecimal;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnIngrsar;
    }
}