using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbbCourse1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes();
            EngineStruct engine = new EngineStruct();
            ICar car = new Mercedes();
            AbstractCar car2 = new Mercedes();
            Console.WriteLine("Mercedes is " + mercedes.Description);
            Console.WriteLine("Mercedes costs " + mercedes.Price);
            Console.ReadKey();
        }
    }

    public struct EngineStruct 
    {
    }
}
