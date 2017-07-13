using CarProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    public class CarService : IService
    {
        CarRepository crepo = new CarRepository();
        Car c = new Car();
        public void mileagePerYear()
        {
            double mileage = crepo.avgMileageByYear();
        }
        public void CompleteMileage()
        {
            double CompleteMileage = crepo.CalculateMileage();
        }
        public void GetAllCar()
        {
            List<Car> c = crepo.GetAll();
        }
        public void GetRandomCar()
        {
            List<Car> c = crepo.returnRandomCar();
        }
        public void SortCarByName()
        {
            List<Car> c = crepo.SortbyName();
        }
        public void SortCarByPrice()
        {
            List<Car> c = crepo.SortByPrice();
        }

        public void SortByYear()
        {
            List<Car> c = crepo.SortByYear();
        }
    }
}
