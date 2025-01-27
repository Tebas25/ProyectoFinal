using ProyectoFinal.ViewModels;

namespace ProyectoFinal.Views;

public partial class HomePageAdministrador : ContentPage
{
	private HomePageAdministradorViewModel viewModel;
	public HomePageAdministrador()
	{
        InitializeComponent();
        viewModel = new HomePageAdministradorViewModel();
        BindingContext = viewModel;
    }
}