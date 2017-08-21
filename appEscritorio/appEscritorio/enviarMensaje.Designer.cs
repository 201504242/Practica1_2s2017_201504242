namespace appEscritorio
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
            this.atras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.carga.Location = new System.Drawing.Point(216, 47);
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
            this.textBox1.Size = new System.Drawing.Size(348, 290);
            this.textBox1.TabIndex = 2;
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(21, 8);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(75, 23);
            this.atras.TabIndex = 3;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "enviar inorden miServer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enviarMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.atras);
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
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button button1;
    }
}