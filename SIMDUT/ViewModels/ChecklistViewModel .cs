using MvvmHelpers;
using SIMDUT.Helpers;
using SIMDUT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;



namespace SIMDUT.ViewModels
{
    public class ChecklistViewModel : BaseViewModel
    {
        public ObservableCollection<ChecklistItem> DataList { get; set; }
        public bool IsBusy { get; set; }


        public int Id { get; set; }

        private string _item;
        private string _section;
        private string _notes;
        private DateTime _date;
        private bool _isChecked = false;

        public string Item
        {
            get { return _item; }
            set
            {
                SetValue(ref _item, value);
            }
        }

        public string Section
        {
            get { return _section; }
            set
            {
                SetValue(ref _section, value);
            }
        }


        public string Notes
        {
            get { return _notes; }
            set
            {
                SetValue(ref _notes, value);
                OnPropertyChanged(nameof(Notes));
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {

                SetValue(ref _date, value);
            }
        }

        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                SetValue(ref _isChecked, value);
                OnPropertyChanged(nameof(IsChecked));
            }
        }

        public ChecklistViewModel()
        {
            //get database results
            var checklistData = App.Database.GetChecklistAsync();

            this.DataList = new ObservableCollection<ChecklistItem>();

            foreach (var x in checklistData.Result)
            {
                //If date has been cleared, we want to initiate it to todays date
                if (DateTime.Equals(x.Date, new DateTime(0001, 01, 01)))
                {
                    x.Date = DateTime.Now;
                }

                //Add Database results to the collection so the View can populate absed off of the collection
                this.DataList.Add(x);
                Console.WriteLine("=====Adding item to checklist:" + x.Item + " || nb of items in result: " + checklistData.Result.Count);
            }
        }






        public object UpdateNotes(ChecklistItem item)
        {
            Console.WriteLine("SAVE INFORMATIONG ChecklistViewModel");

            Item = item.Item;
            Notes = item.Notes;
            Date = item.Date;
            IsChecked = item.IsChecked;
            return App.Database.SaveChecklist(item);
        }

    }

}
