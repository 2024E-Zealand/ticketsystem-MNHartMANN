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
        private string _licensePlate;
        /// <summary>
        /// Gets or sets the license plate of a vehicle, and throws an exception if it is more than 7 characters.
        /// </summary>
        public string LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("License plate cannot be longer than 7 characters.");
                }
                _licensePlate = value;
            }
        }

        /// <summary>
        /// Gets or sets the date associated with a vehicle.
        /// </summary>
        public DateTime Date { get; set; }

        public bool Brobizz { get; set; }

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