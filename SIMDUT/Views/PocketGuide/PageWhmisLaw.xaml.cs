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
	public partial class PageWhmisLaw : ContentPage
    {

        public PageWhmisLaw ()
		{
			InitializeComponent ();

            //imgLadyLaw.Source = ImageSource.FromResource(Strings.ImgWhmisPicLadyLaw);
        }
	}
}