using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnyguKolekcija3uzd.Models
{
    internal class Novel : Book
    {
        public string Genre { get; set; }

        public Novel (string genre, string title, string author, DateOnly year)
        {
            Genre = genre;
            Title = title;
            Author = author;
            Year = year;
        }
    }
}
