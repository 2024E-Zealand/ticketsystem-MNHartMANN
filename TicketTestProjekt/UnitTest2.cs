using TicketClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketTestProjekt
{
    [TestClass()]
    public class MCTests
    {
        /// <summary>
        /// Tests if the MC price includes a 5% discount when Brobizz is used.
        /// </summary>
        [TestMethod]
        public void MC_Price_ShouldApplyBrobizzDiscount()
        {
            // Arrange
            var mc = new MC { Brobizz = true };

            // Act
            double result = mc.Price();

            // Assert
            Assert.AreEqual(125.0 * 0.95, result, 0.01);
        }

        /// <summary>
        /// Tests if the MC price remains unchanged without Brobizz.
        /// </summary>
        [TestMethod]
        public void MC_Price_ShouldNotApplyBrobizzDiscount_IfNotUsed()
        {
            // Arrange
            var mc = new MC { Brobizz = false };

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