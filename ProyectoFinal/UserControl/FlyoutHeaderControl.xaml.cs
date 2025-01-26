namespace ProyectoFinal.UserControl;

public partial class FlyoutHeaderControl : ContentView
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();
		if (App.usuario != null)
		{
			lblUserName.Text = "Ingresado como: " + App.usuario.Nombre;
			lblEmail.Text = App.usuario.Correo;
		}

	}
}