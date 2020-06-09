using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIMDUT
{
    public class SearchItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string MatchedString { get; set; }
        public string MatchedPage { get; set; }
    }
}