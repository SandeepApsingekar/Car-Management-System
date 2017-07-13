using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
   public interface IService
    {
        void mileagePerYear();
        void CalculateConsumption(string model, double distance);
        void GetAllCar();
        void GetRandomCar();
        void SortCarByName();
        void SortCarByPrice();
        void SortByYear();
        void SortByValue();
    }
}
