using ProyectoFinal.ViewModels;
using ProyectoFinal.Views;

namespace ProyectoFinal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.BindingContext = new AppShellViewModel();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(HomePageAdministrador), typeof(HomePageAdministrador));
        }
    }
}
