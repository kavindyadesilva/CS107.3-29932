using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_02__Q5_
{
    class LibraryBook

    {
        public string Title;
        public string Author;
        public bool Available;

            public LibraryBook(string title,string author)
        {
            Title = title;
            Author = author;
            Available = true;
        }
        public void BorrowBook()
        {
            if(Available)
            {
                Available = false;
                Console.WriteLine($"Book'{Title}' by{Author} has been borrowed");
            }
            else
            {
                Console.WriteLine($"book'{Title}' by {Author} is not available");
            }
        }
    }
    class Library
    {
        public List<LibraryBook> Books;

        public Library()
        {
            Books = new List<LibraryBook>();
        }
        public void AddBook(LibraryBook book)
        {
            Books.Add(book);
        }
        public void DisplayLibraryStatus()
        {
            Console.WriteLine("Library Status");
            foreach(var book in Books)
            {
                Console.WriteLine($"Title:{book.Title},Author:{book.Author},Available:{(book.Available ? "yes":"no")}");

            }
        }
    }
    class Program
    {
      static void Main(string[]args)
        {
            Library library = new Library();

            library.AddBook(new LibraryBook("Nectar in a Sieve", "Kamala Markandaya"));
            library.AddBook(new LibraryBook("Bringing Tony Home", "Tissa Abeysekara"));
            library.AddBook(new LibraryBook("Life of Pi", "Yann Martel"));

            library.DisplayLibraryStatus();

            library.Books[0].BorrowBook();

            library.DisplayLibraryStatus();

            Console.ReadLine();
        }
    }
}
