﻿using SQLite;
using System;

namespace SIMDUT.Models
{
    public class NoteItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
