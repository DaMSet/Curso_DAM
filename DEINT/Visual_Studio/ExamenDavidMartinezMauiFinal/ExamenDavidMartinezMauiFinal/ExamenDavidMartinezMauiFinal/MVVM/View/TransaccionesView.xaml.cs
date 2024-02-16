

using ExamenDavidMartinezMauiFinal.MVVM.ViewModel;

namespace ExamenDavidMartinezMauiFinal.MVVM.View;

public partial class TransaccionesView : ContentPage
{
	public TransaccionesView()
	{
        InitializeComponent();

        BindingContext = new TransaccionesViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ControlGastosView());
    }
}