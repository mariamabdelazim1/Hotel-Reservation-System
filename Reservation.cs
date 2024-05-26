using HotelReservationSystem;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem
{
    public class Reservation
    {

        public Room room { get; set; }
        public DateTime Datefrom { get; set; } //date of  checkin
        public DateTime Dateto { get; set; } // date of checkout
        public Customer customer { get; set; }
        public double price { get; set; }
        public double RoomPrice { get; set; }//gets the price depending the room type (seaView,gardenView,poolView)
        public int count_day { get; set; }//number of days the custmers will spend
        public string capacity { get; set; }// (single,double triple,sweet)
        public string inclusivity { get; set; }
        static int priceInc = 80;
        static int pricenonInc = 50;
        public Reservation(Room room, DateTime Datefrom, DateTime Dateto, Customer customer, string inclusivity)
        {
            this.room = room;
            this.Datefrom = Datefrom;
            this.Dateto = Dateto;
            this.customer = customer;
            this.price = room.roomPrice();
            //Console.WriteLine($"price in reservation constructor {price}");
            this.inclusivity = inclusivity;
        }
        public void incPrice()
        {
            if (inclusivity == "All Inclusive")
            {
                this.price += priceInc;
                //Console.WriteLine($"price in incprice constructor {price}");
            }
            else
            {
                this.price += pricenonInc;
            }
        }

        public int count_days() // calc the number of days the customer need
        {
            TimeSpan difference = Dateto - Datefrom;

            count_day = difference.Days + 1;
           // Console.WriteLine($"number of days is {count_day}");
            return count_day;
        }

        public double FinalPrice() // calc the total price of days you want to spend
        {
            incPrice();
            this.price = count_days() * price;
            return price;
        }
    }
}
