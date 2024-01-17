using System.Windows.Input;

namespace MauiApp3_teoria4.MVVM.ViewModel;

public partial class ComandViewModel : ContentPage
{
	 
		
		public ICommand ClickCommand { get;}
		public ICommand ClickCommand1 { get; }

		public ComandViewModel()
		{

			ClickCommand = new Command(() =>
			{
				Application.Current.MainPage.DisplayAlert("title", "measa", "ok");
			}
				);



			ClickCommand1 = new Command((s) =>
			{
				Application.Current.MainPage.DisplayAlert("title", s.ToString(), "ok");
			});
		}
}

