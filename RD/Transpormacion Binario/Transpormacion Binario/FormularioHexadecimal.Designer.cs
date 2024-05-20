namespace Transpormacion_Binario
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
            this.txtImprimirResultadoHexadecimal = new System.Windows.Forms.TextBox();
            this.txtNumeroHexadecimal = new System.Windows.Forms.TextBox();
            this.btnOctalH = new System.Windows.Forms.Button();
            this.btnBinarioH = new System.Windows.Forms.Button();
            this.btnDecimalH = new System.Windows.Forms.Button();
            this.btnIngrsar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImprimirResultadoHexadecimal
            // 
            this.txtImprimirResultadoHexadecimal.Location = new System.Drawing.Point(87, 324);
            this.txtImprimirResultadoHexadecimal.Name = "txtImprimirResultadoHexadecimal";
            this.txtImprimirResultadoHexadecimal.Size = new System.Drawing.Size(184, 22);
            this.txtImprimirResultadoHexadecimal.TabIndex = 23;
            // 
            // txtNumeroHexadecimal
            // 
            this.txtNumeroHexadecimal.Location = new System.Drawing.Point(87, 81);
            this.txtNumeroHexadecimal.Name = "txtNumeroHexadecimal";
            this.txtNumeroHexadecimal.Size = new System.Drawing.Size(184, 22);
            this.txtNumeroHexadecimal.TabIndex = 22;
            // 
            // btnOctalH
            // 
            this.btnOctalH.Location = new System.Drawing.Point(130, 255);
            this.btnOctalH.Name = "btnOctalH";
            this.btnOctalH.Size = new System.Drawing.Size(99, 23);
            this.btnOctalH.TabIndex = 21;
            this.btnOctalH.Text = "Octal";
            this.btnOctalH.UseVisualStyleBackColor = true;
            this.btnOctalH.Click += new System.EventHandler(this.btnOctalH_Click);
            // 
            // btnBinarioH
            // 
            this.btnBinarioH.Location = new System.Drawing.Point(259, 194);
            this.btnBinarioH.Name = "btnBinarioH";
            this.btnBinarioH.Size = new System.Drawing.Size(118, 23);
            this.btnBinarioH.TabIndex = 20;
            this.btnBinarioH.Text = "Binario";
            this.btnBinarioH.UseVisualStyleBackColor = true;
            // 
            // btnDecimalH
            // 
            this.btnDecimalH.Location = new System.Drawing.Point(55, 194);
            this.btnDecimalH.Name = "btnDecimalH";
            this.btnDecimalH.Size = new System.Drawing.Size(75, 23);
            this.btnDecimalH.TabIndex = 19;
            this.btnDecimalH.Text = "Decimal";
            this.btnDecimalH.UseVisualStyleBackColor = true;
            this.btnDecimalH.Click += new System.EventHandler(this.btnDecimalH_Click);
            // 
            // btnIngrsar
            // 
            this.btnIngrsar.Location = new System.Drawing.Point(140, 132);
            this.btnIngrsar.Name = "btnIngrsar";
            this.btnIngrsar.Size = new System.Drawing.Size(75, 23);
            this.btnIngrsar.TabIndex = 18;
            this.btnIngrsar.Text = "Ingresar";
            this.btnIngrsar.UseVisualStyleBackColor = true;
            this.btnIngrsar.Click += new System.EventHandler(this.btnIngrsar_Click);
            // 
            // FormularioHexadecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.txtImprimirResultadoHexadecimal);
            this.Controls.Add(this.txtNumeroHexadecimal);
            this.Controls.Add(this.btnOctalH);
            this.Controls.Add(this.btnBinarioH);
            this.Controls.Add(this.btnDecimalH);
            this.Controls.Add(this.btnIngrsar);
            this.Name = "FormularioHexadecimal";
            this.Text = "FormularioHexadecimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImprimirResultadoHexadecimal;
        private System.Windows.Forms.TextBox txtNumeroHexadecimal;
        private System.Windows.Forms.Button btnOctalH;
        private System.Windows.Forms.Button btnBinarioH;
        private System.Windows.Forms.Button btnDecimalH;
        private System.Windows.Forms.Button btnIngrsar;
    }
}