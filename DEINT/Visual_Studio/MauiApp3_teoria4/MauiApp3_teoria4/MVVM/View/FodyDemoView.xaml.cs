using MauiApp3_teoria4.MVVM.ViewModel;

namespace MauiApp3_teoria4.MVVM.View;

public partial class FodyDemoView : ContentPage
{
	public FodyDemoView()
	{
        

        BindingContext = new FodyDemoViewModel();
    }
}