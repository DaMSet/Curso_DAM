using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEjemplo.Models
{

    //DATABINDING DEMO
    //label.text --> source -- p.name
    internal class Person : INotifyPropertyChanged
    {

        private String _Name;
        private int _Phone;
        private String _Adress;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Phone {
            get { return _Phone; }
            set
            {
                _Phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public string Adress {
            get { return _Adress; }
            set
            {
                _Adress = value;
                OnPropertyChanged("Adress");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName = null ) 
        {
            PropertyChanged? .Invoke( this, new PropertyChangedEventArgs( propName ) );
        }

    }
}
