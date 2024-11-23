using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOfBirthday DateOfBirthday { get; set; }

        public AdressInfo AdressInfo { get; set; }

        public Person()
        {
            Name = "Unknown";
            Age = 0;
            DateOfBirthday = new DateOfBirthday();
            AdressInfo = new AdressInfo();
        }

        public Person(string name, int age, DateOfBirthday dateOfBirthday, AdressInfo adressInfo)
        {
            Name = name;
            Age = age;
            DateOfBirthday = dateOfBirthday;
            AdressInfo = adressInfo;
        }

        public override string ToString()
        {
            return $"{Name}, {Age}, {DateOfBirthday}, {AdressInfo}";
        }
    }
}
