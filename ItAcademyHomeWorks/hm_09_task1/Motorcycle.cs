using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09_task1
{
    class Motorcycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int MaxSpeed { get; set; }
        public string VinNumber { get; set; }

        public Motorcycle(Moto name, int year, int maxSpeed, string vinNumber)
        {
            Name = Convert.ToString(name);
            Year = year;
            MaxSpeed = maxSpeed;
            VinNumber = vinNumber;
        }
    }
}
