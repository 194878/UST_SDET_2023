using CaseStudy;
using static System.Reflection.Metadata.BlobBuilder;

Customer1 customer11 = new Customer1();
customer11.CustomerID = 1;
customer11.CustomerName = "Manu";
customer11.CustomerEmail = "Manu@ust";
Customer1.customers.Add(customer11);
Customer1 customer12 = new Customer1();
customer12.CustomerID = 2;
customer12.CustomerName = "shnu";
customer12.CustomerEmail = "shnu@ust";
Customer1.customers.Add(customer12);
Customer1 customer13 = new Customer1();
customer13.CustomerID = 3;
customer13.CustomerName = "kasu";
customer13.CustomerEmail = "kasu@ust";
Customer1.customers.Add(customer13);

while (true)
{
    Console.WriteLine("choose your option\n1.User\n2.Admin");
    int option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)

    {
        Console.WriteLine("Enter the customer id");
        int cusId = Convert.ToInt32(Console.ReadLine());
        if (Customer1.customers.Find(x => x.CustomerID == cusId) == null)
        {
            Console.WriteLine("Customer not found");
            break;
        }
        while (true)
        {
            Console.WriteLine("choose your option\n1.Add product to cart\n2.view all product\n3.place order\n4.Support\n5.view orders");
            int optionuser = Convert.ToInt32(Console.ReadLine());

            switch (optionuser)
            {

                case 1:

                    Console.WriteLine("Enter Product id for add to cart");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    Customer1 customer1 = Customer1.customers.Find(x => x.CustomerID == cusId);
                    if (DigitalProduct.Products.Find(x => x.ProductId == productId) == null)
                    {
                        if (PhysicalProduct.Products.Find(x => x.ProductId == productId) == null)
                        {
                            Console.WriteLine("invalid product id");
                        }
                        else
                        {
                            customer1.ordersphy.Add(PhysicalProduct.Products.Find(x => x.ProductId == productId));
                            Console.WriteLine("product added to cart");
                        }
                    }
                    else
                    {
                        customer1.orders.Add(DigitalProduct.Products.Find(x => x.ProductId == productId));
                        Console.WriteLine("product added to cart");
                    }
                    break;
                case 2:
                    Console.WriteLine("Products are");
                    if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
                    {
                        Console.WriteLine("No Product Found found");
                    }
                    foreach (var item in DigitalProduct.Products)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                            item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                    }
                    foreach (var item in PhysicalProduct.Products)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                            "\tDimension:{5}", item.ProductId,
                            item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                    }
                    break;
                case 3:
                    Customer1 customer = Customer1.customers.Find(x => x.CustomerID == cusId);
                    if (customer.orders.Count == 0 && customer.ordersphy.Count == 0)
                    {
                        Console.WriteLine("no product found in cart");
                    }
                    else
                    {
                        foreach (var item in customer.orders)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                             item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                            item.PlacingOrder();
                            item.ProcessingPayment();
                            item.DeliveringProduct();

                        }
                        foreach (var item in customer.ordersphy)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                           "\tDimension:{5}", item.ProductId,
                           item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                            item.PlacingOrder();
                            item.ProcessingPayment();
                            item.DeliveringProduct();
                        }
                        Console.WriteLine("do you want to place all the order\n1.yes\n2.no");
                        int confirm = Convert.ToInt32(Console.ReadLine());
                        if (confirm == 1)
                        {
                            customer.confirmedorders.AddRange(customer.orders);
                            customer.orders.Clear();
                            customer.confirmedordersphy.AddRange(customer.ordersphy);
                            customer.ordersphy.Clear();
                            Console.WriteLine("order placed successfully");
                        }
                        else
                        {
                            Console.WriteLine("removing everything in cart");
                        }


                    }



                    break;
                case 4:
                    Console.WriteLine("call this number for support 99999999999");
                    break;
                case 5:
                    Customer1 customer2 = Customer1.customers.Find(x => x.CustomerID == cusId);
                    if (customer2.confirmedorders.Count == 0 && customer2.confirmedordersphy.Count == 0)
                    {
                        Console.WriteLine("no order details found");
                    }
                    else
                    {
                        Console.WriteLine("Orders are");
                        foreach (var item in customer2.confirmedorders)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                            item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                        }
                        foreach (var item in customer2.confirmedordersphy)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                           "\tDimension:{5}", item.ProductId,
                           item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("invalid input");

                    break;
            }

            Console.WriteLine("do you want to continue as user\n1.yes\n2.no");
            int optuser = Convert.ToInt32(Console.ReadLine());
            if (optuser == 1)
            {
                continue;
            }
            else if (optuser == 2)
            {
                break;
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }


    }

    else if (option == 2)
    {
        Console.WriteLine("choose option\n1.Add Product\n2.View report");
        int optionadmin = Convert.ToInt32(Console.ReadLine());
        if (optionadmin == 1)
        {
            Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
            int optionProduct = Convert.ToInt32(Console.ReadLine());
            if (optionProduct == 1)
            {
                Console.WriteLine("Enter Product id");
                int productid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Name");
                string? productName = Console.ReadLine();
                Console.WriteLine("enter the price");
                double productCost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the fileformat");
                string? fileFormat = Console.ReadLine();
                Console.WriteLine("Enter downloadLink");
                string? downloadLink = Console.ReadLine();
                Console.WriteLine("Enter the Quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());


                DigitalProduct digitalProduct = new DigitalProduct();
                digitalProduct.ProductName = productName;
                digitalProduct.ProductId = productid;
                digitalProduct.FileFormat = fileFormat;
                digitalProduct.DownloadLink = downloadLink;
                digitalProduct.Price = productCost;
                digitalProduct.ProductQuantity = quantity;
                DigitalProduct.Products.Add(digitalProduct);
            }
            else if (optionProduct == 2)
            {
                Console.WriteLine("Enter Product id");
                int productid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Name");
                string? productName = Console.ReadLine();
                Console.WriteLine("enter the price");
                double productCost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Weight");
                int weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter dimension");
                string? dimension = Console.ReadLine();
                Console.WriteLine("Enter the Quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());

                PhysicalProduct physicalProduct = new PhysicalProduct();
                physicalProduct.ProductName = productName;
                physicalProduct.ProductId = productid;
                physicalProduct.Price = productCost;
                physicalProduct.Dimension = dimension;
                physicalProduct.Weight = weight;
                physicalProduct.ProductQuantity = quantity;


                PhysicalProduct.Products.Add(physicalProduct);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        else if (optionadmin == 2)
        {
            Console.WriteLine("User list is ");
            foreach (var item1 in Customer1.customers)
            {

                Console.WriteLine("customer name:{0}", item1.CustomerName);
            }
            Console.WriteLine("Total product available are");
            if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
            {
                Console.WriteLine("No Product Found found");
            }
            foreach (var item in DigitalProduct.Products)
            {

                Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                    item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
            }
            foreach (var item in PhysicalProduct.Products)
            {

                Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                    "\tDimension:{5}", item.ProductId,
                    item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
            }


        }
    

}


    else
    {
        Console.WriteLine("invalid option");
    }

    Console.WriteLine("do you want to continue\n1.yes\n2.no");
    int opt = Convert.ToInt32(Console.ReadLine());
    if (opt == 1)
    {
        continue;
    }
    else if (opt == 2)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("invalid input");
    }

}
















/*
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
                booktype = booktype.);

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
                    Console.WriteLine($"Book totalcost is :",order.TotalCost);
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
*/