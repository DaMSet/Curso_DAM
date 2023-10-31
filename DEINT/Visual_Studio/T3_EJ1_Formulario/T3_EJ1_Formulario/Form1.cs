namespace T3_EJ1_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {





        }


        private void txtNIF_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtNIF.BackColor = Color.Red;
        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtNombre.BackColor = Color.Red;
        }

        private void txtApellido_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtApellido.BackColor = Color.Red;
        }


        private void txtEmail_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.txtEmail.BackColor = Color.Red;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtNIF.BackColor = Color.White;
            this.txtApellido.BackColor = Color.White;
            this.txtEmail.BackColor = Color.White;
            this.txtNombre.BackColor = Color.White;
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "imagenes | *.jpg; *.gift; *.png";
            dlg.Title = "Selecciona imagen";
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(dlg.FileName);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtNIF.Clear();
            this.txtApellido.Clear();
            this.txtEmail.Clear();
            this.txtNombre.Clear();
        }






        //errorNIF.SetError(txt, "Campo Obligatorio");

    }
}