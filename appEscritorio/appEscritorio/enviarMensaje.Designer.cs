﻿namespace appEscritorio
{
    partial class enviarMensaje
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
            this.manual = new System.Windows.Forms.Button();
            this.carga = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // manual
            // 
            this.manual.Location = new System.Drawing.Point(45, 49);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(124, 23);
            this.manual.TabIndex = 0;
            this.manual.Text = "Enviar Manual";
            this.manual.UseVisualStyleBackColor = true;
            this.manual.Click += new System.EventHandler(this.manual_Click);
            // 
            // carga
            // 
            this.carga.Location = new System.Drawing.Point(186, 47);
            this.carga.Name = "carga";
            this.carga.Size = new System.Drawing.Size(137, 26);
            this.carga.TabIndex = 1;
            this.carga.Text = "Enviar Cargando";
            this.carga.UseVisualStyleBackColor = true;
            this.carga.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 290);
            this.textBox1.TabIndex = 2;
            // 
            // enviarMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 406);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.carga);
            this.Controls.Add(this.manual);
            this.Name = "enviarMensaje";
            this.Text = "enviarMensaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manual;
        private System.Windows.Forms.Button carga;
        private System.Windows.Forms.TextBox textBox1;
    }
}