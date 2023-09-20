namespace Calculadora
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btncalcular = new Button();
            rbtn1 = new RadioButton();
            rbtn2 = new RadioButton();
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            listadvance = new ListBox();
            cmbop = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(338, 49);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Calculadora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 145);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 227);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Numero 2";
            label3.Click += label3_Click;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(338, 351);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 5;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // rbtn1
            // 
            rbtn1.AutoSize = true;
            rbtn1.Location = new Point(407, 116);
            rbtn1.Name = "rbtn1";
            rbtn1.Size = new Size(63, 19);
            rbtn1.TabIndex = 6;
            rbtn1.TabStop = true;
            rbtn1.Text = "Basicas";
            rbtn1.UseVisualStyleBackColor = true;
            rbtn1.CheckedChanged += rbtn1_CheckedChanged;
            // 
            // rbtn2
            // 
            rbtn2.AutoSize = true;
            rbtn2.Location = new Point(615, 116);
            rbtn2.Name = "rbtn2";
            rbtn2.Size = new Size(81, 19);
            rbtn2.TabIndex = 7;
            rbtn2.TabStop = true;
            rbtn2.Text = "Avanzadas";
            rbtn2.UseVisualStyleBackColor = true;
            rbtn2.CheckedChanged += rbtn2_CheckedChanged;
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(218, 142);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(100, 23);
            txtnum1.TabIndex = 8;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(218, 219);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(100, 23);
            txtnum2.TabIndex = 9;
            // 
            // listadvance
            // 
            listadvance.FormattingEnabled = true;
            listadvance.ItemHeight = 15;
            listadvance.Location = new Point(615, 162);
            listadvance.Name = "listadvance";
            listadvance.Size = new Size(120, 94);
            listadvance.TabIndex = 10;
            // 
            // cmbop
            // 
            cmbop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbop.FormattingEnabled = true;
            cmbop.Location = new Point(407, 175);
            cmbop.Name = "cmbop";
            cmbop.Size = new Size(121, 23);
            cmbop.TabIndex = 11;
            cmbop.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbop);
            Controls.Add(listadvance);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Controls.Add(rbtn2);
            Controls.Add(rbtn1);
            Controls.Add(btncalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btncalcular;
        private RadioButton rbtn1;
        private RadioButton rbtn2;
        private TextBox txtnum1;
        private TextBox txtnum2;
        private ListBox listadvance;
        private ComboBox cmbop;
    }
}