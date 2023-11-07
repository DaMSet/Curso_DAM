using U3_E4_Formularios.frm;

namespace U3_E4_Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCiclo_Click(object sender, EventArgs e)
        {

            FrmCiclo frmC = new FrmCiclo();
            frmC.ShowDialog();

        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            FrmEstudiante frmE = new FrmEstudiante();
            frmE.ShowDialog();
        }
    }
}