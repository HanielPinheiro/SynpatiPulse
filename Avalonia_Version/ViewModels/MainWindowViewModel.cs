using Avalonia.Threading;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Avalonia_Version.ViewModels;

public partial class MainWindowViewModel : ReactiveObject
{
    public static string Greeting => "Welcome to Avalonia!";

    public SimpleViewModel SimpleViewModel { get; } = new SimpleViewModel();

    public ReactiveViewModel ReactiveViewModel { get; } = new ReactiveViewModel();


    //Above are elements of this tutorial: https://github.com/AvaloniaUI/Avalonia.Samples/tree/main/src/Avalonia.Samples/MVVM/CommandSample
    private string? _RobotName;
    /// <summary>
    /// The name of a robot. If the name is null or empty, there is no other robot present.
    /// </summary>
    public string? RobotName
    {
        get => _RobotName;
        set => this.RaiseAndSetIfChanged(ref _RobotName, value?.ToString());
    }

    public MainWindowViewModel()
    {
        // Init OpenThePodBayDoorsDirectCommand
        OpenThePodBayDoorsDirectCommand = ReactiveCommand.Create(OpenThePodBayDoors);

        // Init OpenThePodBayDoorsAsyncCommand
        OpenThePodBayDoorsAsyncCommand = ReactiveCommand.CreateFromTask(OpenThePodBayDoorsAsync);

        // The IObservable<bool> is needed to enable or disable the command depending on valid parameters
        //      Validation => The Observable listens to RobotName and will enable the Command if the name is not empty.
        IObservable<bool> canExecuteFellowRobotCommand = this.WhenAnyValue(vm => vm.RobotName, (name) => !string.IsNullOrEmpty(name));

        OpenThePodBayDoorsFellowRobotCommand = ReactiveCommand.Create<string?>(name => OpenThePodBayDoorsFellowRobot(name), canExecuteFellowRobotCommand);
    }

    /// <summary>
    /// This command will ask HAL-9000 to open the pod bay doors
    /// </summary>
    public ICommand OpenThePodBayDoorsDirectCommand { get; }

    public ICommand OpenThePodBayDoorsAsyncCommand { get; }

    /// <summary>
    /// This command will ask HAL to open the pod bay doors, but this time we
    /// check that the command is issued by a fellow robot (really any non-null name)
    /// </summary>
    public ICommand OpenThePodBayDoorsFellowRobotCommand { get; }

    /// <summary>
    ///  This collection will store what the computer said
    /// </summary>
    public ObservableCollection<string> ConversationLog { get; } = new ObservableCollection<string>();


    // The method that will be executed when the command is invoked
    private void OpenThePodBayDoors()
    {
            ConversationLog.Clear();
            LogTheConversation("I'm sorry, Dave, I'm afraid I can't do that.");
    }

    private void OpenThePodBayDoorsFellowRobot(string? robotName)
    {
        ConversationLog.Clear();
        LogTheConversation($"Hello {robotName}, the Pod Bay is open :-)");
    }

    // This method is an async Task because opening the pod bay doors can take long time.
    // We don't want our UI to become unresponsive.
    private async Task OpenThePodBayDoorsAsync()
    {
        ConversationLog.Clear();
        LogTheConversation("Preparing to open the Pod Bay...");
        await Task.Delay(1000); // wait a second

        LogTheConversation("Depressurizing Airlock...");
        await Task.Delay(2000); // wait 2 seconds

        LogTheConversation("Retracting blast doors...");
        await Task.Delay(2000); // wait 2 more seconds

        LogTheConversation("Pod Bay is open to space!");
    }

    private void LogTheConversation(string content)
    {
        ConversationLog.Add(content);
    }
}
