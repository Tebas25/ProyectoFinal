using ProyectoFinal.ViewModels;

namespace ProyectoFinal.Views;

public partial class HomePage : ContentPage
{
	private HomePageViewModel viewModel;
	public HomePage()
	{
        InitializeComponent();
		viewModel = new HomePageViewModel();
		BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.LoadUserData();
    }
}