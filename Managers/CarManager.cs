using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using opgave4.Models;

namespace opgave4.Managers
{
    public class CarManager
    {
        private static int nextID = 1;
        private static List<Car> data = new List<Car>()
        {
            new Car() { Id = nextID++, Price = 60000, Model = "Ford Fiesta", LicensePlate = "AB11222" },
            new Car() { Id = nextID++, Price = 600000, Model = "Mercedez Benz", LicensePlate = "AC22666" },
            new Car() { Id = nextID++, Price = 20000, Model = "Fiat Punto", LicensePlate = "BB55999" },
            new Car() { Id = nextID++, Price = 777000, Model = "TESLA", LicensePlate = "TT12345" }
        };

        public List<Car> GetAll()
        {
            return new List<Car>(data);
        }

        public Car GetById(int Id)
        {
            return data.Find(car => car.Id == Id);
        }

        public Car AddCar(Car newCar)
        {
            newCar.Id = nextID++;
            data.Add(newCar);
            return newCar;
        }

        public Car RemoveCar(int id)
        {
            var car = GetById(id);

            if(car.Id == id)
            {
                data.Remove(car);
            }
            return car;
        }

        public List<Car> GetByPrice(double price)
        {
            List<Car> result;
            result = data.FindAll(car => car.Price <= price);
            return result;
        }
    }
}
