namespace U3_E4_Formularios.frm
{
    partial class FrmCiclo
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
            btnCancelar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgCiclo = new DataGridView();
            txtID = new TextBox();
            txtNombreCiclo = new TextBox();
            lblID = new Label();
            lblNombreCiclo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgCiclo).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(514, 107);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(392, 107);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(80, 23);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(261, 107);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(80, 23);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(132, 107);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(80, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgCiclo
            // 
            dgCiclo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCiclo.Location = new Point(33, 162);
            dgCiclo.Name = "dgCiclo";
            dgCiclo.RowTemplate.Height = 25;
            dgCiclo.Size = new Size(710, 265);
            dgCiclo.TabIndex = 10;
            
            // 
            // txtID
            // 
            txtID.Location = new Point(33, 60);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 11;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // txtNombreCiclo
            // 
            txtNombreCiclo.Location = new Point(261, 60);
            txtNombreCiclo.Name = "txtNombreCiclo";
            txtNombreCiclo.Size = new Size(482, 23);
            txtNombreCiclo.TabIndex = 12;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(33, 28);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 13;
            lblID.Text = "ID";
            // 
            // lblNombreCiclo
            // 
            lblNombreCiclo.AutoSize = true;
            lblNombreCiclo.Location = new Point(261, 28);
            lblNombreCiclo.Name = "lblNombreCiclo";
            lblNombreCiclo.Size = new Size(81, 15);
            lblNombreCiclo.TabIndex = 14;
            lblNombreCiclo.Text = "Nombre Ciclo";
            // 
            // FrmCiclo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNombreCiclo);
            Controls.Add(lblID);
            Controls.Add(txtNombreCiclo);
            Controls.Add(txtID);
            Controls.Add(dgCiclo);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Name = "FrmCiclo";
            Text = "FrmCiclo";
            ((System.ComponentModel.ISupportInitialize)dgCiclo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnBorrar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgCiclo;
        private TextBox txtID;
        private TextBox txtNombreCiclo;
        private Label lblID;
        private Label lblNombreCiclo;
    }
}