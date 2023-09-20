namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //agrega item al combo

            cmbop.Items.Clear();
            cmbop.Items.Add("Sumar");
            cmbop.Items.Add("Restar");

            //agrega item a la lista

            listadvance.Items.Clear();
            listadvance.Items.Add("Multiplicacion");
            listadvance.Items.Add("Division");
            listadvance.TabIndex = 0;

            //inhabilita el combo y la lista

            cmbop.Enabled = false;
            listadvance.Enabled = false;




        }

        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn1.Checked == true)
            {
                cmbop.Enabled = true;
                listadvance.Enabled = false;
            }
        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn2.Checked == true)
            {
                cmbop.Enabled = false;
                listadvance.Enabled = true;

                //me permite seleccionar el primer elemento de la lista
                listadvance.SelectedIndex = 0;
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, r;

            n1 = Convert.ToDouble(txtnum1.Text);
            n2 = Convert.ToDouble(txtnum2.Text);

            if (cmbop.Enabled == true)
            {
                if (cmbop.SelectedIndex == 0)
                {
                    r = n1 + n2;
                }
                else {
                    r = n1 - n2;
                }

                MessageBox.Show("El Resultado es "+ r.ToString() +" Respuesta ");

             
            }
            
            if (listadvance.Enabled == true)
            {
                if (listadvance.SelectedItem.ToString() == "Multiplicacion")
                {
                    r = n1 * n2;
                }
                else
                {
                    r = n1 / n2;
                }

                MessageBox.Show("El Resultado es " + r.ToString() + " Respuesta");
            }

        }
    }
}