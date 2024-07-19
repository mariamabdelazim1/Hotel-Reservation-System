using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
    internal class Hotel
    {
        public List<SeaView> SeaRooms { get; set; } //list of sea rooms.
        public List<PoolView> PoolRooms { get; set; } //list of pool rooms.
        public List<GardenView> GardenRooms { get; set; }//list of garden rooms.

        public List<Reservation> Reservations { get; set; }
        public Hotel()
        {
            SeaRooms = new List<SeaView>();
            PoolRooms = new List<PoolView>();
            GardenRooms = new List<GardenView>();
            Reservations = new List<Reservation>();
        }
        public void AddSeaRoom(SeaView room) //adding rooms.
        {
            SeaRooms.Add(room);
        }
        public void AddPoolRoom(PoolView room)
        {
            PoolRooms.Add(room);
        }
        public  void AddGardenRoom(GardenView room)
        {
            GardenRooms.Add(room);
        }
        public bool MakeReservation(Reservation reservation) //make reservations.
        {
            // Check if the room is available for the given date range
            if (Reservations.Any(r => r.room.roomNumber == reservation.room.roomNumber &&
                                      r.Datefrom <= reservation.Dateto &&
                                      r.Dateto >= reservation.Datefrom))
            {
                return false; // Room is not available
            }

            Reservations.Add(reservation);
            Display(reservation);
            Display(reservation.customer);
            return true;
        }
        public void CheckOut(Reservation reservation)
        {
            Reservations.Remove(reservation);
            Console.WriteLine("Successfully checked out.");
        }
        public void Display(Reservation reservation)//displays reservation details
        {
            Console.WriteLine("Reservation is Successful.");
            Console.WriteLine("Details: ");
            Console.WriteLine($"Room details :\n Room number {reservation.room.roomNumber}\n Room Capacity {reservation.room.capacity}");
            Console.WriteLine($"Date reserved : {reservation.Datefrom} to {reservation.Dateto}");
            Console.WriteLine($"Price is {reservation.FinalPrice()}");
        }
        public void Display(Customer customer)
        {
            Console.WriteLine($"Customer details :");
            Console.WriteLine($"Name is {customer.Name}\n Age is {customer.Age}\nEmail is {customer.Email}\nId is {customer.Id}\n");
        }
        public  void DisplayList()//displays reservation list
        {
            foreach (var reservation in Reservations)
            {
                Console.WriteLine($"Room Number: {reservation.room.roomNumber}");
                Console.WriteLine($"Date From: {reservation.Datefrom}");
                Console.WriteLine($"Date To: {reservation.Dateto}");
                Console.WriteLine($"Customer Name: {reservation.customer.Name}");
                Console.WriteLine(); // Empty line for separation between reservations
            }
        }
    }
}