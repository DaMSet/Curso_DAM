namespace U3_E4_Formularios.frm
{
    partial class FrmEstudiante
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
            pcbEstudiante = new PictureBox();
            btnExaminar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnCancelar = new Button();
            lblClave = new Label();
            txtClave = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtPApellido = new TextBox();
            lblPApellido = new Label();
            txtSApellido = new TextBox();
            lblSApellido = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            dgvTabla = new DataGridView();
            cmbCiclo = new ComboBox();
            lblCiclo = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbEstudiante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            SuspendLayout();
            // 
            // pcbEstudiante
            // 
            pcbEstudiante.Location = new Point(23, 25);
            pcbEstudiante.Name = "pcbEstudiante";
            pcbEstudiante.Size = new Size(130, 208);
            pcbEstudiante.TabIndex = 0;
            pcbEstudiante.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(23, 262);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(130, 23);
            btnExaminar.TabIndex = 1;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(226, 262);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(80, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(355, 262);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(80, 23);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(486, 262);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(80, 23);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(608, 262);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(208, 39);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 6;
            lblClave.Text = "Clave";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(208, 57);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(152, 23);
            txtClave.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(397, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(345, 23);
            txtNombre.TabIndex = 9;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(397, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // txtPApellido
            // 
            txtPApellido.Location = new Point(208, 109);
            txtPApellido.Name = "txtPApellido";
            txtPApellido.Size = new Size(182, 23);
            txtPApellido.TabIndex = 11;
            // 
            // lblPApellido
            // 
            lblPApellido.AutoSize = true;
            lblPApellido.Location = new Point(208, 91);
            lblPApellido.Name = "lblPApellido";
            lblPApellido.Size = new Size(89, 15);
            lblPApellido.TabIndex = 10;
            lblPApellido.Text = "Primer Apellido";
            // 
            // txtSApellido
            // 
            txtSApellido.Location = new Point(429, 109);
            txtSApellido.Name = "txtSApellido";
            txtSApellido.Size = new Size(313, 23);
            txtSApellido.TabIndex = 13;
            // 
            // lblSApellido
            // 
            lblSApellido.AutoSize = true;
            lblSApellido.Location = new Point(429, 91);
            lblSApellido.Name = "lblSApellido";
            lblSApellido.Size = new Size(101, 15);
            lblSApellido.TabIndex = 12;
            lblSApellido.Text = "Segundo Apellido";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(208, 159);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(534, 23);
            txtCorreo.TabIndex = 15;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(208, 141);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 14;
            lblCorreo.Text = "Correo";
            // 
            // dgvTabla
            // 
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.Location = new Point(12, 314);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.RowTemplate.Height = 25;
            dgvTabla.Size = new Size(756, 124);
            dgvTabla.TabIndex = 16;
            // 
            // cmbCiclo
            // 
            cmbCiclo.FormattingEnabled = true;
            cmbCiclo.Location = new Point(208, 210);
            cmbCiclo.Name = "cmbCiclo";
            cmbCiclo.Size = new Size(534, 23);
            cmbCiclo.TabIndex = 17;
            // 
            // lblCiclo
            // 
            lblCiclo.AutoSize = true;
            lblCiclo.Location = new Point(208, 192);
            lblCiclo.Name = "lblCiclo";
            lblCiclo.Size = new Size(34, 15);
            lblCiclo.TabIndex = 18;
            lblCiclo.Text = "Ciclo";
            // 
            // FrmEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCiclo);
            Controls.Add(cmbCiclo);
            Controls.Add(dgvTabla);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtSApellido);
            Controls.Add(lblSApellido);
            Controls.Add(txtPApellido);
            Controls.Add(lblPApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtClave);
            Controls.Add(lblClave);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnExaminar);
            Controls.Add(pcbEstudiante);
            Name = "FrmEstudiante";
            Text = "FrmEstudiante";
            ((System.ComponentModel.ISupportInitialize)pcbEstudiante).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbEstudiante;
        private Button btnExaminar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnCancelar;
        private Label lblClave;
        private TextBox txtClave;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtPApellido;
        private Label lblPApellido;
        private TextBox txtSApellido;
        private Label lblSApellido;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private DataGridView dgvTabla;
        private ComboBox cmbCiclo;
        private Label lblCiclo;
    }
}