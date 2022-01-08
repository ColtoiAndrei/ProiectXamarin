using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProiectXamarin.Models
{
    public class MovieList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}
