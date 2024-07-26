using KnyguKolekcija3uzd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnyguKolekcija3uzd.Services
{
    internal class BookListService : Book
    {
        public List<Book> AllBooks { get; set; }

        public BookListService()
        {
            AllBooks = new List<Book>();
        }
    }
}
