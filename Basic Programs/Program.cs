
//driver
using Basic_Programs;
Electricity electricity1 = new (12345,9000,9300,"XX");
Console.WriteLine(electricity1.consumernumber);
Console.WriteLine(electricity1.consumername);
Console.WriteLine(electricity1.CalculateBill());
Electricity electricity2 = new(23456, 9000, 10000, "XX");
Console.WriteLine(electricity2.consumernumber);
Console.WriteLine(electricity2.consumername);
Console.WriteLine(electricity2.CalculateBill());

