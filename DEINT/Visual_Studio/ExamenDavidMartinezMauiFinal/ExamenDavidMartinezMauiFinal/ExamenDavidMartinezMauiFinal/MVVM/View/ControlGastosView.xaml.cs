
using ExamenDavidMartinezMauiFinal.MVVM.ViewModel;

namespace ExamenDavidMartinezMauiFinal.MVVM.View;

public partial class ControlGastosView : ContentPage
{
    private ControlGastosViewModel _viewModel;

    public ControlGastosView()
    {
        InitializeComponent();

        _viewModel = new ControlGastosViewModel();

        BindingContext = _viewModel;
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TransaccionesView());
    }

}

