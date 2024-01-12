using MauiAppEjemplo.Models;

namespace MauiAppEjemplo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private Person persona = new Person();

        public MainPage()
        {
            InitializeComponent();


            persona.Name = "davis";
            persona.Adress = "sitio1";
            persona.Phone = 123;


            //Hay que hacer esto si o si

            BindingContext = persona;

        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

            persona.Name = "pepe";
            persona.Phone = 66;
            persona.Adress = "sitio2";

            //Hay que hacer esto si o si

            

        }




    }
}