﻿namespace Ejemplo2_Formulario
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
            btcalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            rbtG = new RadioButton();
            rbtSG = new RadioButton();
            rbtS = new RadioButton();
            txtnombre = new TextBox();
            txtsalario = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btcalcular
            // 
            btcalcular.Location = new Point(319, 364);
            btcalcular.Name = "btcalcular";
            btcalcular.Size = new Size(176, 25);
            btcalcular.TabIndex = 0;
            btcalcular.Text = "Calcular";
            btcalcular.UseVisualStyleBackColor = true;
            btcalcular.Click += btcalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 150);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 150);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Salario";
            // 
            // rbtG
            // 
            rbtG.AutoSize = true;
            rbtG.Location = new Point(174, 265);
            rbtG.Name = "rbtG";
            rbtG.Size = new Size(66, 19);
            rbtG.TabIndex = 4;
            rbtG.TabStop = true;
            rbtG.Text = "Gerente";
            rbtG.UseVisualStyleBackColor = true;
            rbtG.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbtSG
            // 
            rbtSG.AutoSize = true;
            rbtSG.Location = new Point(349, 265);
            rbtSG.Name = "rbtSG";
            rbtSG.Size = new Size(85, 19);
            rbtSG.TabIndex = 5;
            rbtSG.TabStop = true;
            rbtSG.Text = "Subgerente";
            rbtSG.UseVisualStyleBackColor = true;
            // 
            // rbtS
            // 
            rbtS.AutoSize = true;
            rbtS.Location = new Point(528, 265);
            rbtS.Name = "rbtS";
            rbtS.Size = new Size(76, 19);
            rbtS.TabIndex = 6;
            rbtS.TabStop = true;
            rbtS.Text = "Secretaria";
            rbtS.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(259, 147);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 9;
            // 
            // txtsalario
            // 
            txtsalario.Location = new Point(552, 147);
            txtsalario.Name = "txtsalario";
            txtsalario.Size = new Size(100, 23);
            txtsalario.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 52);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 11;
            label3.Text = "Problema 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtsalario);
            Controls.Add(txtnombre);
            Controls.Add(rbtS);
            Controls.Add(rbtSG);
            Controls.Add(rbtG);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btcalcular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btcalcular;
        private Label label1;
        private Label label2;
        private RadioButton rbtG;
        private RadioButton rbtSG;
        private RadioButton rbtS;
        private TextBox txtnombre;
        private TextBox txtsalario;
        private Label label3;
    }
}