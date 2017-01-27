using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbbCourse1
{
    public class Mercedes : AbstractCar

    {
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

    }

    }
