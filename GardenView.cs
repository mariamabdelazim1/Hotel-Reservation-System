using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem
{
    public  class GardenView : Room
    {
        public GardenView() { }
        public GardenView(int number, string capacity) : base(number, capacity)
        { }
        public override double roomPrice()
        {
            double price = base.roomPrice();
            return price += 200.0;
        }
    }
}
