namespace T3_EJ1_Formularios
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
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnLimpiar = new Button();
            Valor_1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(645, 115);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(645, 158);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(75, 23);
            btnRestar.TabIndex = 1;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(645, 201);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 2;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(645, 251);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Valor_1
            // 
            Valor_1.AutoSize = true;
            Valor_1.Location = new Point(198, 119);
            Valor_1.Name = "Valor_1";
            Valor_1.Size = new Size(42, 15);
            Valor_1.TabIndex = 4;
            Valor_1.Text = "Valor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 179);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Valor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 270);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Valor_1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnLimpiar;
        private Label Valor_1;
        private Label label2;
        private Label label3;
    }
}