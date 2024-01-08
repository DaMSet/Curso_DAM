namespace David_Examen_DEINT_R
{
    partial class Leer
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.dtgDatosLibros = new System.Windows.Forms.DataGridView();
            this.dtgDatosEditorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosEditorial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(363, 345);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // dtgDatosLibros
            // 
            this.dtgDatosLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosLibros.Location = new System.Drawing.Point(22, 12);
            this.dtgDatosLibros.Name = "dtgDatosLibros";
            this.dtgDatosLibros.Size = new System.Drawing.Size(756, 120);
            this.dtgDatosLibros.TabIndex = 1;
            // 
            // dtgDatosEditorial
            // 
            this.dtgDatosEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosEditorial.Location = new System.Drawing.Point(22, 153);
            this.dtgDatosEditorial.Name = "dtgDatosEditorial";
            this.dtgDatosEditorial.Size = new System.Drawing.Size(756, 150);
            this.dtgDatosEditorial.TabIndex = 2;
            // 
            // Leer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgDatosEditorial);
            this.Controls.Add(this.dtgDatosLibros);
            this.Controls.Add(this.btnLeer);
            this.Name = "Leer";
            this.Text = "Leer";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosEditorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.DataGridView dtgDatosLibros;
        private System.Windows.Forms.DataGridView dtgDatosEditorial;
    }
}