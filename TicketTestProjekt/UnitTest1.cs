using TicketClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketTestProjekt
{
    [TestClass()]
    public class CarTests
    {
        /// <summary>
        /// Tests that the Price method returns the price 240.
        /// </summary>
        [TestMethod]
        public void Price_ShouldReturnCorrectPrice()
        {
            // Arrange
            var car = new Car();

            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(240.0, result);
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
