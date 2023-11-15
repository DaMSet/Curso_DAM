namespace U3_E5_5_Ficheros
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
            T = new FileSystemWatcher();
            txtArchivo1 = new TextBox();
            txtArchivo2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)T).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(341, 292);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // T
            // 
            T.EnableRaisingEvents = true;
            T.SynchronizingObject = this;
            // 
            // txtArchivo1
            // 
            txtArchivo1.Location = new Point(132, 171);
            txtArchivo1.Name = "txtArchivo1";
            txtArchivo1.Size = new Size(100, 23);
            txtArchivo1.TabIndex = 1;
            // 
            // txtArchivo2
            // 
            txtArchivo2.Location = new Point(563, 171);
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
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)T).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FileSystemWatcher T;
        private TextBox txtArchivo2;
        private TextBox txtArchivo1;
    }
}