using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCardCatalog
{
    class CardCatalog
    {
        private string _filename;

        private List<Books> books = new List<Books>();


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
                    b.Title, b.Author, b.Fiction, b.NonFiction, b.YearPublished);
            }

        }
        //method to add the books
        public void AddBook()
        {
            Console.WriteLine("Please enter the Title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Please enter the Author: ");
            string author = Console.ReadLine();

            Console.WriteLine("Please enter the Year Published: ");
            string year = Console.ReadLine();

            Books book = new Books();
            book.Title = title;
            book.Author = author;


            books.Add(book);

        }

        //method to save the books
        public void Save()
        {

        }
    }
}
