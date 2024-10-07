using TicketClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;

namespace TicketTestProjekt
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void MCPrice_NoDiscount_Weekend()
        {
            var mc = new StoreBaeltMC { Date = new DateTime(2024, 10, 5) }; // Saturday
            double price = mc.Price();
            Assert.AreEqual(125.0, price); // No discount for MC on weekends
        }

        [TestMethod()]
        public void MCPrice_NoDiscount_Weekday()
        {
            var mc = new StoreBaeltMC { Date = new DateTime(2024, 10, 4) }; // Friday
            double price = mc.Price();
            Assert.AreEqual(125.0, price); // No discount on weekdays
        }

        [TestMethod()]
        public void MCPrice_ApplyBrobizzDiscount()
        {
            var mc = new StoreBaeltMC { Date = new DateTime(2024, 10, 4), Brobizz = true }; // Weekday
            double priceWithBrobizz = mc.Price();
            Assert.AreEqual(118.75, priceWithBrobizz, 0.01); // 125 - 5%
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

        /// <summary>
        /// Tests if a license plate with 7 characters is accepted.
        /// </summary>
        [TestMethod]
        public void LicensePlate_ShouldAcceptValidLicensePlate()
        {
            // Arrange
            Vehicle mc = new MC();

            // Act
            mc.LicensePlate = "AB12345";

            // Assert
            Assert.AreEqual("AB12345", mc.LicensePlate);
        }
    }
}