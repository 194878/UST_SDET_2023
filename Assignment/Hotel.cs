using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Hotel:TourismDestination
    {
        int currentrooms = 10;
        public Hotel(string? hotelName, int availableRoom, string? name, string? country, double? rating):base(name,country,rating)
        {
            HotelName = hotelName;
            AvailableRoom = availableRoom;
        }

        public string? HotelName { get; set; }
        public int AvailableRoom { get; set;}

        public async Task HotelRoomReserve(int hotelreservation) {

            if (hotelreservation <= AvailableRoom)
            {


                await Task.Delay(1000);
                AvailableRoom -= hotelreservation;
                Console.WriteLine("Room Booked: Hotel Name:{0}\t Room Left: {1}", HotelName, AvailableRoom);



            }
            else {
                await Console.Out.WriteLineAsync("Room not booked");
            }
        
        
        }
    }
}
