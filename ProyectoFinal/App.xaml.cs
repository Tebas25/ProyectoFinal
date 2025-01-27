using Newtonsoft.Json;
using ProyectoFinal.Models;

namespace ProyectoFinal
{
    public partial class App : Application
    {
        public static Usuario usuario;
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
