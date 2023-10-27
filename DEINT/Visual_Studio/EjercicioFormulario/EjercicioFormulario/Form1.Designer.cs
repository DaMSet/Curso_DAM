namespace EjercicioFormulario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDato = new TextBox();
            txtResultado = new TextBox();
            cmbLetra = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(195, 165);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Contar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(365, 165);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 1;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 225);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 34);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 83);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // txtDato
            // 
            txtDato.Location = new Point(195, 34);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(100, 23);
            txtDato.TabIndex = 5;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(203, 271);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(279, 143);
            txtResultado.TabIndex = 6;
            // 
            // cmbLetra
            // 
            cmbLetra.AutoCompleteCustomSource.AddRange(new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i" });
            cmbLetra.FormattingEnabled = true;
            cmbLetra.Items.AddRange(new object[] { "a", "b", "c", "d", "e" });
            cmbLetra.Location = new Point(194, 82);
            cmbLetra.Name = "cmbLetra";
            cmbLetra.Size = new Size(121, 23);
            cmbLetra.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbLetra);
            Controls.Add(txtResultado);
            Controls.Add(txtDato);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDato;
        private TextBox txtResultado;
        private TextBox textBox3;
        private ComboBox cmbLetra;
    }
}