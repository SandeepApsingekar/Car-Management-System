using ServiceLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarService cs = new CarService();
            //ArrayList a = new ArrayList();
            //a.Add("Sandeep");
            //a.Add(7);
            //a.Add("Marshall");
            ////
            //// Use ArrayList with method.
            ////
            //Example(a);
            while (true)
            {
                cs.GetAllCar();
                //cs.mileagePerYear();
                //cs.CalculateConsumption("CRV", 123.3);
                //cs.GetRandomCar();
                //cs.SortCarByName();
                //cs.SortCarByPrice();
                //cs.SortByYear();
                //cs.SortByValue();
                Console.ReadLine();
            }
        }
        //static void Example(ArrayList list)
        //{
        //    list.Add("Antra");
        //    list.Add("Dog");
        //    foreach (var i in list)
        //    {               
        //        Console.WriteLine(i);
        //    }
        //    Console.WriteLine("The capacity is:" + list.Capacity);
        //}
    }
}
