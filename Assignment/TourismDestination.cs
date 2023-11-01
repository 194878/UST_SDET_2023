using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, double? rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public double? Rating { get; set; }


        public void SortofList(List<TourismDestination> tourismdest) {
          var x=  tourismdest.OrderByDescending(x => x.Rating);

            foreach (var a in x) {
                Console.WriteLine("Name :{0} \n  Country :{1}\n  Rating: {2}",a.Name,a.Country,a.Rating);
            }
        }

    }
}
