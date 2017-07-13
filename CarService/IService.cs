using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    interface IService
    {
        void mileagePerYear();
        void CompleteMileage();
        void GetAllCar();
        void GetRandomCar();
        void SortCarByName();
        void SortCarByPrice();
        void SortByYear();
    }
}
