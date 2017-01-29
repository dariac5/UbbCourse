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
            Mercedes.StartEngine();
            Console.WriteLine("Mercedes is " + mercedes.Description);
            Console.WriteLine("Mercedes costs " + mercedes.Price);

            Mercedes KmRemaining = new Mercedes();
            KmRemaining.ShowRemainingNoOfKM(10, 7);
            
            double numberOfKilometerLeft;
            numberOfKilometerLeft = KmRemaining.ShowRemainingNoOfKM(10, 7);
            Console.WriteLine("Numarul de km ramasi: " + numberOfKilometerLeft);
            
            Mercedes noMilliseconds = new Mercedes();
            noMilliseconds.StartEngine(12);

            Mercedes writeConsum = new Mercedes();
            writeConsum.CalculateConsumption(10);
            
            double calcConsum;
            calcConsum = writeConsum.CalculateConsumption(10);
            Console.WriteLine("The car consumption is " + calcConsum);


            Console.ReadKey();
        }
     
    }

    public struct EngineStruct 
    {
   
    }

    
}
