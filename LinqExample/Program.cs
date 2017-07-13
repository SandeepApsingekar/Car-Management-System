using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqEx l = new LinqEx();
            l.GetAll();
            l.SortByValue();
            Console.ReadLine();
        }
    }
}
