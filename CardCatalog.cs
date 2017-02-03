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
    public class CardCatalog
    {
        private string _filename;

        private List<Books> books = new List<Books>(); 
        //private member variable that contains all of the books


        public CardCatalog(string fileName) 
        {
            this._filename = fileName;
        }

        //method to list all the books in the catalog
        public void ListBooks()
        {
            foreach (var b in books)
            {
                Console.WriteLine("Title: {0} \nAuthor: {1} \nGenre: {2} \nYear Published: {3}",
                    b.Title,
                    b.Author, //b.Fiction, b.NonFiction,
                    b.YearPublished);
            }

            //deserialization shoud be placed here

        }
        //method to add the books
        public void AddBook()
        {
            Console.Clear();
            Console.Write("Please enter the Title: ");
            string title = Console.ReadLine();

            Console.Write("Please enter the Author: ");
            string author = Console.ReadLine();

            Console.Write("Please enter the Year Published: ");
            string year = Console.ReadLine();

            Console.Write(title + "successfully added into your catalog.");
            Books book = new Books();
            book.Title = title;
            book.Author = author;
            book.YearPublished = year;
            //books.Add(book);
            //serialization should be placed here
        }

        //method to save the books
        public void Save()
        { 
            
        }
    }
}
