namespace U3_E4_Formularios
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
            btnCiclo = new Button();
            btnEstudiante = new Button();
            SuspendLayout();
            // 
            // btnCiclo
            // 
            btnCiclo.Location = new Point(42, 129);
            btnCiclo.Name = "btnCiclo";
            btnCiclo.Size = new Size(165, 146);
            btnCiclo.TabIndex = 0;
            btnCiclo.Text = "Ciclo";
            btnCiclo.UseVisualStyleBackColor = true;
            // 
            // btnEstudiante
            // 
            btnEstudiante.Location = new Point(447, 129);
            btnEstudiante.Name = "btnEstudiante";
            btnEstudiante.Size = new Size(165, 146);
            btnEstudiante.TabIndex = 1;
            btnEstudiante.Text = "Estudiante";
            btnEstudiante.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEstudiante);
            Controls.Add(btnCiclo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCiclo;
        private Button btnEstudiante;
    }
}