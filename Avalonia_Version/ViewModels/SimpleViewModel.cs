using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Avalonia_Version.ViewModels
{
    public class SimpleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
               
        private string? _Name; // This is our backing field for Name

        public string? Name
        {
            get
            {
                return _Name;
            }
            set
            {              
                if (_Name != value)   // We only want to update the UI if the Name actually changed, so we check if the value is actually new
                {                    
                    _Name = value; // 1. update our backing field

                    // 2. We call RaisePropertyChanged() to notify the UI about changes.
                    // We can omit the property name here because [CallerMemberName] will provide it for us.
                    RaisePropertyChanged();
                    
                    RaisePropertyChanged(nameof(Greeting)); // 3. Greeting also changed. So let's notify the UI about it.
                }
            }
        }
        
        public string Greeting
        {
            get
            {
                if (string.IsNullOrEmpty(Name)) return "Hello World from Avalonia.Samples"; // If no Name is provided, use a default Greeting                
                else return $"Hello {Name}"; // else greet the User.                
            }
        }

        private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
