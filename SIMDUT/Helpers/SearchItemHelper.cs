using SIMDUT.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SIMDUT.Helpers
{
    public class SearchItemHelper
    {
        public static ObservableCollection<SearchItem> SearchItem { get; set; }


        static SearchItemHelper()
        {
            SearchItem = new ObservableCollection<SearchItem>();


            SearchItem.Add(new SearchItem
            {
                MatchedString = "",
                MatchedPage = "",
            });







            /**
             * 
             * Run through Glossary and add to Querry items
             * 
             **/

            foreach (GlossaryItem gi in GlossaryHelper.Glossary)
            {
                SearchItem.Add(new SearchItem
                {
                    MatchedString = gi.Element,
                    MatchedPage = "<TODO> IF DEFINITION HAS A PAGE RELATED; LINK IT UP",
                });
            }
        }

        internal static ObservableCollection<SearchItem> GetSearchResults(string queryString)
        {
            var normalizedQuery = queryString?.ToUpper() ?? "";

            var returStr = from s in SearchItem
                           where s.MatchedString.ToUpper().Contains(normalizedQuery) ||
                            s.MatchedPage.ToUpper().Contains(normalizedQuery)
                           select s;
            return new ObservableCollection<SearchItem>(returStr);
        }
    }
}