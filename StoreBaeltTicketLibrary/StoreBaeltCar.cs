using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
    {
        /// <summary>
        /// Returns the price of a car with weekend and Brobizz discounts applied.
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
    }
}
