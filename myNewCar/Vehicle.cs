using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myNewCar
{
    public class Vehicle
    {
        public string engine_type = "gas";  // Vehicle field

        //Fields
        protected string color;
        protected string name;
        protected int maxSpeed; //field 
        protected int year;

        //Properties
        public string Name
        { //property
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Year
        {
            get { return year; }
            //set { year = value; }
            set
            {
                if (value < 1980)
                {
                    throw new Exception("Please pass a correct value");
                }
                else
                {
                    year = value;
                }
            }
        }

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
        public Vehicle(string nameName)
        {
            name = nameName;
        }
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
