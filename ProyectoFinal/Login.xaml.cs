using ProyectoFinal.ViewModels;

namespace ProyectoFinal;

public partial class Login : ContentPage
{
	public Login(LoginViewModel loginViewModel)
	{
		InitializeComponent();
		this.BindingContext = loginViewModel;
	}
}