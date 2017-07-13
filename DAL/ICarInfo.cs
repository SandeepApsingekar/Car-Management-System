using CarProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface ICarInfo
    {
        //Sort by year function
        List<Car> SortByYear();
        //Sort By Name
        List<Car> SortbyName();
        //Sort By Price
        List<Car> SortByPrice();
        //Best Value
        List<Car> SortByValue();
        List<Car> GetAll();
        //Mileage
        double CalculateConsumption(string model, double distance);
        //random car
        Car returnRandomCar();
        List<CarAvg> GetAvgMileageByYear();
    }
}
