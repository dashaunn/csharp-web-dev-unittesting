using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        Car test_car;

        [TestInitialize]
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }
        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestInitialGasTank()
        {
            //Car test_car = new Car("Toyota", "Prius", 10, 50);
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }

        [TestMethod]
        public void TestInitialGasTank2()
        {
            //Car test_car = new Car("Toyota", "Prius", 10, 50);
            Assert.IsFalse(test_car.GasTankLevel == 0);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        //TODO: can't have more gas than tank size, expect an exception

    }
}
