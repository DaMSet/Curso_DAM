namespace Jardineria
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarGama = new System.Windows.Forms.Button();
            this.btnConsultarPedido = new System.Windows.Forms.Button();
            this.btnConsultarEmpleado = new System.Windows.Forms.Button();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.btnConsultarPrecios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(151, 104);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(155, 33);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarGama
            // 
            this.btnEliminarGama.Location = new System.Drawing.Point(151, 202);
            this.btnEliminarGama.Name = "btnEliminarGama";
            this.btnEliminarGama.Size = new System.Drawing.Size(155, 33);
            this.btnEliminarGama.TabIndex = 1;
            this.btnEliminarGama.Text = "Eliminar Gama";
            this.btnEliminarGama.UseVisualStyleBackColor = true;
            this.btnEliminarGama.Click += new System.EventHandler(this.btnEliminarGama_Click);
            // 
            // btnConsultarPedido
            // 
            this.btnConsultarPedido.Location = new System.Drawing.Point(151, 294);
            this.btnConsultarPedido.Name = "btnConsultarPedido";
            this.btnConsultarPedido.Size = new System.Drawing.Size(155, 33);
            this.btnConsultarPedido.TabIndex = 2;
            this.btnConsultarPedido.Text = "Consultar Pedidos";
            this.btnConsultarPedido.UseVisualStyleBackColor = true;
            this.btnConsultarPedido.Click += new System.EventHandler(this.btnConsultarPedido_Click);
            // 
            // btnConsultarEmpleado
            // 
            this.btnConsultarEmpleado.Location = new System.Drawing.Point(470, 104);
            this.btnConsultarEmpleado.Name = "btnConsultarEmpleado";
            this.btnConsultarEmpleado.Size = new System.Drawing.Size(155, 33);
            this.btnConsultarEmpleado.TabIndex = 3;
            this.btnConsultarEmpleado.Text = "Consultar Empleados";
            this.btnConsultarEmpleado.UseVisualStyleBackColor = true;
            this.btnConsultarEmpleado.Click += new System.EventHandler(this.btnConsultarEmpleado_Click);
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.Location = new System.Drawing.Point(470, 202);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(155, 33);
            this.btnConsultarClientes.TabIndex = 4;
            this.btnConsultarClientes.Text = "Consultar Clientes";
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // btnConsultarPrecios
            // 
            this.btnConsultarPrecios.Location = new System.Drawing.Point(470, 294);
            this.btnConsultarPrecios.Name = "btnConsultarPrecios";
            this.btnConsultarPrecios.Size = new System.Drawing.Size(155, 33);
            this.btnConsultarPrecios.TabIndex = 5;
            this.btnConsultarPrecios.Text = "Consultar Precios";
            this.btnConsultarPrecios.UseVisualStyleBackColor = true;
            this.btnConsultarPrecios.Click += new System.EventHandler(this.btnConsultarPrecios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultarPrecios);
            this.Controls.Add(this.btnConsultarClientes);
            this.Controls.Add(this.btnConsultarEmpleado);
            this.Controls.Add(this.btnConsultarPedido);
            this.Controls.Add(this.btnEliminarGama);
            this.Controls.Add(this.btnAgregarProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarGama;
        private System.Windows.Forms.Button btnConsultarPedido;
        private System.Windows.Forms.Button btnConsultarEmpleado;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.Button btnConsultarPrecios;
    }
}

