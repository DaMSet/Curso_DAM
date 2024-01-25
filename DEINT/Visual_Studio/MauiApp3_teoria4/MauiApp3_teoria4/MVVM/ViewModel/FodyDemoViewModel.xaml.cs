
using PropertyChanged;
using System.Windows.Input;

namespace MauiApp3_teoria4.MVVM.ViewModel;

public partial class FodyDemoViewModel : ContentPage
{

    [AddINotifyPropertyChangedInterface]

        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public int Resultado { get; set; }


        public ICommand AddCommand => new Command(() => { Resultado = Numero1 + Numero2; });


   




}