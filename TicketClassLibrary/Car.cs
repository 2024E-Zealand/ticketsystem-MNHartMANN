﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Returns the price of a car with or without Brobizz discount and applies weekend discount.
        /// </summary>
        public override double Price()
        {
            double basePrice = 240.0;
            double finalPrice = basePrice;

            // Check if the date is Saturday or Sunday for the weekend discount
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                finalPrice -= finalPrice * 0.20; // 20% discount for weekends
            }

            // Apply Brobizz discount if applicable
            if (Brobizz)
            {
                finalPrice -= finalPrice * 0.05; // 5% Brobizz discount
            }

            return finalPrice;
        }

        /// <summary>
        /// Returns the vehicle type as a string.
        /// </summary>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}