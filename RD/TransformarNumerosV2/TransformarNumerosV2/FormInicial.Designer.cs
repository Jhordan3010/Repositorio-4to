using System;

namespace TransformarNumerosV2
{
    partial class FormInicial
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
        [STAThread]
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDecima = new System.Windows.Forms.Button();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnHexadecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDecima
            // 
            this.btnDecima.Location = new System.Drawing.Point(97, 57);
            this.btnDecima.Name = "btnDecima";
            this.btnDecima.Size = new System.Drawing.Size(75, 23);
            this.btnDecima.TabIndex = 0;
            this.btnDecima.Text = "Decimal";
            this.btnDecima.UseVisualStyleBackColor = true;
            this.btnDecima.Click += new System.EventHandler(this.btnDecima_Click);
            // 
            // btnOctal
            // 
            this.btnOctal.Location = new System.Drawing.Point(97, 104);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(75, 23);
            this.btnOctal.TabIndex = 1;
            this.btnOctal.Text = "Octal";
            this.btnOctal.UseVisualStyleBackColor = true;
            this.btnOctal.Click += new System.EventHandler(this.btnOctal_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(97, 142);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(75, 23);
            this.btnBinario.TabIndex = 2;
            this.btnBinario.Text = "Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // btnHexadecimal
            // 
            this.btnHexadecimal.Location = new System.Drawing.Point(97, 181);
            this.btnHexadecimal.Name = "btnHexadecimal";
            this.btnHexadecimal.Size = new System.Drawing.Size(93, 23);
            this.btnHexadecimal.TabIndex = 3;
            this.btnHexadecimal.Text = "Hexadecimal";
            this.btnHexadecimal.UseVisualStyleBackColor = true;
            this.btnHexadecimal.Click += new System.EventHandler(this.btnHexadecimal_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 263);
            this.Controls.Add(this.btnHexadecimal);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnDecima);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDecima;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnHexadecimal;
    }
}