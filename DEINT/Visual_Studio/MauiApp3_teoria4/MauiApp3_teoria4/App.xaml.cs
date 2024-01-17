using MauiApp3_teoria4.MVVM.View;
using MauiApp3_teoria4.MVVM.ViewModel;

namespace MauiApp3_teoria4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new PersonView();

            //MainPage = new PeopleView();

            MainPage = new ComandView();

            //MainPage = new FodyDemoView();

        }
    }
}