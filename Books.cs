using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCardCatalog
{
    class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Fiction { get; set; }
        public string NonFiction { get; set; }
        public int YearPublished { get; set; }

            public Books()
            {

            }

            public Books(string title, string author, string fiction, string nonfiction, int year)
            {
                this.Title = title;
                this.Author = author;
                this.Fiction = fiction;
                this.NonFiction = nonfiction;
                this.YearPublished = year;
            }
        }
}
