namespace _2Ejercicio
{
    partial class AgregarMantenimiento
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
            descripcion = new TextBox();
            label4 = new Label();
            fechafin = new TextBox();
            label5 = new Label();
            fechainicio = new TextBox();
            label6 = new Label();
            codigorecursotecnologico = new TextBox();
            label3 = new Label();
            codigoMantenimiento = new TextBox();
            label2 = new Label();
            codigo = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // descripcion
            // 
            descripcion.Location = new Point(574, 202);
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(100, 23);
            descripcion.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 202);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 24;
            label4.Text = "label4";
            // 
            // fechafin
            // 
            fechafin.Location = new Point(574, 136);
            fechafin.Name = "fechafin";
            fechafin.Size = new Size(100, 23);
            fechafin.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(473, 136);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 22;
            label5.Text = "label5";
            // 
            // fechainicio
            // 
            fechainicio.Location = new Point(574, 67);
            fechainicio.Name = "fechainicio";
            fechainicio.Size = new Size(100, 23);
            fechainicio.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 67);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 20;
            label6.Text = "label6";
            // 
            // codigorecursotecnologico
            // 
            codigorecursotecnologico.Location = new Point(228, 205);
            codigorecursotecnologico.Name = "codigorecursotecnologico";
            codigorecursotecnologico.Size = new Size(100, 23);
            codigorecursotecnologico.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 205);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // codigoMantenimiento
            // 
            codigoMantenimiento.Location = new Point(228, 139);
            codigoMantenimiento.Name = "codigoMantenimiento";
            codigoMantenimiento.Size = new Size(100, 23);
            codigoMantenimiento.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 139);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 16;
            label2.Text = "label2";
            // 
            // codigo
            // 
            codigo.Location = new Point(228, 70);
            codigo.Name = "codigo";
            codigo.Size = new Size(100, 23);
            codigo.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 70);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 14;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(590, 361);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AgregarMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(descripcion);
            Controls.Add(label4);
            Controls.Add(fechafin);
            Controls.Add(label5);
            Controls.Add(fechainicio);
            Controls.Add(label6);
            Controls.Add(codigorecursotecnologico);
            Controls.Add(label3);
            Controls.Add(codigoMantenimiento);
            Controls.Add(label2);
            Controls.Add(codigo);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AgregarMantenimiento";
            Text = "AgregarMantenimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcion;
        private Label label4;
        private TextBox fechafin;
        private Label label5;
        private TextBox fechainicio;
        private Label label6;
        private TextBox codigorecursotecnologico;
        private Label label3;
        private TextBox codigoMantenimiento;
        private Label label2;
        private TextBox codigo;
        private Label label1;
        private Button button1;
    }
}