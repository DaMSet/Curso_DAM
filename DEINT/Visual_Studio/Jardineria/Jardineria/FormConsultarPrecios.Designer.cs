namespace Jardineria
{
    partial class FormConsultarPrecios
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
            this.btnMostrarPrecios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMasCaro = new System.Windows.Forms.Label();
            this.lblMasBarato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarPrecios
            // 
            this.btnMostrarPrecios.Location = new System.Drawing.Point(337, 269);
            this.btnMostrarPrecios.Name = "btnMostrarPrecios";
            this.btnMostrarPrecios.Size = new System.Drawing.Size(119, 34);
            this.btnMostrarPrecios.TabIndex = 0;
            this.btnMostrarPrecios.Text = "Mostrar precios";
            this.btnMostrarPrecios.UseVisualStyleBackColor = true;
            this.btnMostrarPrecios.Click += new System.EventHandler(this.btnMostrarPrecios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto mas caro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto mas barato:";
            // 
            // lblMasCaro
            // 
            this.lblMasCaro.AutoSize = true;
            this.lblMasCaro.Location = new System.Drawing.Point(334, 96);
            this.lblMasCaro.Name = "lblMasCaro";
            this.lblMasCaro.Size = new System.Drawing.Size(0, 13);
            this.lblMasCaro.TabIndex = 3;
            // 
            // lblMasBarato
            // 
            this.lblMasBarato.AutoSize = true;
            this.lblMasBarato.Location = new System.Drawing.Point(342, 174);
            this.lblMasBarato.Name = "lblMasBarato";
            this.lblMasBarato.Size = new System.Drawing.Size(0, 13);
            this.lblMasBarato.TabIndex = 4;
            // 
            // FormConsultarPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMasBarato);
            this.Controls.Add(this.lblMasCaro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarPrecios);
            this.Name = "FormConsultarPrecios";
            this.Text = "FormConsultarPrecios";
            this.Load += new System.EventHandler(this.FormConsultarPrecios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPrecios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMasCaro;
        private System.Windows.Forms.Label lblMasBarato;
    }
}