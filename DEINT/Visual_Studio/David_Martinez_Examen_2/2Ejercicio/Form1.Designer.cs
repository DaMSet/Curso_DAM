namespace _2Ejercicio
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
            btnAgregarRecurso = new Button();
            btnModificarRecurso = new Button();
            btnVerRecursos = new Button();
            btnAgregarMantenimiento = new Button();
            btnVerMantenimiento = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnAgregarRecurso
            // 
            btnAgregarRecurso.Location = new Point(48, 59);
            btnAgregarRecurso.Name = "btnAgregarRecurso";
            btnAgregarRecurso.Size = new Size(126, 48);
            btnAgregarRecurso.TabIndex = 0;
            btnAgregarRecurso.Text = "Agregar Recurso";
            btnAgregarRecurso.UseVisualStyleBackColor = true;
            btnAgregarRecurso.Click += btnAgregarRecurso_Click;
            // 
            // btnModificarRecurso
            // 
            btnModificarRecurso.Location = new Point(273, 59);
            btnModificarRecurso.Name = "btnModificarRecurso";
            btnModificarRecurso.Size = new Size(126, 48);
            btnModificarRecurso.TabIndex = 1;
            btnModificarRecurso.Text = "modificar Recurso";
            btnModificarRecurso.UseVisualStyleBackColor = true;
            btnModificarRecurso.Click += btnModificarRecurso_Click;
            // 
            // btnVerRecursos
            // 
            btnVerRecursos.Location = new Point(530, 59);
            btnVerRecursos.Name = "btnVerRecursos";
            btnVerRecursos.Size = new Size(126, 48);
            btnVerRecursos.TabIndex = 2;
            btnVerRecursos.Text = "Ver Recursos";
            btnVerRecursos.UseVisualStyleBackColor = true;
            btnVerRecursos.Click += btnVerRecursos_Click;
            // 
            // btnAgregarMantenimiento
            // 
            btnAgregarMantenimiento.Location = new Point(48, 212);
            btnAgregarMantenimiento.Name = "btnAgregarMantenimiento";
            btnAgregarMantenimiento.Size = new Size(126, 48);
            btnAgregarMantenimiento.TabIndex = 3;
            btnAgregarMantenimiento.Text = "Agregar Mantenimento";
            btnAgregarMantenimiento.UseVisualStyleBackColor = true;
            btnAgregarMantenimiento.Click += btnAgregarMantenimiento_Click;
            // 
            // btnVerMantenimiento
            // 
            btnVerMantenimiento.Location = new Point(273, 212);
            btnVerMantenimiento.Name = "btnVerMantenimiento";
            btnVerMantenimiento.Size = new Size(126, 48);
            btnVerMantenimiento.TabIndex = 4;
            btnVerMantenimiento.Text = "Ver Mantenimento";
            btnVerMantenimiento.UseVisualStyleBackColor = true;
            btnVerMantenimiento.Click += btnVerMantenimiento_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(530, 212);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(126, 48);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnVerMantenimiento);
            Controls.Add(btnAgregarMantenimiento);
            Controls.Add(btnVerRecursos);
            Controls.Add(btnModificarRecurso);
            Controls.Add(btnAgregarRecurso);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarRecurso;
        private Button btnModificarRecurso;
        private Button btnVerRecursos;
        private Button btnAgregarMantenimiento;
        private Button btnVerMantenimiento;
        private Button btnSalir;
    }
}