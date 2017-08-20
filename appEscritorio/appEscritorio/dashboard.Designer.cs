namespace appEscritorio
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            this.Json = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Json
            // 
            this.Json.Location = new System.Drawing.Point(162, 56);
            this.Json.Name = "Json";
            this.Json.Size = new System.Drawing.Size(133, 23);
            this.Json.TabIndex = 0;
            this.Json.Text = "Cargar JSON";
            this.Json.UseVisualStyleBackColor = true;
            this.Json.Click += new System.EventHandler(this.button1_Click);
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(19, 12);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(75, 23);
            this.atras.TabIndex = 1;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(38, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(390, 208);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nodo:";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.Json);
            this.Name = "dashboard";
            this.Text = "Atras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Json;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}