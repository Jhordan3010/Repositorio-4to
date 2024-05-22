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
            this.btnOctal.Location = new System.Drawing.Point(250, 77);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(75, 23);
            this.btnOctal.TabIndex = 1;
            this.btnOctal.Text = "Octal";
            this.btnOctal.UseVisualStyleBackColor = true;
            this.btnOctal.Click += new System.EventHandler(this.btnOctal_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnDecima);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDecima;
        private System.Windows.Forms.Button btnOctal;
    }
}