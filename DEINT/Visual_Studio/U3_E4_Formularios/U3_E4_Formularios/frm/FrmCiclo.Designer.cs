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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblID = new Label();
            lblNombreCiclo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(392, 107);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(80, 23);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(261, 107);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(80, 23);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(710, 265);
            dataGridView1.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(482, 23);
            textBox2.TabIndex = 12;
            
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
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Name = "FrmCiclo";
            Text = "FrmCiclo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnBorrar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblID;
        private Label lblNombreCiclo;
    }
}