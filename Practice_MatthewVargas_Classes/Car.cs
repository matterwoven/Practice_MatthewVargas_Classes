using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_MatthewVargas_Classes
{

    internal class Car
    {
        string _make;
        string _model;
        int _year;
        string _color;
        int _mileage;


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

        public string Model
        {

            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public int Year
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

        public string Color
        {

            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public int Mileage
        {

            get
            {
                return _mileage;
            }
            set
            {
                _mileage = value;
            }
        }


    }
}
