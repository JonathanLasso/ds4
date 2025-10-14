namespace Laboratorio_14
{
    partial class frmProductos
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
            this.tsbEliminar = new System.Windows.Forms.PictureBox();
            this.tsbCancelar = new System.Windows.Forms.PictureBox();
            this.tsbNuevo = new System.Windows.Forms.PictureBox();
            this.tsbGuardar = new System.Windows.Forms.PictureBox();
            this.tsbBuscar = new System.Windows.Forms.PictureBox();
            this.lbBuscarId = new System.Windows.Forms.Label();
            this.tstId = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tsbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::Laboratorio_14.Properties.Resources.eliminar;
            this.tsbEliminar.Location = new System.Drawing.Point(153, 9);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(34, 23);
            this.tsbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbEliminar.TabIndex = 4;
            this.tsbEliminar.TabStop = false;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = global::Laboratorio_14.Properties.Resources.cancelar;
            this.tsbCancelar.Location = new System.Drawing.Point(113, 9);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(34, 23);
            this.tsbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbCancelar.TabIndex = 3;
            this.tsbCancelar.TabStop = false;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::Laboratorio_14.Properties.Resources.nuevo;
            this.tsbNuevo.Location = new System.Drawing.Point(25, 9);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(38, 23);
            this.tsbNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbNuevo.TabIndex = 2;
            this.tsbNuevo.TabStop = false;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::Laboratorio_14.Properties.Resources.guardar;
            this.tsbGuardar.Location = new System.Drawing.Point(69, 9);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(38, 23);
            this.tsbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbGuardar.TabIndex = 1;
            this.tsbGuardar.TabStop = false;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = global::Laboratorio_14.Properties.Resources.buscar;
            this.tsbBuscar.InitialImage = null;
            this.tsbBuscar.Location = new System.Drawing.Point(403, 9);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(28, 23);
            this.tsbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbBuscar.TabIndex = 0;
            this.tsbBuscar.TabStop = false;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // lbBuscarId
            // 
            this.lbBuscarId.AutoSize = true;
            this.lbBuscarId.Location = new System.Drawing.Point(193, 12);
            this.lbBuscarId.Name = "lbBuscarId";
            this.lbBuscarId.Size = new System.Drawing.Size(89, 16);
            this.lbBuscarId.TabIndex = 5;
            this.lbBuscarId.Text = "Buscar por id:";
            this.lbBuscarId.Click += new System.EventHandler(this.lbBuscarId_Click);
            // 
            // tstId
            // 
            this.tstId.Location = new System.Drawing.Point(288, 10);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(100, 22);
            this.tstId.TabIndex = 6;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(242, 76);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 16);
            this.lbNombre.TabIndex = 7;
            this.lbNombre.Text = "Nombre";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(69, 175);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(46, 16);
            this.lbPrecio.TabIndex = 8;
            this.lbPrecio.Text = "Precio";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(69, 76);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 16);
            this.lbId.TabIndex = 9;
            this.lbId.Text = "Id";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(242, 175);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(41, 16);
            this.lbStock.TabIndex = 10;
            this.lbStock.Text = "Stock";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(69, 113);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(245, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(69, 215);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 13;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(245, 215);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 22);
            this.txtStock.TabIndex = 14;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(72, 290);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 39);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(245, 215);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 14;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.lbBuscarId);
            this.Controls.Add(this.tsbEliminar);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbNuevo);
            this.Controls.Add(this.tsbGuardar);
            this.Controls.Add(this.tsbBuscar);
            this.Name = "frmProductos";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tsbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tsbBuscar;
        private System.Windows.Forms.PictureBox tsbGuardar;
        private System.Windows.Forms.PictureBox tsbNuevo;
        private System.Windows.Forms.PictureBox tsbCancelar;
        private System.Windows.Forms.PictureBox tsbEliminar;
        private System.Windows.Forms.Label lbBuscarId;
        private System.Windows.Forms.TextBox tstId;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

