using MauiApp3_teoria4.MVVM.ViewModel;

namespace MauiApp3_teoria4.MVVM.View;

public partial class ComandView : ContentPage
{
	public ComandView()
	{
        InitializeComponent();

        BindingContext = new ComandViewModel();



    }
}