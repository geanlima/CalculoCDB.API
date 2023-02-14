using CalculoCDB.API.Application;

namespace CalculoCDB.Test
{
    [TestClass]
    public class CDBServiceTests
    {
        private CDBService _cdbService;

        [TestInitialize]
        public void Setup()
        {
            _cdbService = new CDBService();
        }

        [TestMethod]
        public void TestTaxCalculationUpTo6Months()
        {
            // Arrange
            var initialValue = 1000;
            var months = 6;
            var expectedTax = 782.53;

            // Act
            var calculatedTax = _cdbService.CalculateCDB(initialValue, months);

            // Assert
            Assert.AreEqual(expectedTax, calculatedTax);
        }

        [TestMethod]
        public void TestTaxCalculationUpTo12Months()
        {
            // Arrange
            var initialValue = 1000;
            var months = 12;
            var expectedTax = 807.78;

            // Act
            var calculatedTax = _cdbService.CalculateCDB(initialValue, months);

            // Assert
            Assert.AreEqual(expectedTax, calculatedTax);
        }

        [TestMethod]
        public void TestTaxCalculationUpTo24Months()
        {
            // Arrange
            var initialValue = 1000;
            var months = 24;
            var expectedTax = 833.02;

            // Act
            var calculatedTax = _cdbService.CalculateCDB(initialValue, months);

            // Assert
            Assert.AreEqual(expectedTax, calculatedTax);
        }

        [TestMethod]
        public void TestTaxCalculationAbove24Months()
        {
            // Arrange
            var initialValue = 1000;
            var months = 36;
            var expectedTax = 858.26;

            // Act
            var calculatedTax = _cdbService.CalculateCDB(initialValue, months);

            // Assert
            Assert.AreEqual(expectedTax, calculatedTax);
        }
    }
}