using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC : Vehicle
    {
        /// <summary>
        /// Returns price of a MC with or without Brobizz discount.
        /// </summary>
        public override double Price()
        {
            double basePrice = 125.0;
            if (Brobizz)
            {
                return basePrice * 0.95;
            }
            return basePrice;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
