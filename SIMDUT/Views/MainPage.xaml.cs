using SIMDUT.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SIMDUT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {

        public MainPage()
        {
            InitializeComponent();

            Title = Strings.courseTitle;

            //this.BarBackgroundColor = Color.FromHex(Strings.ColYowM2Blue);
            //this.BarTextColor = Color.FromHex(Strings.ColYowLBlue);
            //this.SelectedTabColor = Color.FromHex(Strings.ColYowM2Blue);
            //this.UnselectedTabColor = Color.FromHex(Strings.ColYowLBlue);
        }

        private async void OnSearchedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SIMDUT.Views.SearchView());
        }


        private async void OnInfoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SIMDUT.PocketGuide.PageIntroduction());
        }

    }
}
