using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myNewCar
{
    public class Car : Vehicle
    {
        //Fields
        private int carSeats;
        //private string color;
        //private string name;
        //private int maxSpeed; //field 
        //private int year;

        //Properties
        public int CarSeats { get; set; }
        //public string  Name { //property
        //    get { return name; }
        //    set { name = value; } 
        //}
        //public string Color {
        //    get { return color; }
        //    set { color = value; }
        //}

        //public int Year {
        //    get { return year; }
        //    //set { year = value; }
        //    set { 
        //    if (value < 1980) {
        //            throw new Exception("Please pass a correct value");
        //        }
        //    else {
        //            year = value;
        //        }
        //    }
        //}

        //Constructors
        public Vehicle(string nameName, string colorName, int yearValue, int maxSpeedValue)
        {
            name = nameName;
            color = colorName;
            year = yearValue;
            maxSpeed = maxSpeedValue;
        }

        public Vehicle(string nameName, string colorName, int yearValue, int maxSpeedValue, string eng_type)
        {
            name = nameName;
            color = colorName;
            year = yearValue;
            maxSpeed = maxSpeedValue;
            engine_type = eng_type;
        }
        public Car(string nameName)
        {
            name = nameName;
        }
        public void fullThrottle()
        {
            Console.WriteLine(name + " is going at the speed of " + maxSpeed);
        }
    }
}
