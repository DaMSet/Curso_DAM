namespace U3_E7_BlockDeNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            edicionToolStripMenuItem = new ToolStripMenuItem();
            cortarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            btnAbrir = new ToolStripButton();
            btnGuardar = new ToolStripButton();
            btnCortar = new ToolStripButton();
            btnCopiar = new ToolStripButton();
            btnPegar = new ToolStripButton();
            btnBuscar = new ToolStripButton();
            btnFuente = new ToolStripButton();
            btnColor = new ToolStripButton();
            richTextBoxPantalla = new RichTextBox();
            statusStrip1 = new StatusStrip();
            lblLineaActual = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, edicionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(180, 22);
            nuevoToolStripMenuItem.Text = "nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(180, 22);
            guardarToolStripMenuItem.Text = "guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // edicionToolStripMenuItem
            // 
            edicionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cortarToolStripMenuItem, copiarToolStripMenuItem, pegarToolStripMenuItem, buscarToolStripMenuItem, fuenteToolStripMenuItem, colorToolStripMenuItem });
            edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            edicionToolStripMenuItem.Size = new Size(58, 20);
            edicionToolStripMenuItem.Text = "Edicion";
            // 
            // cortarToolStripMenuItem
            // 
            cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            cortarToolStripMenuItem.Size = new Size(180, 22);
            cortarToolStripMenuItem.Text = "cortar";
            cortarToolStripMenuItem.Click += cortarToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(180, 22);
            copiarToolStripMenuItem.Text = "copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.Size = new Size(109, 22);
            pegarToolStripMenuItem.Text = "pegar";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(109, 22);
            buscarToolStripMenuItem.Text = "buscar";
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(109, 22);
            fuenteToolStripMenuItem.Text = "fuente";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(109, 22);
            colorToolStripMenuItem.Text = "color";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnAbrir, btnGuardar, btnCortar, btnCopiar, btnPegar, btnBuscar, btnFuente, btnColor });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 45);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNuevo.Image = Properties.Resources.nuevo;
            btnNuevo.ImageTransparentColor = Color.Magenta;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(23, 42);
            btnNuevo.Text = "toolStripButton1";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAbrir.Image = Properties.Resources.abrir;
            btnAbrir.ImageTransparentColor = Color.Magenta;
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(23, 42);
            btnAbrir.Text = "toolStripButton2";
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.ImageTransparentColor = Color.Magenta;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(23, 42);
            btnGuardar.Text = "toolStripButton3";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCortar
            // 
            btnCortar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCortar.Image = Properties.Resources.cortar;
            btnCortar.ImageTransparentColor = Color.Magenta;
            btnCortar.Name = "btnCortar";
            btnCortar.Size = new Size(23, 42);
            btnCortar.Text = "toolStripButton4";
            btnCortar.Click += btnCortar_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCopiar.Image = Properties.Resources.copiar;
            btnCopiar.ImageTransparentColor = Color.Magenta;
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(23, 42);
            btnCopiar.Text = "toolStripButton5";
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnPegar
            // 
            btnPegar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPegar.Image = Properties.Resources.pegar;
            btnPegar.ImageTransparentColor = Color.Magenta;
            btnPegar.Name = "btnPegar";
            btnPegar.Size = new Size(23, 42);
            btnPegar.Text = "toolStripButton6";
            // 
            // btnBuscar
            // 
            btnBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBuscar.Image = Properties.Resources.buscar;
            btnBuscar.ImageTransparentColor = Color.Magenta;
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(23, 42);
            btnBuscar.Text = "toolStripButton7";
            // 
            // btnFuente
            // 
            btnFuente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFuente.Image = Properties.Resources.fuente;
            btnFuente.ImageTransparentColor = Color.Magenta;
            btnFuente.Name = "btnFuente";
            btnFuente.Size = new Size(23, 42);
            btnFuente.Text = "toolStripButton8";
            // 
            // btnColor
            // 
            btnColor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnColor.Image = (Image)resources.GetObject("btnColor.Image");
            btnColor.ImageTransparentColor = Color.Red;
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(40, 42);
            btnColor.Text = "Color";
            // 
            // richTextBoxPantalla
            // 
            richTextBoxPantalla.Location = new Point(0, 72);
            richTextBoxPantalla.Name = "richTextBoxPantalla";
            richTextBoxPantalla.Size = new Size(800, 374);
            richTextBoxPantalla.TabIndex = 2;
            richTextBoxPantalla.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblLineaActual });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblLineaActual
            // 
            lblLineaActual.Name = "lblLineaActual";
            lblLineaActual.Size = new Size(13, 17);
            lblLineaActual.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBoxPantalla);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private RichTextBox richTextBoxPantalla;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem edicionToolStripMenuItem;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripButton btnNuevo;
        private ToolStripButton btnAbrir;
        private ToolStripButton btnGuardar;
        private ToolStripButton btnCortar;
        private ToolStripButton btnCopiar;
        private ToolStripButton btnPegar;
        private ToolStripButton btnBuscar;
        private ToolStripButton btnFuente;
        private ToolStripButton btnColor;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblLineaActual;
    }
}