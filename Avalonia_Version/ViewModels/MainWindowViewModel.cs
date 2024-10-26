namespace Avalonia_Version.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public static string Greeting => "Welcome to Avalonia!";

    public SimpleViewModel SimpleViewModel { get; } = new SimpleViewModel();

    public ReactiveViewModel ReactiveViewModel { get; } = new ReactiveViewModel();
}
