using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2017.Models
{
    public class ListOfBookViewModel
    {
        public List<Book> ListOfBook;
    }
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
    }
}
