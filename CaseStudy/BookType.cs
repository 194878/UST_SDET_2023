using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class BookType :Book
    {
        public BookType(string? Title, string? Author, int ISBN, int Price, string? Availability, string? genre) : base(Title, Author, ISBN, Price, Availability)
        {
            this.Genre = genre;
        }

        


        public string? Genre { get; set; }

    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Title of Book is:{Title}");
        Console.WriteLine($"Author name is :{Author}");
        Console.WriteLine($"isbn is :{ISBN}");
        Console.WriteLine($"Price of the book is :{Price}");
        Console.WriteLine($"Availability of book is :{Availability}");
        Console.WriteLine($"Book Tyoe  is :{Genre}");
    
    

    }
}
