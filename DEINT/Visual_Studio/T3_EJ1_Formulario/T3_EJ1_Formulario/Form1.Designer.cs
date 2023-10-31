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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            listBox1 = new ListBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            errorNIF = new ErrorProvider(components);
            errorNOMBRE = new ErrorProvider(components);
            errorAPELLIDO = new ErrorProvider(components);
            errorEMAIL = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNIF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNOMBRE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorAPELLIDO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorEMAIL).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(17, 304);
            button1.Name = "button1";
            button1.Size = new Size(35, 23);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(110, 304);
            button2.Name = "button2";
            button2.Size = new Size(47, 23);
            button2.TabIndex = 1;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(212, 304);
            button3.Name = "button3";
            button3.Size = new Size(31, 23);
            button3.TabIndex = 2;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtNIF
            // 
            txtNIF.Location = new Point(17, 178);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(100, 23);
            txtNIF.TabIndex = 3;
            txtNIF.MouseClick += txtNIF_MouseClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(143, 178);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            txtNombre.MouseClick += txtNombre_MouseClick;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(17, 241);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            txtApellido.MouseClick += txtApellido_MouseClick;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 241);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 6;
            txtEmail.MouseClick += txtEmail_MouseClick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(50, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDoubleClick += pictureBox1_MouseDoubleClick;
            // 
            // Lb1Texto
            // 
            Lb1Texto.AutoSize = true;
            Lb1Texto.Location = new Point(64, 10);
            Lb1Texto.Name = "Lb1Texto";
            Lb1Texto.Size = new Size(130, 15);
            Lb1Texto.TabIndex = 8;
            Lb1Texto.Text = "Informacion Estudiante";
            // 
            // lblNIF
            // 
            lblNIF.AutoSize = true;
            lblNIF.Location = new Point(17, 160);
            lblNIF.Name = "lblNIF";
            lblNIF.Size = new Size(25, 15);
            lblNIF.TabIndex = 9;
            lblNIF.Text = "NIF";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(143, 160);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(17, 223);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(143, 223);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNIF);
            panel1.Controls.Add(Lb1Texto);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(lblNIF);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(23, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 347);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(292, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 347);
            panel2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 10);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 9;
            label1.Text = "Lista de Estudiantes";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(14, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(468, 304);
            listBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(23, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(765, 72);
            panel3.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(388, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 23);
            textBox1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 29);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 11;
            label4.Text = " Estudiantes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 29);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 10;
            label3.Text = "Buscar";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(23, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(765, 72);
            panel4.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.imagen;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(17, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 29);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 9;
            label2.Text = "Sistema de  Estudiantes";
            // 
            // errorNIF
            // 
            errorNIF.ContainerControl = this;
            // 
            // errorNOMBRE
            // 
            errorNOMBRE.ContainerControl = this;
            // 
            // errorAPELLIDO
            // 
            errorAPELLIDO.ContainerControl = this;
            // 
            // errorEMAIL
            // 
            errorEMAIL.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNIF).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNOMBRE).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorAPELLIDO).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorEMAIL).EndInit();
            ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private ListBox listBox1;
        private Label label1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox textBox1;
        private ErrorProvider errorNIF;
        private ErrorProvider errorNOMBRE;
        private ErrorProvider errorAPELLIDO;
        private ErrorProvider errorEMAIL;
    }
}