using SIMDUT.Helpers;
using SIMDUT.Models;
using SIMDUT.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIMDUT.PocketGuide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TableOfContent : ContentPage
    {
        public ObservableCollection<PocketGuideItem> Items { get; set; }

        public TableOfContent()
        {
            InitializeComponent();

            var itemsource = from s in PocketGuideHelper.Index
                             orderby s.Id
                             select s;


            MyListView.ItemsSource = itemsource;
            MyListView.IsEnabled = true;
            MyListView.ItemTapped += async (sender, e) =>
            {

                var item = e.Item as PocketGuideItem;
                if (item == null)
                    return;
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!" + item.TargetType);


                await Navigation.PushAsync((new CarouselPageView(item)));
                //Deselect Item
                ((ListView)sender).SelectedItem = null;
            };
        }





    }
}
