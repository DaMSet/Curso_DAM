using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IndiceMasaCorporal;


    public partial class IMCViewModel : INotifyPropertyChanged
    {
        private double altura;
        private double peso;
        private double resultadoIMC;

        public double Altura
        {
            get => altura;
            set
            {
                altura = value;
                OnPropertyChanged();
                CalcularIMC();
            }
        }

        public double Peso
        {
            get => peso;
            set
            {
                peso = value;
                OnPropertyChanged();
                CalcularIMC();
            }
        }

        public double ResultadoIMC
        {
            get => resultadoIMC;
            set
            {
                resultadoIMC = value;
                OnPropertyChanged();
            }
        }

        private void CalcularIMC()
        {
            // Lógica para calcular el IMC
            double alturaEnMetros = Altura / 100;
            ResultadoIMC = Peso / (alturaEnMetros * alturaEnMetros);
        }

        #region Implementación de INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
