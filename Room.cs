using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem
{
    public class Room
    {

        public string capacity { get; set; }// (single,double triple,suite)

        public double price { get; set; }
        public int roomNumber { get; set; }

        public Room() { }

        public Room(int roomnumber, string capacity)
        {
            this.roomNumber = roomnumber;
            this.capacity = capacity;

        }


        public virtual double roomPrice()
        {
            double priceCapacity = 0;

            {
                if (this.capacity == "suite" || this.capacity == "Suite")
                {
                    priceCapacity = 70;
                }
                else if (this.capacity == "triple" || this.capacity == "Triple")
                {
                    priceCapacity = 50;
                }
                else if (this.capacity == "double" || this.capacity == "Double")
                {
                    priceCapacity = 30;
                }
                else if (this.capacity == "single" || this.capacity == "Single")
                {
                    priceCapacity = 10;
                }
                price = priceCapacity;
                return price;
            }


        }



    }
}
