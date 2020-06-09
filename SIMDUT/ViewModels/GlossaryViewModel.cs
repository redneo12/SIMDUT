using MvvmHelpers;
using SIMDUT.Helpers;
using SIMDUT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SIMDUT.ViewModels
{
    public class GlossaryViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<GlossaryItem> Glossary { get; set; }
        public ObservableCollection<Grouping<string, GlossaryItem>> GlossaryGrouped { get; set; }
        public bool isVisible = false;


        public GlossaryViewModel()
        {
            try
            {


                var sorted = from s in GlossaryHelper.Glossary
                             orderby s.Element
                             group s by s.ElementSort into sGroup
                             select new Grouping<string, GlossaryItem>(sGroup.Key, sGroup);

                var glossaryItems = from s in GlossaryHelper.Glossary
                                    orderby s.Element
                                    select s;

                foreach (var item in glossaryItems)
                {
                    item.ToString().Replace("\n", Environment.NewLine);
                }
                //glossaryItems = glossaryItems.ToString().Replace("\n", Environment.NewLine);


                Glossary = new ObservableCollection<GlossaryItem>(glossaryItems);
                GlossaryGrouped = new ObservableCollection<Grouping<string, GlossaryItem>>(sorted);





                //Glossary = GlossaryHelper.Glossary;
                //GlossaryGrouped = GlossaryHelper.GlossaryGrouped;
                SetVisibility = new Command(() => IsVisible = !IsVisible);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR IN VW:" + e);
            }

        }

        public bool IsBusy { get; set; }
        public bool IsVisible
        {
            set
            {
                if (isVisible != value)
                {
                    isVisible = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsVisible"));
                }
            }
            get
            {
                return isVisible;
            }
        }

        public ICommand SetVisibility { private set; get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
