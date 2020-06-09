using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using SIMDUT.Models;
using SIMDUT.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using SIMDUT.Helpers;

//https://www.thewissen.io/xamarin-forms-listview-grouping/

namespace SIMDUT.PocketGuide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Glossary : ContentPage
    {
        GlossaryViewModel vm = new GlossaryViewModel();
        public Glossary()
        {

            InitializeComponent();




            BindingContext = vm;


            foreach (var item in vm.GlossaryGrouped)
            {
                Label button = new Label()
                {
                    Text = item.Key,
                    TextColor = Color.FromHex(Strings.ColYowLink),
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    HorizontalTextAlignment = TextAlignment.Center

                };
                var tapGesture = new TapGestureRecognizer();
                tapGesture.Tapped += (sender, e) =>
                    {
                        glossaryLV.ScrollTo(item.Items[0], ScrollToPosition.Start, true);
                    };
                button.GestureRecognizers.Add(tapGesture);

                glossaryJump.Children.Add(button);
            }

        }


        void Handle_ItemTapped(object sender, ItemTappedEventArgs e) => ((ListView)sender).SelectedItem = null;


    }
}