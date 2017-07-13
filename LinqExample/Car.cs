namespace LinqExample
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
      
    }

    public class CarAvg
    {
        public int Key { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
    }
}