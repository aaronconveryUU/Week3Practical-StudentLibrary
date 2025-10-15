using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Practical_StudentLibrary
{
    internal class Engine
    {
        private int cylinders;
        private double horsePower;

        public int Cylinders
        {
            get { return cylinders; }
            set { cylinders = value; }
        }

        public double HorsePower
        {
            get { return horsePower; } 
            set { horsePower = value; }
        }

        public Engine()
        {
            cylinders = 0;
            horsePower = 0;
        }

        public Engine(int cylinders, double horsePower)
        {
            this.Cylinders = cylinders;
            this.HorsePower = horsePower;
        }

        public void Start()
        {
            Console.WriteLine("engine starting");
        }

        public void Stop()
        {
            Console.WriteLine("engine stopping");
        }
    }
}
