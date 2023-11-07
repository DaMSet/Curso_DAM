using U3_E4_Formularios.frm;

namespace U3_E4_Formularios
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            /* Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);

             Application.Run(new FrmCiclo());*/

            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmEstudiante());*/

        }
    }
}