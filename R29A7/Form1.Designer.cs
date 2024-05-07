namespace R29A7
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
            this.labelEntrada = new System.Windows.Forms.Label();
            this.BotonEvaluar = new System.Windows.Forms.Button();
            this.TextBoxEntrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelEntrada
            // 
            this.labelEntrada.AutoSize = true;
            this.labelEntrada.Location = new System.Drawing.Point(25, 65);
            this.labelEntrada.Name = "labelEntrada";
            this.labelEntrada.Size = new System.Drawing.Size(47, 13);
            this.labelEntrada.TabIndex = 0;
            this.labelEntrada.Text = "Número:";
            // 
            // BotonEvaluar
            // 
            this.BotonEvaluar.Location = new System.Drawing.Point(243, 65);
            this.BotonEvaluar.Name = "BotonEvaluar";
            this.BotonEvaluar.Size = new System.Drawing.Size(75, 23);
            this.BotonEvaluar.TabIndex = 1;
            this.BotonEvaluar.Text = "Evaluar";
            this.BotonEvaluar.UseVisualStyleBackColor = true;
            this.BotonEvaluar.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // TextBoxEntrada
            // 
            this.TextBoxEntrada.Location = new System.Drawing.Point(89, 65);
            this.TextBoxEntrada.Name = "TextBoxEntrada";
            this.TextBoxEntrada.Size = new System.Drawing.Size(138, 20);
            this.TextBoxEntrada.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxEntrada);
            this.Controls.Add(this.BotonEvaluar);
            this.Controls.Add(this.labelEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEntrada;
        private System.Windows.Forms.Button BotonEvaluar;
        private System.Windows.Forms.TextBox TextBoxEntrada;
    }
}

