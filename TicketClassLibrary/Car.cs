using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class Car
    {
        /// <summary>
        /// Gets or sets the license plate of a car.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with a car.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price of a car, which is 240.
        /// </summary>
        public double Price()
        {
            return 240.0;
        }

        /// <summary>
        /// Returns the type of vehicle, which is a Car.
        /// </summary>
        public string VehicleType()
        {
            return "Car";
        }
    }
}