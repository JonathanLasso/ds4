namespace Laboratorio_12_3
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
            this.lbLongitudA = new System.Windows.Forms.Label();
            this.lbLongitudB = new System.Windows.Forms.Label();
            this.lbLongitudC = new System.Windows.Forms.Label();
            this.txtLongitudA = new System.Windows.Forms.TextBox();
            this.txtLongitudB = new System.Windows.Forms.TextBox();
            this.txtLongitudC = new System.Windows.Forms.TextBox();
            this.btnSemiPerimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.lbCalculoSemiPerimetro = new System.Windows.Forms.Label();
            this.txtCalculoSemiPerimetro = new System.Windows.Forms.TextBox();
            this.lbAreaTriangulo = new System.Windows.Forms.Label();
            this.txtAreaTriangulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbLongitudA
            // 
            this.lbLongitudA.AutoSize = true;
            this.lbLongitudA.Location = new System.Drawing.Point(72, 71);
            this.lbLongitudA.Name = "lbLongitudA";
            this.lbLongitudA.Size = new System.Drawing.Size(184, 16);
            this.lbLongitudA.TabIndex = 0;
            this.lbLongitudA.Text = "Ingresar la longitud del lado A";
            // 
            // lbLongitudB
            // 
            this.lbLongitudB.AutoSize = true;
            this.lbLongitudB.Location = new System.Drawing.Point(72, 126);
            this.lbLongitudB.Name = "lbLongitudB";
            this.lbLongitudB.Size = new System.Drawing.Size(184, 16);
            this.lbLongitudB.TabIndex = 1;
            this.lbLongitudB.Text = "Ingresar la longitud del lado B";
            // 
            // lbLongitudC
            // 
            this.lbLongitudC.AutoSize = true;
            this.lbLongitudC.Location = new System.Drawing.Point(72, 172);
            this.lbLongitudC.Name = "lbLongitudC";
            this.lbLongitudC.Size = new System.Drawing.Size(184, 16);
            this.lbLongitudC.TabIndex = 2;
            this.lbLongitudC.Text = "Ingresar la longitud del lado C";
            // 
            // txtLongitudA
            // 
            this.txtLongitudA.Location = new System.Drawing.Point(272, 68);
            this.txtLongitudA.Name = "txtLongitudA";
            this.txtLongitudA.Size = new System.Drawing.Size(100, 22);
            this.txtLongitudA.TabIndex = 3;
            this.txtLongitudA.TextChanged += new System.EventHandler(this.txtLongitudA_TextChanged);
            // 
            // txtLongitudB
            // 
            this.txtLongitudB.Location = new System.Drawing.Point(272, 126);
            this.txtLongitudB.Name = "txtLongitudB";
            this.txtLongitudB.Size = new System.Drawing.Size(100, 22);
            this.txtLongitudB.TabIndex = 4;
            this.txtLongitudB.TextChanged += new System.EventHandler(this.txtLongitudB_TextChanged);
            // 
            // txtLongitudC
            // 
            this.txtLongitudC.Location = new System.Drawing.Point(272, 172);
            this.txtLongitudC.Name = "txtLongitudC";
            this.txtLongitudC.Size = new System.Drawing.Size(100, 22);
            this.txtLongitudC.TabIndex = 5;
            this.txtLongitudC.TextChanged += new System.EventHandler(this.txtLongitudC_TextChanged);
            // 
            // btnSemiPerimetro
            // 
            this.btnSemiPerimetro.Location = new System.Drawing.Point(94, 234);
            this.btnSemiPerimetro.Name = "btnSemiPerimetro";
            this.btnSemiPerimetro.Size = new System.Drawing.Size(109, 23);
            this.btnSemiPerimetro.TabIndex = 6;
            this.btnSemiPerimetro.Text = "Semiperimetro";
            this.btnSemiPerimetro.UseVisualStyleBackColor = true;
            this.btnSemiPerimetro.Click += new System.EventHandler(this.btnSemiPerimetro_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(246, 234);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 7;
            this.btnArea.Text = "Área";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(374, 234);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(490, 233);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(75, 23);
            this.btnSalida.TabIndex = 9;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // lbCalculoSemiPerimetro
            // 
            this.lbCalculoSemiPerimetro.AutoSize = true;
            this.lbCalculoSemiPerimetro.Location = new System.Drawing.Point(109, 298);
            this.lbCalculoSemiPerimetro.Name = "lbCalculoSemiPerimetro";
            this.lbCalculoSemiPerimetro.Size = new System.Drawing.Size(147, 16);
            this.lbCalculoSemiPerimetro.TabIndex = 10;
            this.lbCalculoSemiPerimetro.Text = "Calcular Semiperimetro";
            // 
            // txtCalculoSemiPerimetro
            // 
            this.txtCalculoSemiPerimetro.Location = new System.Drawing.Point(272, 298);
            this.txtCalculoSemiPerimetro.Name = "txtCalculoSemiPerimetro";
            this.txtCalculoSemiPerimetro.Size = new System.Drawing.Size(100, 22);
            this.txtCalculoSemiPerimetro.TabIndex = 11;
            this.txtCalculoSemiPerimetro.TextChanged += new System.EventHandler(this.txtCalculoSemiPerimetro_TextChanged);
            // 
            // lbAreaTriangulo
            // 
            this.lbAreaTriangulo.AutoSize = true;
            this.lbAreaTriangulo.Location = new System.Drawing.Point(109, 338);
            this.lbAreaTriangulo.Name = "lbAreaTriangulo";
            this.lbAreaTriangulo.Size = new System.Drawing.Size(118, 16);
            this.lbAreaTriangulo.TabIndex = 12;
            this.lbAreaTriangulo.Text = "Área del Triángulo";
            this.lbAreaTriangulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAreaTriangulo
            // 
            this.txtAreaTriangulo.Location = new System.Drawing.Point(272, 338);
            this.txtAreaTriangulo.Name = "txtAreaTriangulo";
            this.txtAreaTriangulo.Size = new System.Drawing.Size(144, 22);
            this.txtAreaTriangulo.TabIndex = 13;
            this.txtAreaTriangulo.TextChanged += new System.EventHandler(this.txtAreaTriangulo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAreaTriangulo);
            this.Controls.Add(this.lbAreaTriangulo);
            this.Controls.Add(this.txtCalculoSemiPerimetro);
            this.Controls.Add(this.lbCalculoSemiPerimetro);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnSemiPerimetro);
            this.Controls.Add(this.txtLongitudC);
            this.Controls.Add(this.txtLongitudB);
            this.Controls.Add(this.txtLongitudA);
            this.Controls.Add(this.lbLongitudC);
            this.Controls.Add(this.lbLongitudB);
            this.Controls.Add(this.lbLongitudA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLongitudA;
        private System.Windows.Forms.Label lbLongitudB;
        private System.Windows.Forms.Label lbLongitudC;
        private System.Windows.Forms.TextBox txtLongitudA;
        private System.Windows.Forms.TextBox txtLongitudB;
        private System.Windows.Forms.TextBox txtLongitudC;
        private System.Windows.Forms.Button btnSemiPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Label lbCalculoSemiPerimetro;
        private System.Windows.Forms.TextBox txtCalculoSemiPerimetro;
        private System.Windows.Forms.Label lbAreaTriangulo;
        private System.Windows.Forms.TextBox txtAreaTriangulo;
    }
}

