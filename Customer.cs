using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem
{
    public class Customer
    {
        public string Name { get; }

        public int Age { get; }

        public string Email { get; }

        public string Id { get; }

        public Customer(string Name, int Age, string Email, string Id)
        {
            this.Name = Name;
            this.Age = (Age >= 18) ? Age : 0;
            this.Email = Email;
            this.Id = Id;
        }

    }
}