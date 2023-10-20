// See https://aka.ms/new-console-template for more information
using Assignment;

Console.WriteLine("1.Electronic Product 2.Digital Product 3.Clothing Product");
switch (Convert.ToInt32(Console.ReadLine())) {

    case 1:
        ElectronicProduct ep = new(2, "Pixel", 25000, 1);
        ep.DisplayProductDetails();
        ep.DisplayWarrantyPeriod();
        break;

        case 2:
        DigitalProduct dp = new DigitalProduct("PDF", 2, "L G", 500000, 1);
        dp.DisplayProductDetails();
        dp.DisplayWarrantyPeriod();
        dp.DisplayDigitalProduct();
        break;

        case 3:
        ClothingProduct cp = new("medium", "kurti", 3000, 2);
        cp.DisplayProductDetails();
        cp.DisplayClothingProduct();
        break;

}