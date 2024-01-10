namespace Jardineria
{
    partial class FormAgregarProducto
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmBoxGama = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDimensiones = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioProveedor = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDimensiones = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProveedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCantidadStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrecioVenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrecioProveedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCodigoProducto = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDimensiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCantidadStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecioProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(255, 377);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(401, 377);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dimensiones: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Proveedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Descripcion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cantidad en Stock:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Precio Venta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Precio Proveedor:";
            // 
            // cmBoxGama
            // 
            this.cmBoxGama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxGama.FormattingEnabled = true;
            this.cmBoxGama.Location = new System.Drawing.Point(184, 163);
            this.cmBoxGama.Name = "cmBoxGama";
            this.cmBoxGama.Size = new System.Drawing.Size(121, 21);
            this.cmBoxGama.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(184, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtDimensiones
            // 
            this.txtDimensiones.Location = new System.Drawing.Point(184, 230);
            this.txtDimensiones.Name = "txtDimensiones";
            this.txtDimensiones.Size = new System.Drawing.Size(100, 20);
            this.txtDimensiones.TabIndex = 13;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(184, 299);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtProveedor.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(545, 100);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 15;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Location = new System.Drawing.Point(545, 164);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadStock.TabIndex = 16;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(545, 230);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 17;
            // 
            // txtPrecioProveedor
            // 
            this.txtPrecioProveedor.Location = new System.Drawing.Point(545, 299);
            this.txtPrecioProveedor.Name = "txtPrecioProveedor";
            this.txtPrecioProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProveedor.TabIndex = 18;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(364, 43);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProducto.TabIndex = 19;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorDimensiones
            // 
            this.errorDimensiones.ContainerControl = this;
            // 
            // errorProveedor
            // 
            this.errorProveedor.ContainerControl = this;
            // 
            // errorDescripcion
            // 
            this.errorDescripcion.ContainerControl = this;
            // 
            // errorCantidadStock
            // 
            this.errorCantidadStock.ContainerControl = this;
            // 
            // errorPrecioVenta
            // 
            this.errorPrecioVenta.ContainerControl = this;
            // 
            // errorPrecioProveedor
            // 
            this.errorPrecioProveedor.ContainerControl = this;
            // 
            // errorCodigoProducto
            // 
            this.errorCodigoProducto.ContainerControl = this;
            // 
            // FormAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.txtPrecioProveedor);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtCantidadStock);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtDimensiones);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmBoxGama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FormAgregarProducto";
            this.Text = "FormAgregarProducto";
            this.Load += new System.EventHandler(this.FormAgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDimensiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCantidadStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecioProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmBoxGama;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDimensiones;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioProveedor;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorDimensiones;
        private System.Windows.Forms.ErrorProvider errorProveedor;
        private System.Windows.Forms.ErrorProvider errorDescripcion;
        private System.Windows.Forms.ErrorProvider errorCantidadStock;
        private System.Windows.Forms.ErrorProvider errorPrecioVenta;
        private System.Windows.Forms.ErrorProvider errorPrecioProveedor;
        private System.Windows.Forms.ErrorProvider errorCodigoProducto;
    }
}