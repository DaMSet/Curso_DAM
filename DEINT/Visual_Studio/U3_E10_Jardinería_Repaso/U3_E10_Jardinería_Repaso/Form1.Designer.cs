namespace U3_E10_Jardinería_Repaso
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAñadir = new Button();
            btnBorrar = new Button();
            btnPedidosEntregados = new Button();
            btnEmpleadosJefe = new Button();
            btnClienteNoPaga = new Button();
            btnPrecioCaroBarato = new Button();
            SuspendLayout();
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(102, 81);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(75, 23);
            btnAñadir.TabIndex = 0;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(206, 81);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnPedidosEntregados
            // 
            btnPedidosEntregados.Location = new Point(102, 119);
            btnPedidosEntregados.Name = "btnPedidosEntregados";
            btnPedidosEntregados.Size = new Size(179, 23);
            btnPedidosEntregados.TabIndex = 2;
            btnPedidosEntregados.Text = "Consultar pedidos entregados";
            btnPedidosEntregados.UseVisualStyleBackColor = true;
            btnPedidosEntregados.Click += btnPedidosEntregados_Click;
            // 
            // btnEmpleadosJefe
            // 
            btnEmpleadosJefe.Location = new Point(102, 170);
            btnEmpleadosJefe.Name = "btnEmpleadosJefe";
            btnEmpleadosJefe.Size = new Size(253, 23);
            btnEmpleadosJefe.TabIndex = 3;
            btnEmpleadosJefe.Text = "Consultar empleados de un jefe determinado";
            btnEmpleadosJefe.UseVisualStyleBackColor = true;
            btnEmpleadosJefe.Click += btnEmpleadosJefe_Click;
            // 
            // btnClienteNoPaga
            // 
            btnClienteNoPaga.Location = new Point(102, 215);
            btnClienteNoPaga.Name = "btnClienteNoPaga";
            btnClienteNoPaga.Size = new Size(193, 23);
            btnClienteNoPaga.TabIndex = 4;
            btnClienteNoPaga.Text = "Consultar clientes que no pagan";
            btnClienteNoPaga.UseVisualStyleBackColor = true;
            btnClienteNoPaga.Click += btnClienteNoPaga_Click;
            // 
            // btnPrecioCaroBarato
            // 
            btnPrecioCaroBarato.Location = new Point(102, 260);
            btnPrecioCaroBarato.Name = "btnPrecioCaroBarato";
            btnPrecioCaroBarato.Size = new Size(308, 23);
            btnPrecioCaroBarato.TabIndex = 5;
            btnPrecioCaroBarato.Text = "Consultar el precio del producto más caro y más barato";
            btnPrecioCaroBarato.UseVisualStyleBackColor = true;
            btnPrecioCaroBarato.Click += btnPrecioCaroBarato_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrecioCaroBarato);
            Controls.Add(btnClienteNoPaga);
            Controls.Add(btnEmpleadosJefe);
            Controls.Add(btnPedidosEntregados);
            Controls.Add(btnBorrar);
            Controls.Add(btnAñadir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAñadir;
        private Button btnBorrar;
        private Button btnPedidosEntregados;
        private Button btnEmpleadosJefe;
        private Button btnClienteNoPaga;
        private Button btnPrecioCaroBarato;
    }
}