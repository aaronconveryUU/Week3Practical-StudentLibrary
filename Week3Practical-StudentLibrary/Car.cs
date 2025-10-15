using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Practical_StudentLibrary
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Engine CarEngine { get; set; }

        
        public Car()
        {
            Make = "Unknown";
            Model = "Unknown";
            Year = 0;
            CarEngine = new Engine();
        }

        
        public Car(string make, string model, int year, Engine engine)
        {
            Make = make;
            Model = model;
            Year = year;
            CarEngine = engine;
        }

        public void Drive()
        {
            Console.WriteLine("driving started");
        }

        public void Stop()
        {
            Console.WriteLine("driving stopped");
        }
    }
}
