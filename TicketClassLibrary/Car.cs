using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Returns price of a car with or without Brobizz discount.
        /// </summary>
        public override double Price()
        {
            double basePrice = 240.0;
            if (Brobizz)
            {
                return basePrice * 0.95;
            }
            return basePrice;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}