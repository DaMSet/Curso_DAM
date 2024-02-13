
using PruebaBDMAUITODO.Abstration;
using PruebaBDMAUITODO.MVVM.Model;
using PruebaBDMAUITODO.MVVM.View;
using PruebaBDMAUITODO.Repository;

namespace PruebaBDMAUITODO
{
    public partial class App : Application
    {
    
        



        public static BaseRepository<Usuario> UsuarioRepo { get; private set; }
        public static BaseRepository<Transaccion> TransaccionRepo { get; private set; }

      
        public App(BaseRepository<Usuario> usuarioRepo, BaseRepository<Transaccion> transaccionRepo)
        {
            InitializeComponent();
            UsuarioRepo = usuarioRepo;
            TransaccionRepo = transaccionRepo;
            
            MainPage = new UsuarioView();
        }
        


    }
    
}
