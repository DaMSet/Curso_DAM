namespace U3_E10_Jardinería_Repaso
{
    partial class Borrar
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
            txtBorrarGama = new Button();
            btnCancelarBorrado = new Button();
            cmbGama = new ComboBox();
            SuspendLayout();
            // 
            // txtBorrarGama
            // 
            txtBorrarGama.Location = new Point(188, 316);
            txtBorrarGama.Name = "txtBorrarGama";
            txtBorrarGama.Size = new Size(75, 23);
            txtBorrarGama.TabIndex = 0;
            txtBorrarGama.Text = "Borrar";
            txtBorrarGama.UseVisualStyleBackColor = true;
            txtBorrarGama.Click += txtBorrarGama_Click;
            // 
            // btnCancelarBorrado
            // 
            btnCancelarBorrado.Location = new Point(466, 316);
            btnCancelarBorrado.Name = "btnCancelarBorrado";
            btnCancelarBorrado.Size = new Size(75, 23);
            btnCancelarBorrado.TabIndex = 1;
            btnCancelarBorrado.Text = "Cancelar";
            btnCancelarBorrado.UseVisualStyleBackColor = true;
            btnCancelarBorrado.Click += btnCancelarBorrado_Click;
            // 
            // cmbGama
            // 
            cmbGama.FormattingEnabled = true;
            cmbGama.Location = new Point(282, 134);
            cmbGama.Name = "cmbGama";
            cmbGama.Size = new Size(199, 23);
            cmbGama.TabIndex = 2;
            // 
            // Borrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbGama);
            Controls.Add(btnCancelarBorrado);
            Controls.Add(txtBorrarGama);
            Name = "Borrar";
            Text = "Borrar";
            ResumeLayout(false);
        }

        #endregion

        private Button txtBorrarGama;
        private Button btnCancelarBorrado;
        private ComboBox cmbGama;
    }
}