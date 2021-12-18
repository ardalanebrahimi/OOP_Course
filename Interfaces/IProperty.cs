using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public interface IProperty
    {
        public double Area { get; set; }
        public string Address { get; set; }
        public double GetPrice();
        public string Print();
    }
}
