﻿namespace U3_E5_2_Ficheros
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
            txtArchivo = new TextBox();
            txtCadena = new TextBox();
            ltFrases = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(71, 202);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtArchivo
            // 
            txtArchivo.BorderStyle = BorderStyle.None;
            txtArchivo.Location = new Point(46, 44);
            txtArchivo.Name = "txtArchivo";
            txtArchivo.Size = new Size(100, 16);
            txtArchivo.TabIndex = 1;
            // 
            // txtCadena
            // 
            txtCadena.Location = new Point(357, 44);
            txtCadena.Name = "txtCadena";
            txtCadena.Size = new Size(420, 23);
            txtCadena.TabIndex = 2;
            // 
            // ltFrases
            // 
            ltFrases.FormattingEnabled = true;
            ltFrases.ItemHeight = 15;
            ltFrases.Location = new Point(357, 117);
            ltFrases.Name = "ltFrases";
            ltFrases.Size = new Size(420, 244);
            ltFrases.TabIndex = 3;
            ltFrases.SelectedIndexChanged += ltFrases_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ltFrases);
            Controls.Add(txtCadena);
            Controls.Add(txtArchivo);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtArchivo;
        private TextBox txtCadena;
        private ListBox ltFrases;
    }
}