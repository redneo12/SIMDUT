using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SIMDUT.PocketGuide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageIntroduction : ContentPage
    {
        public ICommand OpenUrl => new Command<string>(OpenBrowser);
        public PageIntroduction()
        {
            InitializeComponent();
            BindingContext = this;
        }
        async void OpenBrowser(string url)
        {
            await Launcher.OpenAsync(new Uri(url));
        }

    }
}