using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassBrady
{
    class Car
    {
        // Fields
        private int _year;
        private string _make;
        public double _speed;

        // Constructor
        public Car(int year, string make, double speed)
        {
            _year = year;
            _make = make;
            _speed = speed;
        }

        // Field1 property
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        // Field2 property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        // Field3 property
        public double Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
    }
}
