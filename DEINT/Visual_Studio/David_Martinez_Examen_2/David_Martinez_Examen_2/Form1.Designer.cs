namespace David_Martinez_Examen_2
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
            btnNuevoProyecto = new Button();
            btnVerProyecto = new Button();
            SuspendLayout();
            // 
            // btnNuevoProyecto
            // 
            btnNuevoProyecto.Location = new Point(114, 134);
            btnNuevoProyecto.Name = "btnNuevoProyecto";
            btnNuevoProyecto.Size = new Size(123, 60);
            btnNuevoProyecto.TabIndex = 0;
            btnNuevoProyecto.Text = "nuevo proyecto";
            btnNuevoProyecto.UseVisualStyleBackColor = true;
            btnNuevoProyecto.Click += btnNuevoProyecto_Click;
            // 
            // btnVerProyecto
            // 
            btnVerProyecto.Location = new Point(435, 134);
            btnVerProyecto.Name = "btnVerProyecto";
            btnVerProyecto.Size = new Size(123, 60);
            btnVerProyecto.TabIndex = 1;
            btnVerProyecto.Text = "ver proyecto";
            btnVerProyecto.UseVisualStyleBackColor = true;
            btnVerProyecto.Click += btnVerProyecto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerProyecto);
            Controls.Add(btnNuevoProyecto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevoProyecto;
        private Button btnVerProyecto;
    }
}