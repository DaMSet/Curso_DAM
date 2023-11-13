namespace U3_E5_3_Ficheros
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
            btnClonar = new Button();
            txtArchivo1 = new TextBox();
            txtArchivo2 = new TextBox();
            SuspendLayout();
            // 
            // btnClonar
            // 
            btnClonar.Location = new Point(345, 272);
            btnClonar.Name = "btnClonar";
            btnClonar.Size = new Size(75, 23);
            btnClonar.TabIndex = 0;
            btnClonar.Text = "Clonar";
            btnClonar.UseVisualStyleBackColor = true;
            btnClonar.Click += button1_Click;
            // 
            // txtArchivo1
            // 
            txtArchivo1.Location = new Point(99, 131);
            txtArchivo1.Name = "txtArchivo1";
            txtArchivo1.Size = new Size(100, 23);
            txtArchivo1.TabIndex = 1;
            // 
            // txtArchivo2
            // 
            txtArchivo2.Location = new Point(522, 131);
            txtArchivo2.Name = "txtArchivo2";
            txtArchivo2.Size = new Size(100, 23);
            txtArchivo2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtArchivo2);
            Controls.Add(txtArchivo1);
            Controls.Add(btnClonar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClonar;
        private TextBox txtArchivo1;
        private TextBox txtArchivo2;
    }
}