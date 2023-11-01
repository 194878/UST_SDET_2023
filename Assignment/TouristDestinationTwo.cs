using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class TouristDestinationTwo
    {
        public TouristDestinationTwo(string? name, string? location, double rating, double pricePerNight)
        {
            Name = name;
            Location = location;
            Rating = rating;
            PricePerNight = pricePerNight;
        }

        public string? Name { get; set; }
        public string? Location { get; set; }

        public double Rating { get; set; }

        public double PricePerNight { get; set; }


        public static List<TouristDestinationTwo> two = new List<TouristDestinationTwo>(); 
       
        public void TopRated(double rating) {
            var x = two.FindAll(x => x.Rating>rating);

            foreach (var a in x)
            {
                Console.WriteLine("Name :{0} \n  Country :{1}\n  Rating: {2}\n PriceperNight :{3}", a.Name, a.Location, a.Rating,a.PricePerNight);
            }

        }
        public void SortedRate() {
            var x = two.OrderBy(x =>x.PricePerNight);

            foreach (var a in x)
            {
                Console.WriteLine("Name :{0} \n  Country :{1}\n  Rating: {2}\n PriceperNight :{3}", a.Name, a.Location, a.Rating, a.PricePerNight);
            }


        }
        public void FilterwithCityName(string? cityname) {

            var x = two.FindAll(x => x.Location==cityname);

            foreach (var a in x)
            {
                Console.WriteLine("Name :{0} \n  Country :{1}\n  Rating: {2}\n PriceperNight :{3}", a.Name, a.Location, a.Rating, a.PricePerNight);
            }

        }
    }
}
