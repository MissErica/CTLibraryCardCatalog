using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibraryCardCatalog
{
    [Serializable()]
    public class Books// : //ISerializable
    {
        public string Title { get; set; }
        public string Author { get; set; }
       // public string Fiction { get; set; }
       // public string NonFiction { get; set; }
        public string YearPublished { get; set; }

        public Books() {    }

        public Books(
            string title, 
            string author, 
            //string fiction,
            //string nonfiction, 
            string year)
        {
            this.Title = title;
            this.Author = author;
            //this.Fiction = fiction;
           // this.NonFiction = nonfiction;
            this.YearPublished = year;
        }
        //internal void AddBooks()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
