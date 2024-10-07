using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// Is a class of vehicle wich Car and MC uses, with normal properties of license plate and date.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Gets or sets the license plate of a vehicle.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with a vehicle.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price of a vehicle. This method must be overridden by the classes that uses it.
        /// </summary>
        public abstract double Price();

        /// <summary>
        /// Returns the type of a vehicle. This method must be overridden by the classes that uses it.
        /// </summary>
        public abstract string VehicleType();
    }
}