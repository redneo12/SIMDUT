using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIMDUT.PocketGuide
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageSDS : ContentPage
    {
        
        public PageSDS ()
		{
			InitializeComponent ();
		}

        async void Open_SDS(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SIMDUT.PocketGuide.PageSDSExample());
        }
    }
}