namespace Tracker.ViewModels
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Xamarin.Forms;
    using Tracker.Models;
    using Tracker.Services;

    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        public bool IsBusy { get; set; }

        public string Title { get; set; } = string.Empty;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
