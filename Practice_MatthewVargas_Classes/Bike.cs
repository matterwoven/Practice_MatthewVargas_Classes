using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_MatthewVargas_Classes
{
    internal class BikeInfo
    {
        //Not much to comment here, but this assignment was when the get and set stuff *really* started to click for me


        public enum Type { electric, mountain, unicycle }
        string _brand; //Still don't know why this is green
        string _color;
        int _numOfWheels;
        Type _variation;
           


        public string Brand
        {
            get
            {
                return _brand;
            }
            set 
            {
                _brand = value;
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

        public int NumOfWheels 
        {
            get
            {
                return _numOfWheels;
            }
            set 
            {
                _numOfWheels = value;   
            }
        }
        public Type Variation //Couldn't come up with anything that wasn't type for this name, variation will do
        {
            get 
            {
                return _variation;
            }
            set 
            {
                _variation = value;
            }
        }

    }


}