namespace U3_E10_Jardinería_Repaso
{
    partial class PrecioCaroBarato
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
            btnAtras = new Button();
            label1 = new Label();
            txtNombreProductoBarato = new Label();
            txtNombreProductoCaro = new Label();
            label2 = new Label();
            txtPrecioCaro = new Label();
            txtPrecioBarato = new Label();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(353, 327);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 0;
            btnAtras.Text = "ATRAS";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // label1
            // 
            label1.Location = new Point(92, 68);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 1;
            label1.Text = "Producto mas caro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreProductoBarato
            // 
            txtNombreProductoBarato.Location = new Point(535, 137);
            txtNombreProductoBarato.Name = "txtNombreProductoBarato";
            txtNombreProductoBarato.Size = new Size(162, 23);
            txtNombreProductoBarato.TabIndex = 2;
            txtNombreProductoBarato.Text = "nombre";
            txtNombreProductoBarato.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreProductoCaro
            // 
            txtNombreProductoCaro.Location = new Point(92, 137);
            txtNombreProductoCaro.Name = "txtNombreProductoCaro";
            txtNombreProductoCaro.Size = new Size(152, 23);
            txtNombreProductoCaro.TabIndex = 3;
            txtNombreProductoCaro.Text = "nombre";
            txtNombreProductoCaro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(535, 68);
            label2.Name = "label2";
            label2.Size = new Size(162, 23);
            label2.TabIndex = 4;
            label2.Text = "Producto mas barato";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrecioCaro
            // 
            txtPrecioCaro.Location = new Point(92, 217);
            txtPrecioCaro.Name = "txtPrecioCaro";
            txtPrecioCaro.Size = new Size(152, 23);
            txtPrecioCaro.TabIndex = 5;
            txtPrecioCaro.Text = "precio";
            txtPrecioCaro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrecioBarato
            // 
            txtPrecioBarato.Location = new Point(535, 217);
            txtPrecioBarato.Name = "txtPrecioBarato";
            txtPrecioBarato.Size = new Size(162, 23);
            txtPrecioBarato.TabIndex = 6;
            txtPrecioBarato.Text = "precio";
            txtPrecioBarato.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PrecioCaroBarato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrecioBarato);
            Controls.Add(txtPrecioCaro);
            Controls.Add(label2);
            Controls.Add(txtNombreProductoCaro);
            Controls.Add(txtNombreProductoBarato);
            Controls.Add(label1);
            Controls.Add(btnAtras);
            Name = "PrecioCaroBarato";
            Text = "PrecioCaroBarato";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtras;
        private Label label1;
        private Label txtNombreProductoBarato;
        private Label txtNombreProductoCaro;
        private Label label2;
        private Label txtPrecioCaro;
        private Label txtPrecioBarato;
    }
}