using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinEssentials.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://learn.microsoft.com/en-us/xamarin/essentials/?context=xamarin%2Fandroid"));
        }

        public ICommand OpenWebCommand { get; }
    }
}