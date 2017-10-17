namespace GuiCajas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPServidor = new System.Windows.Forms.TextBox();
            this.PuertoServidor = new System.Windows.Forms.TextBox();
            this.BotonConectar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BotonEnviar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto Servidor";
            // 
            // IPServidor
            // 
            this.IPServidor.Location = new System.Drawing.Point(78, 10);
            this.IPServidor.Name = "IPServidor";
            this.IPServidor.Size = new System.Drawing.Size(100, 20);
            this.IPServidor.TabIndex = 2;
            // 
            // PuertoServidor
            // 
            this.PuertoServidor.Location = new System.Drawing.Point(285, 10);
            this.PuertoServidor.Name = "PuertoServidor";
            this.PuertoServidor.Size = new System.Drawing.Size(100, 20);
            this.PuertoServidor.TabIndex = 3;
            // 
            // BotonConectar
            // 
            this.BotonConectar.Location = new System.Drawing.Point(411, 8);
            this.BotonConectar.Name = "BotonConectar";
            this.BotonConectar.Size = new System.Drawing.Size(75, 23);
            this.BotonConectar.TabIndex = 4;
            this.BotonConectar.Text = "Conectar";
            this.BotonConectar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mensaje";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 20);
            this.textBox1.TabIndex = 6;
            // 
            // BotonEnviar
            // 
            this.BotonEnviar.Location = new System.Drawing.Point(462, 73);
            this.BotonEnviar.Name = "BotonEnviar";
            this.BotonEnviar.Size = new System.Drawing.Size(92, 22);
            this.BotonEnviar.TabIndex = 7;
            this.BotonEnviar.Text = "Enviar";
            this.BotonEnviar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(529, 95);
            this.listBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Historial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BotonEnviar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BotonConectar);
            this.Controls.Add(this.PuertoServidor);
            this.Controls.Add(this.IPServidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GUICajas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPServidor;
        private System.Windows.Forms.TextBox PuertoServidor;
        private System.Windows.Forms.Button BotonConectar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BotonEnviar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
    }
}

