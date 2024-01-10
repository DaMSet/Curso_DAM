using MauiAppEjemplo.Models;

namespace MauiAppEjemplo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var person = new Person
            {
                Name = "nombre",
                Adress = "sitio",
                Phone = 1,

            };

            BindingContext =  person;

        }




    }
}