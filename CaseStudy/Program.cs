using CaseStudy;
using static System.Reflection.Metadata.BlobBuilder;

int number = 1;
string? Title;

do {
    Console.WriteLine("Ac book store " );
    Console.WriteLine("1.Add Book\n 2.Add Customer\n 3.Place Order\n 4.Search Book\n 5.View Order\n 6.Exit");

    Console.WriteLine("Choose The Option");
 int option=Convert.ToInt32( Console.ReadLine() );
    Order order=new Order();
    BookType[] booktype=new BookType[option];
    { 
        new("Manorama","Ammu",30,1000,"yes","Fiction"),
            new("Manorama","Anu",20, 1300,"yes","Fiction"),

    };
    switch (option)
    {
        case 1:

            Console.WriteLine("Book added successfully");
            foreach ( BookType book in booktype )
            {
                booktype = booktype.DisplayDetails();

            }
            break;
            case 2:
            int customerid;
            string? customerName;
            double phonenumber;
            Console.WriteLine("Enter Customer Id");
            customerid = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Enter Customer Name");
            customerName = Convert.ToString( Console.ReadLine() );
            Console.WriteLine("Enter Phone Number");
            phonenumber = Convert.ToDouble( Console.ReadLine() );

            Customer customer= new Customer(customerid, customerName ,phonenumber);
            customer.DisplayCustomer();
            break;
            case 3:

            Console.WriteLine("Enter title of book");
            Title=Console.ReadLine();
            foreach (var book in booktype) {
                if (book.Title.Equals(Title))
                {
                    Console.WriteLine("Enter order date");
                    order.OrderDate = Console.ReadLine();
                    Console.WriteLine("order confirmed");
                    Console.WriteLine($"Book title is :{book.Title}");
                    Console.WriteLine($"Book price is :{book.Price}");
                    Console.WriteLine($"Book avaialability is :{book.Availability}");
                    order.TotalCost = book.Price;
                    Console.WriteLine($"Book totalcost is :{book.Totalcost}");
                }
                else {
                    Console.WriteLine("No book available");
                }
            }
            break;
            case 4:
            Console.WriteLine("Enter the title of book");
            Title= Console.ReadLine();
            foreach (var book in booktype)
            {
                if (book.Title.Equals(Title)) {
                    Console.WriteLine($"Book title is :{book.Title}");
                    Console.WriteLine($"Book price is :{book.Price}");
                    Console.WriteLine($"Book availability is :{book.Availability}");
                    order.TotalCost= book.Price;
                    Console.WriteLine($"Book totalcost is :{order.TotalCost}");
                }
                else
                {
                    Console.WriteLine("no book available");
                }
            }
            break;
            case 5:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("INvalid option");
            break;


    }
    Console.WriteLine("Do you want to continue press1 or 0for exit");
    number=Convert.ToInt32(Console.ReadLine());


}while(number!=0);
