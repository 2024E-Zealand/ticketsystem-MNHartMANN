using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltMC : MC
    {
        /// <summary>
        /// Returns the price of an MC with Brobizz discount applied, without weekend discounts.
        /// </summary>
        public override double Price()
        {
            double basePrice = 125.0;
            double finalPrice = basePrice;

            // Apply Brobizz discount if applicable
            if (Brobizz)
            {
                finalPrice -= finalPrice * 0.05; // 5% Brobizz discount
            }

            return finalPrice;
        }
    }
}