using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Practical_StudentLibrary
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;
        private static int studentCount = 0;

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int StudentCount
        {
            get { return studentCount; }
        }

        public Student()
        {
            Name = "John Doe";
            Age = 16;
            id = studentCount++;
        }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            id = studentCount++;
        }

        public void Display()
        {
            Console.WriteLine($"{id}\n{Name}\n{Age}");
        }

        public int GetOlder()
        {
            return Age += 1;
        }
    }
}
