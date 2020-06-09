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
    public partial class QuickLinksPage : ContentPage
    {
        public QuickLinksPage()
        {
            InitializeComponent();

        }



        //Generic Buttons Events
        async void Open_Glossary(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PocketGuide.Glossary());
            //await Navigation.PushAsync((Page)Scripts.GetCreatedInstance("Glossary"));
        }

        async void Open_Checklist(object sender, EventArgs e)
        {
            //await Navigation.PushAsync((Page)Scripts.GetCreatedInstance("Checklist"));
            await Navigation.PushAsync(new PocketGuide.Checklist());
        }


        async void Open_Notes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotesPage());
        }


        async void Open_GHS(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PocketGuide.PagePictograms());
        }

        async void Open_PPE(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PocketGuide.PagePPE());
        }

        async void Open_SDS(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PocketGuide.PageSDSExample());
        }
    }



}