using PropertyChanged;
using PruebaBDMAUITODO.MVVM.Model;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PruebaBDMAUITODO.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]

    public partial class UsuarioViewModel
    {

        public List<Usuario> Customers { get; set; }

        public Usuario CurrentCustomer { get; set; }

        public ICommand AddOrUpdateCommand { get; set; }

        public ICommand DeleteCommand { get; set; }


        public UsuarioViewModel()
        {

        }

        


    }

}


