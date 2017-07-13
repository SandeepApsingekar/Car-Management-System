using CarProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class CarService : IService
    {
        CarRepository crepo = new CarRepository();
        Car c = new Car();
        public void mileagePerYear()
        {
            List<CarAvg> mileage = crepo.GetAvgMileageByYear();
        }
        public void CalculateConsumption(string model, double distance)
        {
            double CompleteMileage = crepo.CalculateConsumption(model, distance);
        }
        public void GetAllCar()
        {
            List<Car> c = crepo.GetAll();
        }
        public void GetRandomCar()
        {
             c = crepo.returnRandomCar();
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

        public void SortByValue()
        {
            List<Car> c = crepo.SortByValue();
        }
    }
}
