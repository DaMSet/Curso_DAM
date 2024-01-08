namespace David_Examen_DEINT_R
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLibroPorEditorial = new System.Windows.Forms.Button();
            this.btnLibroPorGenero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(128, 48);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(545, 165);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(545, 48);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(128, 165);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLibroPorEditorial
            // 
            this.btnLibroPorEditorial.Location = new System.Drawing.Point(545, 320);
            this.btnLibroPorEditorial.Name = "btnLibroPorEditorial";
            this.btnLibroPorEditorial.Size = new System.Drawing.Size(132, 23);
            this.btnLibroPorEditorial.TabIndex = 4;
            this.btnLibroPorEditorial.Text = "Consulta LXE";
            this.btnLibroPorEditorial.UseVisualStyleBackColor = true;
            this.btnLibroPorEditorial.Click += new System.EventHandler(this.btnLibroPorEditorial_Click);
            // 
            // btnLibroPorGenero
            // 
            this.btnLibroPorGenero.Location = new System.Drawing.Point(113, 320);
            this.btnLibroPorGenero.Name = "btnLibroPorGenero";
            this.btnLibroPorGenero.Size = new System.Drawing.Size(132, 23);
            this.btnLibroPorGenero.TabIndex = 5;
            this.btnLibroPorGenero.Text = "Consulta LXG";
            this.btnLibroPorGenero.UseVisualStyleBackColor = true;
            this.btnLibroPorGenero.Click += new System.EventHandler(this.btnLibroPorGenero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLibroPorGenero);
            this.Controls.Add(this.btnLibroPorEditorial);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLibroPorEditorial;
        private System.Windows.Forms.Button btnLibroPorGenero;
    }
}

