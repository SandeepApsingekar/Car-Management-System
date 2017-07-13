using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    public class Car
    {
        public int id { get; set; }
        public string CarName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public double TccRating { get; set; }
        public int Mileage { get; set; }
        public override string ToString()
        {
            return id + "\t" + CarName + "\t" + Model + "\t" + Color + "\t" + Year + "\t" + Price + "\t\t" + TccRating + "\t" + Mileage + "\t";

        }
    }

    public class CarAvg
    {
        public int Key { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
    }
}
