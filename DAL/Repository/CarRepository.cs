using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    public class CarRepository : ICarInfo
    {
        List<Car> cInfo = new List<Car>();

        //Add's the List of Cars
        static List<Car> Add()
        {
            return new List<Car>
            {
                new Car(){id=101,CarName="Honda",Model="CRV",Color="Green",Year=2016,Price=23845,TccRating=8,Mileage=33},
                new Car() {id=102,CarName="Ford",Model="Escape",Color="Red",Year=2017,Price=23590,TccRating=7.8,Mileage=32},
                new Car() {id=103,CarName="Hyundai",Model="SanteFe",Color="Grey",Year=2016,Price=24950,TccRating=8,Mileage=27},
                new Car() {id=104,CarName="Mazda",Model="CX-5",Color="Red",Year=2017,Price=21795,TccRating=8,Mileage=35},
                new Car() {id=105,CarName="Subaru",Model="Forest",Color="Blue",Year=2016,Price=22395,TccRating=8.4,Mileage=32}

            };
        }

        //Calculating the average mileage by year
        public List<CarAvg> GetAvgMileageByYear()
        {
            List<CarAvg> carAvg = new List<CarAvg>();
            cInfo = Add();
            var query = (from s in cInfo
                         group s by s.Year into g
                         select new CarAvg { Year = g.Key, Mileage  = g.Average(x => x.Mileage) }).ToList();
            Console.WriteLine("Average Mileage by Year:");
            
            foreach (var c in query)
            {
                Console.WriteLine(c + "\n");
            }

           
            return carAvg;
        }

        // A function to calculate fuel consumption for a given distance
        public double CalculateConsumption(string model,double distance)
        {
            var cars = Add();
            return cars.Where(c => c.Model == model).Select(x => distance / x.Mileage).FirstOrDefault();

        }

        //Get All the car details
        public List<Car> GetAll()
        {
            cInfo = Add();
            Console.WriteLine("All the Car Information:\n");
            Console.WriteLine("CarID" + "\t" + "CarName" + "\t" + "Model" + "\t" + "Color" + "\t" + "Year" + "\t" + "Price" + "\t" + "TccRating" + "\t" + "Mileage");
            Console.WriteLine("***********************************************************************");
            foreach (Car c in cInfo)
            {
                Console.WriteLine(c + "\n");               
            }
            Console.ReadLine();
            return cInfo;
        }

        //Return the Random car from the list
        public Car returnRandomCar()
        {
            var stores = Add();
            var query = (from s in stores
                         where s.id > 0
                         orderby Guid.NewGuid()
                         select s).First();
            Console.WriteLine("Random Car:\n");
            Console.WriteLine(query+"\n");
            return query;
        }

        //A function to calculate an alphabetized list of vehicles
        public List<Car> SortbyName()
        {
            var cars = Add();
            var query = (from s in cars orderby s.CarName select s).ToList();
            Console.WriteLine("Sorted By Car Names:\n");
            foreach (var s in query)
                Console.WriteLine(s+"\n");
            return query;
        }
        //A function to calculate an ordered list of vehicles by price
        public List<Car> SortByPrice()
        {
            var cars = Add();
            var query = (from c in cars orderby c.Price select c).ToList();
            Console.WriteLine("Sorted cars by Price:\n");
            foreach (var c in query)
            {
                Console.WriteLine(c + "\n");
            }
            return query;
        }
        // A function to calculate the best value
        public List<Car> SortByValue()
        {
            var cars = Add();
            var query = (from c in cars orderby c.TccRating descending select c).ToList();
            Console.WriteLine("Sorted cars by Value:\n");
            foreach (var c in query)
            {
                Console.WriteLine(c + "\n");
            }
            return query;
        }


        //A function to calculate the newest vehicles in order
        public List<Car> SortByYear()
        {
            var cars = Add();
            var query = (from c in cars orderby c.Year descending select c).ToList();
            Console.WriteLine("Sorted by Year:");
            foreach (var c in query)
            {
                Console.WriteLine(c + "\n");
            }
            return query;
        }
    }
}
