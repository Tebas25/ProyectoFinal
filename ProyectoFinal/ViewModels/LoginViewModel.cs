using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using ProyectoFinal.Models;
using ProyectoFinal.Services;
using ProyectoFinal.Views;

namespace ProyectoFinal.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [ObservableProperty]
        public string _Username;
        [ObservableProperty]
        public string _Clave;

        readonly ILoginRepository _loginRepository = new LoginService();

        [RelayCommand]
        public async void Login()
        {
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Clave))
            {
                Usuario usuario = await _loginRepository.Login(Username, Clave);
                if (usuario != null)
                {
                    if (Preferences.ContainsKey(nameof(App.usuario)))
                    {
                        Preferences.Remove(nameof(App.usuario));
                    }
                    string userDetails = JsonConvert.SerializeObject(usuario);
                    Preferences.Set(nameof(App.usuario), userDetails);
                    App.usuario = usuario;
                    if (App.usuario.claveAdministrador != null)
                    {
                        await Shell.Current.GoToAsync($"{nameof(HomePageAdministrador)}");
                    }
                    else
                    {
                        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
                    }
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Usuario o clave incorrecta.", "Aceptar");
                }
            } 
        }

    }
}
