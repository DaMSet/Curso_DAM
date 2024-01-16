using MauiApp3_teoria4.MVVM.ViewModel;

namespace MauiApp3_teoria4.MVVM.View;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();

        BindingContext = new PeopleViewModel();

    }
}