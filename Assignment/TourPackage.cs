using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class TourPackage
    {
        public int PackageId { get; set; }
        public string? Destination { get; set; }
        public string? StartDate { get; set; }
        public double Price { get; set; }

        public static List<TourPackage> tourPackages = new List<TourPackage>();

        public TourPackage(int packageId, string? destination, string? startDate, double price)
        {
            PackageId = packageId;
            Destination = destination;
            StartDate = startDate;
            Price = price;
        }

        public static void TourReservation() {


            Console.WriteLine("Enter the Tour package id for booking");
            int packageId=Convert.ToInt32(Console.ReadLine());

            lock (tourPackages)               //lock the list(tour package) to prevent multiple access to list
            {
                var a = tourPackages.Find(x => x.PackageId == packageId);
                if (a == null)
                {
                    Console.WriteLine("id is not available");
                }
                else
                {
                    Console.WriteLine("Tour package booked Destination: {0}\t StartDate :{1}\t Price:{2}", a.Destination, a.StartDate, a.Price);
                }
            }
        }
    }
}
