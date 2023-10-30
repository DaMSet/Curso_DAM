namespace T3_EJ1_Formulario
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtNIF = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            pictureBox1 = new PictureBox();
            Lb1Texto = new Label();
            lblNIF = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(204, 346);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(356, 346);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(511, 346);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtNIF
            // 
            txtNIF.Location = new Point(211, 155);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(100, 23);
            txtNIF.TabIndex = 3;
            txtNIF.MouseClick += txtNIF_MouseClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(428, 155);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            txtNombre.MouseClick += txtNombre_MouseClick;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(211, 218);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            txtApellido.MouseClick += txtApellido_MouseClick;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(428, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 6;
            txtEmail.MouseClick += txtEmail_MouseClick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(303, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 77);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Lb1Texto
            // 
            Lb1Texto.AutoSize = true;
            Lb1Texto.Location = new Point(307, 13);
            Lb1Texto.Name = "Lb1Texto";
            Lb1Texto.Size = new Size(130, 15);
            Lb1Texto.TabIndex = 8;
            Lb1Texto.Text = "Informacion Estudiante";
            // 
            // lblNIF
            // 
            lblNIF.AutoSize = true;
            lblNIF.Location = new Point(211, 137);
            lblNIF.Name = "lblNIF";
            lblNIF.Size = new Size(25, 15);
            lblNIF.TabIndex = 9;
            lblNIF.Text = "NIF";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(428, 137);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(211, 200);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(428, 200);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblNIF);
            Controls.Add(Lb1Texto);
            Controls.Add(pictureBox1);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtNIF);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtNIF;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private PictureBox pictureBox1;
        private Label Lb1Texto;
        private Label lblNIF;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEmail;
    }
}