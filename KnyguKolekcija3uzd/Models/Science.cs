using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnyguKolekcija3uzd.Models
{
    internal class Science : Book
    {
        public string Topic { get; set; }

        public Science(string topic, string title, string author, DateOnly year)
        {
            Topic = topic;
            Title = title;
            Author = author;
            Year = year;
        }
    }
}
