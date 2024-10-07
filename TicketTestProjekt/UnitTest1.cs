using TicketClassLibrary;
using StoreBaeltTicketLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketTestProjekt
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarPrice_ApplyWeekendDiscount_Saturday()
        {
            var car = new StoreBaeltCar { Date = new DateTime(2024, 10, 5) }; // Saturday
            double price = car.Price();
            Assert.AreEqual(192.0, price, 0.01); // 240 - 20%
        }

        [TestMethod()]
        public void CarPrice_NoDiscount_Weekday()
        {
            var car = new StoreBaeltCar { Date = new DateTime(2024, 10, 4) }; // Friday
            double price = car.Price();
            Assert.AreEqual(240.0, price); // No discount on weekdays
        }

        [TestMethod()]
        public void CarPrice_ApplyBrobizzDiscount_AfterWeekendDiscount()
        {
            var car = new StoreBaeltCar { Date = new DateTime(2024, 10, 5), Brobizz = true }; // Saturday
            double priceWithBrobizz = car.Price();
            Assert.AreEqual(182.40, priceWithBrobizz, 0.01); // (240 - 20%) - 5%
        }

        /// <summary>
        /// Tests that the VehicleType method returns "Car".
        /// </summary>
        [TestMethod]
        public void VehicleType_ShouldReturnCar()
        {
            // Arrange
            var car = new Car();

            // Act
            string result = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", result);
        }

        /// <summary>
        /// Tests that an exception is thrown when the license plate is more than 7 characters.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicensePlate_ShouldThrowException_WhenLongerThan7Characters()
        {
            // Arrange
            Vehicle car = new Car();

            // Act
            car.LicensePlate = "AB123456";
        }
    }
}
