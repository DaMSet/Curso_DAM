namespace _2Ejercicio
{
    partial class AgregarRecurso
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
            button1 = new Button();
            label1 = new Label();
            codigo = new TextBox();
            codigoRecurso = new TextBox();
            label2 = new Label();
            nombre = new TextBox();
            label3 = new Label();
            estado = new TextBox();
            label4 = new Label();
            fecha = new TextBox();
            label5 = new Label();
            descripcion = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(533, 336);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 45);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // codigo
            // 
            codigo.Location = new Point(171, 45);
            codigo.Name = "codigo";
            codigo.Size = new Size(100, 23);
            codigo.TabIndex = 2;
            // 
            // codigoRecurso
            // 
            codigoRecurso.Location = new Point(171, 114);
            codigoRecurso.Name = "codigoRecurso";
            codigoRecurso.Size = new Size(100, 23);
            codigoRecurso.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 114);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // nombre
            // 
            nombre.Location = new Point(171, 180);
            nombre.Name = "nombre";
            nombre.Size = new Size(100, 23);
            nombre.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 180);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // estado
            // 
            estado.Location = new Point(517, 177);
            estado.Name = "estado";
            estado.Size = new Size(100, 23);
            estado.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 177);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "label4";
            // 
            // fecha
            // 
            fecha.Location = new Point(517, 111);
            fecha.Name = "fecha";
            fecha.Size = new Size(100, 23);
            fecha.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 111);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // descripcion
            // 
            descripcion.Location = new Point(517, 42);
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(100, 23);
            descripcion.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 42);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // AgregarRecurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(estado);
            Controls.Add(label4);
            Controls.Add(fecha);
            Controls.Add(label5);
            Controls.Add(descripcion);
            Controls.Add(label6);
            Controls.Add(nombre);
            Controls.Add(label3);
            Controls.Add(codigoRecurso);
            Controls.Add(label2);
            Controls.Add(codigo);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AgregarRecurso";
            Text = "AgregarRecurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox codigo;
        private TextBox codigoRecurso;
        private Label label2;
        private TextBox nombre;
        private Label label3;
        private TextBox estado;
        private Label label4;
        private TextBox fecha;
        private Label label5;
        private TextBox descripcion;
        private Label label6;
    }
}