using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XamarinEssentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace XamarinEssentials.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SmsPage : ContentPage
    {
        public SmsPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Sms.ComposeAsync(new SmsMessage(EntryMessage.Text, EntryNumber.Text));

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}