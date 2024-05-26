using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem
{
    public class SeaView : Room
    {
        public SeaView()
        { }

        public SeaView(int number, string capacity) : base(number, capacity)
        { }
        public override double roomPrice()
        {
            double price = base.roomPrice();
            return price += 300.0;
        }
    }
}