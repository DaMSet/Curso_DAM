using PruebaBDMAUITODO.MVVM.ViewModel;

namespace PruebaBDMAUITODO.MVVM.View;

public partial class UsuarioView : ContentPage
{
	public UsuarioView()
	{
		InitializeComponent();

		BindingContext = new UsuarioViewModel();
	}

  
}