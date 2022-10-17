using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_and_Class_demo
{
    public class Car
    {
        private string _make; //Fält
        public string Make //Proppertry
        {
            get { return _make.ToUpper(); }      //visa i versaler.     
            set { _make = value; }
            
        }
        
        private string _color;

        public string Color 
        {
            get { return _color; } //Här kan man presentera Color i Versaler, men inte spara i fältet.
            set { _color = value.ToUpper(); } //Här sätter man //Spara i versaler
        }
        
    }
}
