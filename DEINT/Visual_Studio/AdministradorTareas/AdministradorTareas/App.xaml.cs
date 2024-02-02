using CollectionViewDem.MVVM.View;

namespace AdministradorTareas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new CollectionDemoView();

            MainPage = new NavigationPage(new CollectionDemoView());

        }
    }
}
