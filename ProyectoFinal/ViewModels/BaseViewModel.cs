using CommunityToolkit.Mvvm.ComponentModel;

namespace ProyectoFinal.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        public bool _isBusy;
        [ObservableProperty]
        public bool _title;
    }
}
