using TicketClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketTestProjekt
{
    [TestClass()]
    public class CarTests
    {
        /// <summary>
        /// Tests if the Car price includes a 5% discount when Brobizz is used.
        /// </summary>
        [TestMethod]
        public void Car_Price_ShouldApplyBrobizzDiscount()
        {
            // Arrange
            var car = new Car { Brobizz = true };

            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(240.0 * 0.95, result, 0.01);
        }

        /// <summary>
        /// Tests if the Car price remains unchanged without Brobizz.
        /// </summary>
        [TestMethod]
        public void Car_Price_ShouldNotApplyBrobizzDiscount_IfNotUsed()
        {
            // Arrange
            var car = new Car { Brobizz = false };

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
