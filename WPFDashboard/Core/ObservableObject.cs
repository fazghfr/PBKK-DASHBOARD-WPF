using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace WPFDashboard.Core
{
    class ObservableObject
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
