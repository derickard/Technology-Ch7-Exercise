using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class TechnologyTests
    {

        Computer testComputer;
        Laptop testLaptop;
        SmartPhone testPhone;

        [TestInitialize]
        public void Initialize()
        {
            testComputer = new Computer(8, 3.2, 500);
            testLaptop = new Laptop(2.0, 16, 2.6, 256);
            testPhone = new SmartPhone(5.0, 12, 2.5, 128);
        }

        [TestMethod]
        public void EntityIdsAreUnique()
        {
            Assert.IsFalse( (testComputer.EntityID == testLaptop.EntityID) && (testComputer.EntityID == testPhone.EntityID) );
        }

        [TestMethod]
        public void TestComputerValuesAreCorrect()
        {
            Assert.AreEqual(8, testComputer.Ram, 0.001);
            Assert.AreEqual(3.2, testComputer.CpuSpeed, 0.001);
            Assert.AreEqual(500, testComputer.DiskSize, 0.001);
            Assert.IsFalse(testComputer.IsOn);
        }


        [TestMethod]
        public void TogglePowerTurnsComputerOnOff()
        {
            testComputer.TogglePower();
            Assert.IsTrue(testComputer.IsOn);
            testComputer.TogglePower();
            Assert.IsFalse(testComputer.IsOn);
        }

        [TestMethod]
        public void TestLaptopValuesAreCorrect()
        {
            Assert.AreEqual(2.0, testLaptop.Weight, 0.001);
            Assert.AreEqual(16, testLaptop.Ram, 0.001);
            Assert.AreEqual(2.6, testLaptop.CpuSpeed, 0.001);
            Assert.AreEqual(256, testLaptop.DiskSize, 0.001);
            Assert.IsFalse(testLaptop.IsOn);
        }

        [TestMethod]
        public void ToggleTabletChangesLaptopMode()
        {
            Assert.IsFalse(testLaptop.IsTabletMode);
            testLaptop.ToggleTabletMode();
            Assert.IsTrue(testLaptop.IsTabletMode);
        }

        [TestMethod]
        public void TestPhoneValuesAreCorrect()
        {
            Assert.AreEqual(5.0, testPhone.CameraMp, 0.001);
            Assert.AreEqual(12, testPhone.Ram, 0.001);
            Assert.AreEqual(2.5, testPhone.CpuSpeed, 0.001);
            Assert.AreEqual(128, testPhone.DiskSize, 0.001);
            Assert.IsFalse(testPhone.IsOn);
        }

        [TestMethod]
        public void PhoneTakesPicture()
        {
            Assert.AreEqual("Great shot!", testPhone.TakePicture());
        }
    }
}
