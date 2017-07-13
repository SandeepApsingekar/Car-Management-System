using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    public class LinqEx
    {
        List<Car> CInfo = new List<Car>();
        public static List<Car> Add()
        {
            return new List<Car>
            {
                new Car() {id=101,CarName="Honda",Model="CRV",Color="Green",Year=2016,Price=23845,TccRating=8,Mileage=33},
                new Car() {id=102,CarName="Ford",Model="Escape",Color="Red",Year=2017,Price=23590,TccRating=7.8,Mileage=32},
                new Car() {id=103,CarName="Hyundai",Model="SanteFe",Color="Grey",Year=2016,Price=24950,TccRating=8,Mileage=27},
                new Car() {id=104,CarName="Mazda",Model="CX-5",Color="Red",Year=2017,Price=21795,TccRating=8,Mileage=35},
                new Car() {id=105,CarName="Subaru",Model="Forest",Color="Blue",Year=2016,Price=22395,TccRating=8.4,Mileage=32}

            };
        }

        public List<Car> GetAll()
        {
            CInfo = Add();
            //var query = (from c in CInfo select c).ToList();
            foreach (Car c in CInfo)
            {
                Console.WriteLine(c.CarName + " " +c.Model);
            }
            Console.ReadLine();
            return CInfo;
        }

        public List<Car> SortByValue()
        {
            var cars = Add();
            var query = (from c in cars orderby c.TccRating descending select c).ToList();
            Console.WriteLine("Sorted cars by Value:\n");
            foreach (Car c in cars)
            {
                Console.WriteLine(c + "\n");
            }
            return query;
        }
    }
}
