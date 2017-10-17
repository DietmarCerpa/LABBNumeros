namespace ServidorNumeros
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
            this.IPText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PuertoText = new System.Windows.Forms.TextBox();
            this.BotonConectar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // IPText
            // 
            this.IPText.Location = new System.Drawing.Point(35, 30);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(100, 20);
            this.IPText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Puerto";
            // 
            // PuertoText
            // 
            this.PuertoText.Location = new System.Drawing.Point(185, 30);
            this.PuertoText.Name = "PuertoText";
            this.PuertoText.Size = new System.Drawing.Size(100, 20);
            this.PuertoText.TabIndex = 1;
            // 
            // BotonConectar
            // 
            this.BotonConectar.Location = new System.Drawing.Point(291, 30);
            this.BotonConectar.Name = "BotonConectar";
            this.BotonConectar.Size = new System.Drawing.Size(100, 23);
            this.BotonConectar.TabIndex = 2;
            this.BotonConectar.Text = "Conectar";
            this.BotonConectar.UseVisualStyleBackColor = true;
            this.BotonConectar.Click += new System.EventHandler(this.BotonConectar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 290);
            this.listBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Recibidos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BotonConectar);
            this.Controls.Add(this.PuertoText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IPText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GUIServidor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PuertoText;
        private System.Windows.Forms.Button BotonConectar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}

