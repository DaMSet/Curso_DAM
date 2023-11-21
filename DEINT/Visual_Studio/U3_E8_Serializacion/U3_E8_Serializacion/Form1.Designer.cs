namespace U3_E8_Serializacion
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
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtEdad = new TextBox();
            txtTelefono = new TextBox();
            txtNC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtgbanco = new DataGridView();
            btnAñadir = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgbanco).BeginInit();
            SuspendLayout();
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(174, 13);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(467, 23);
            txtDNI.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(467, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(174, 113);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(467, 23);
            txtDireccion.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(174, 158);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(467, 23);
            txtEdad.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(174, 207);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(467, 23);
            txtTelefono.TabIndex = 4;
            // 
            // txtNC
            // 
            txtNC.Location = new Point(174, 258);
            txtNC.Name = "txtNC";
            txtNC.Size = new Size(467, 23);
            txtNC.TabIndex = 5;
            // 
            // label1
            // 
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.Location = new Point(13, 62);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.Location = new Point(13, 113);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 8;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.Location = new Point(13, 158);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 9;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.Location = new Point(13, 207);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 10;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.Location = new Point(13, 258);
            label6.Name = "label6";
            label6.Size = new Size(127, 23);
            label6.TabIndex = 11;
            label6.Text = "Nº Cuenta Corriente";
            // 
            // dtgbanco
            // 
            dtgbanco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgbanco.Location = new Point(12, 365);
            dtgbanco.Name = "dtgbanco";
            dtgbanco.RowTemplate.Height = 25;
            dtgbanco.Size = new Size(776, 222);
            dtgbanco.TabIndex = 12;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(174, 315);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(75, 23);
            btnAñadir.TabIndex = 13;
            btnAñadir.Text = "añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(308, 315);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(439, 315);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(566, 317);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 21);
            btnMostrar.TabIndex = 16;
            btnMostrar.Text = "mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 599);
            Controls.Add(btnMostrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAñadir);
            Controls.Add(dtgbanco);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNC);
            Controls.Add(txtTelefono);
            Controls.Add(txtEdad);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgbanco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDNI;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtEdad;
        private TextBox txtTelefono;
        private TextBox txtNC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dtgbanco;
        private Button btnAñadir;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnMostrar;
    }
}