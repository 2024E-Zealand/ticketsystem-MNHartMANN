using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC : Vehicle
    {
        public override double Price()
        {
            return 125.0;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
