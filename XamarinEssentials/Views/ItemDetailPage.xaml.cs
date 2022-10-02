using System.ComponentModel;
using Xamarin.Forms;
using XamarinEssentials.ViewModels;

namespace XamarinEssentials.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}