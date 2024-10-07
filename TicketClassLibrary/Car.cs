using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class Car : Vehicle
    {
        public override double Price()
        {
            return 240.0;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}