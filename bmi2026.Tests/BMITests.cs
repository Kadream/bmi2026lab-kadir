using BMICalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bmi2026.Tests
{
    [TestClass]
    public sealed class BMITests
    {
        [TestMethod]
        public void BMICategory_WhenMeasurementsAreNormal_ReturnsNormal()
        {
            var bmi = new BMI
            {
                WeightStones = 11,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 10
            };

            Assert.AreEqual(BMICategory.Normal, bmi.BMICategory);
        }

        [TestMethod]
        public void BMICategory_WhenBMIIsAboveThirty_ReturnsObese()
        {
            var bmi = new BMI
            {
                WeightStones = 20,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 6
            };

            Assert.AreEqual(BMICategory.Obese, bmi.BMICategory);
        }
    }
}