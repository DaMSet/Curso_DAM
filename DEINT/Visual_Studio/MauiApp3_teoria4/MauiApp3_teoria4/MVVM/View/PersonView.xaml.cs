using MauiApp3_teoria4.MVVM.ViewModel;

namespace MauiApp3_teoria4.MVVM.View;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();

        BindingContext = new PersonViewModel();


    }
}