using ProyectoFinal.Models;
using ProyectoFinal.Services;
using System.Collections.ObjectModel;

namespace ProyectoFinal.ViewModels
{
    public class HomePageAdministradorViewModel : BaseViewModel
    {
        private readonly LoginService _loginService;

        public ObservableCollection<Usuario> Usuarios { get; set; } = new ObservableCollection<Usuario>();

        public HomePageAdministradorViewModel()
        {
            _loginService = new LoginService();
            CargarUsuariosCommand = new Command(async () => await CargarUsuarios());
        }

        public Command CargarUsuariosCommand { get; }

        private async Task CargarUsuarios()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                var usuarios = await _loginService.ObtenerUsuario();
                if (usuarios != null)
                {
                    Usuarios.Clear();
                    foreach (var usuario in usuarios)
                    {
                        Usuarios.Add(usuario);
                    }
                }
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", $"No se pudo cargar la información: {ex.Message}", "Aceptar");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
