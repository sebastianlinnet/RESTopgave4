using Microsoft.VisualStudio.TestTools.UnitTesting;
using opgave4.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opgave4.Models;

namespace opgave4.Managers.Tests
{
    [TestClass()]
    public class CarManagerTests
    {
        private int nextID = 1;
        private Car car;
        private Car car2;
        [TestInitialize]
        public void Init()
        {
            car = new Car(nextID++, "Mercedes", 700000, "AB12345");
            car2 = new Car(nextID++, "FIAT", 50000, "AB66666");
        }
        [TestMethod()]
        public void GetAllTest()
        {
            Assert.ThrowsException<ArgumentNullException>(() => car = null);
        }

        [TestMethod()]
        public void GetById()
        {
            Assert.AreEqual(1, car.Id);
            Assert.AreEqual(2, car2.Id);
        }

        [TestMethod()]
        public void AddCar()
        {
            Car car3 = new Car(nextID++, "TESLA", 10000000, "AC90600");
            Assert.AreEqual(3, car3.Id);
        }

        [TestMethod()]
        public void GetByPrice()
        {
            Assert.AreEqual(700000, car.Price);
        }

        [TestMethod()]
        public void RemoveCar()
        {
            Assert.AreEqual(1, car.Id);
        }
    }
}