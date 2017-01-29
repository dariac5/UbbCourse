using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbbCourse1
{
    public class Mercedes : AbstractCar

    {
        public static void StartEngine() 
        {
            Console.WriteLine("Engine started");
        }

        public void StartEngine(int noMillisecond)
        {
            Console.WriteLine("The car is starting in " + noMillisecond + " milliseconds.")
        }

        private string _description;
        private int _price;

        public string Description
        {
            get { return Description;}
            internal set { Description = value; }
        }

        public int Price
        {
            get { return Price; }
            internal set { Price = value; }
        }

        public Mercedes() 
        {
            _description = "E Class";
            _price = 67000;
        }

        public double ShowRemainingNoOfKM(double noOfFuelLiters, double Consumption)
        {
            double result = 0;
            result = noOfFuelLiters / Consumption * 100;
            return result;
        }

        public void ShowRemainingNoOfKM() 
        {
           
        }

        public double CalculateConsumption(params int[] kms)
        {
            double sum = 0;
            foreach (int km in kms)
                sum += km;
            return sum / 100 * 7;
        }
    }

}
