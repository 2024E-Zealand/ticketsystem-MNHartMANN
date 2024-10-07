using TicketClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketTestProjekt
{
    [TestClass()]
    public class MCTests
    {
        /// <summary>
        /// Tests that the Price method returns the price 125.
        /// </summary>
        [TestMethod]
        public void Price_ShouldReturnCorrectPrice()
        {
            // Arrange
            var mc = new MC();

            // Act
            double result = mc.Price();

            // Assert
            Assert.AreEqual(125.0, result);
        }

        /// <summary>
        /// Tests that the VehicleType method returns "MC".
        /// </summary>
        [TestMethod]
        public void VehicleType_ShouldReturnMC()
        {
            // Arrange
            var mc = new MC();

            // Act
            string result = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", result);
        }
    }
}