using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ViewModels
{
    public partial class AppShellViewModel :BaseViewModel
    {
        [RelayCommand]
        async void SignOut()
        {
            if (Preferences.ContainsKey(nameof(App.usuario)))
            {
                Preferences.Remove(nameof(App.usuario));
            }
            App.usuario = null;
            await Shell.Current.GoToAsync($"//{nameof(Login)}");
        }
    }
}
