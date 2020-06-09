using SIMDUT.Models;
using SIMDUT.Helpers;
using SIMDUT.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIMDUT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPageView : CarouselPage
    {
        int pageId;
        IOrderedEnumerable<PocketGuideItem> pageList;

        public CarouselPageView(PocketGuideItem pg)
        {
            InitializeComponent();



            pageList = from p in PocketGuideHelper.Index
                       orderby p.Id
                       select p;

            foreach (var p in pageList)
            {

                this.Children.Add((ContentPage)Activator.CreateInstance(p.TargetType));
            }

            updatePageDetails(pg.Id - 1);
            this.CurrentPageChanged += MainPageCS_CurrentPageChanged;
        }

        private void updatePageDetails(int id)
        {
            pageId = id;
            CurrentPage = Children[pageId];
            Title = pageList.ElementAt(pageId).Title;


            if (pageId - 1 < 0)
            {
                BtnPrevious.IsEnabled = false;
            }
            else
            {
                BtnPrevious.IsEnabled = true;
            }
            if (pageId + 1 >= pageList.Count())
            {
                BtnNext.IsEnabled = false;
            }
            else
            {
                BtnNext.IsEnabled = true;
            }
        }

        private void MainPageCS_CurrentPageChanged(object sender, System.EventArgs e)
        {
            updatePageDetails(Children.IndexOf(CurrentPage));
        }

        private void OnPreviousClicked(object sender, EventArgs e)
        {
            updatePageDetails(pageId - 1);
        }

        private void OnNextClicked(object sender, EventArgs e)
        {
            updatePageDetails(pageId + 1);
        }
    }
}