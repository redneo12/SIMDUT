
using SQLite;
using System;
using System.Collections.Generic;

namespace SIMDUT.Models
{
    public class ChecklistItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Item { get; set; }
        [MaxLength(255)]
        public string Notes { get; set; }
        public string Section { get; set; }
        public DateTime Date { get; set; }
        public bool IsChecked { get; set; }



    }
}
