using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC
    {
        /// <summary>
        /// Gets or sets the license plate of a MC.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with a MC.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price of a MC, which is 125.
        /// </summary>
        public double Price()
        {
            return 125.0;
        }

        /// <summary>
        /// Returns the type of vehicle, which is a MC.
        /// </summary>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
