using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace ProyectoFinal.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        private string userName;
        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                OnPropertyChanged();
            }
        }

        private string membership;
        public string Membership
        {
            get => membership;
            set
            {
                membership = value;
                OnPropertyChanged();
            }
        }

        public HomePageViewModel()
        {
            LoadUserData();
        }

        public void LoadUserData()
        {
            if (App.usuario != null)
            {
                UserName = "Hola " + App.usuario.Nombre;
                Membership = App.usuario.Membresia;
            }
            else
            {
                UserName = "Usuario no disponible";
                Membership = string.Empty;
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
