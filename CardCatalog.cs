using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCardCatalog
{
    public class CardCatalog
    {
        private string _filename;

        private List<Books> books = new List<Books>(); //private member variable that contains all of the books


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

        }
        //method to add the books
        public void AddBook(string title, string author, int year)
        {
            Console.WriteLine("Please enter the Title: ");
            title = Console.ReadLine();

            Console.WriteLine("Please enter the Author: ");
             author = Console.ReadLine();

            Console.WriteLine("Please enter the Year Published: ");
            year = Convert.ToInt32(Console.ReadLine());

            //Books book = new Books();
           //Title = title;
           //Author = author;
           //YearPublished = year;


            //books.Add(book);

        }

        //method to save the books
        public void Save()
        {

        }
    }
}
