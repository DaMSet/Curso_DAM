namespace Ejemplo2_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btcalcular_Click(object sender, EventArgs e)
        {

            double salario_des = 0;
            double desc = 0;
            string nombre = txtnombre.Text;
            double salario = Convert.ToDouble(txtsalario.Text);

            if (rbtG.Checked == true || rbtSG.Checked == true || rbtS.Checked == true) {
            
                if(rbtG.Checked == true)
                {
                    desc = 0.20 * salario;
                    salario_des = salario - desc;
                }

                if (rbtSG.Checked == true)
                {
                    desc = 0.15 * salario;
                    salario_des = salario - desc;
                }

                if (rbtS.Checked == true)
                {
                    desc = 0.05 * salario;
                    salario_des = salario - desc;
                }


                MessageBox.Show("El Empleado se llama " + nombre.ToString() + " tiene un salario base de "+ salario.ToString()+
                                " le restan "+ desc.ToString()+" y se queda con "+ salario_des.ToString());
            }

        }
    }
}