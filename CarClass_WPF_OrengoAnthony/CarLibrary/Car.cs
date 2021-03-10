using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        //Create private fields
        private string _year;
        private string _make;
        private int _speed;

        //Constructor
        public Car()
        {
            Year = "";
            Make = "";
            Speed = 0;
        }
        public Car(String year, string make, int speed)
        {
            Year = year;
            Make = make;
            Speed = speed;
        }

        //Set full properties for year, make, and speed
        public String Year
        {
            get
            {
                return _year;
            }
            set
            {
               _year = value;
            }

        }
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
            }
        }

    }
}
      

