namespace Laboratorio_12_2
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNota1 = new System.Windows.Forms.Label();
            this.lbNota2 = new System.Windows.Forms.Label();
            this.lbNota3 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbResultadoPromedio = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(351, 50);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(111, 16);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Nota Promedio";
            // 
            // lbNota1
            // 
            this.lbNota1.AutoSize = true;
            this.lbNota1.Location = new System.Drawing.Point(225, 99);
            this.lbNota1.Name = "lbNota1";
            this.lbNota1.Size = new System.Drawing.Size(76, 16);
            this.lbNota1.TabIndex = 1;
            this.lbNota1.Text = "NOTA No.1";
            // 
            // lbNota2
            // 
            this.lbNota2.AutoSize = true;
            this.lbNota2.Location = new System.Drawing.Point(225, 148);
            this.lbNota2.Name = "lbNota2";
            this.lbNota2.Size = new System.Drawing.Size(76, 16);
            this.lbNota2.TabIndex = 2;
            this.lbNota2.Text = "NOTA No.2";
            // 
            // lbNota3
            // 
            this.lbNota3.AutoSize = true;
            this.lbNota3.Location = new System.Drawing.Point(225, 199);
            this.lbNota3.Name = "lbNota3";
            this.lbNota3.Size = new System.Drawing.Size(76, 16);
            this.lbNota3.TabIndex = 3;
            this.lbNota3.Text = "NOTA No.3";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(354, 99);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 22);
            this.txtNota1.TabIndex = 4;
            this.txtNota1.TextChanged += new System.EventHandler(this.txtNota1_TextChanged);
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(354, 148);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 22);
            this.txtNota2.TabIndex = 5;
            this.txtNota2.TextChanged += new System.EventHandler(this.txtNota2_TextChanged);
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(354, 199);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 22);
            this.txtNota3.TabIndex = 6;
            this.txtNota3.TextChanged += new System.EventHandler(this.txtNota3_TextChanged);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(201, 253);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(83, 23);
            this.btnPromedio.TabIndex = 7;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(320, 254);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(446, 253);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbResultadoPromedio
            // 
            this.lbResultadoPromedio.AutoSize = true;
            this.lbResultadoPromedio.Location = new System.Drawing.Point(228, 308);
            this.lbResultadoPromedio.Name = "lbResultadoPromedio";
            this.lbResultadoPromedio.Size = new System.Drawing.Size(98, 16);
            this.lbResultadoPromedio.TabIndex = 10;
            this.lbResultadoPromedio.Text = "Nota Promedio";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(354, 308);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 11;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lbResultadoPromedio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lbNota3);
            this.Controls.Add(this.lbNota2);
            this.Controls.Add(this.lbNota1);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Calcular Promedio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNota1;
        private System.Windows.Forms.Label lbNota2;
        private System.Windows.Forms.Label lbNota3;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbResultadoPromedio;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

