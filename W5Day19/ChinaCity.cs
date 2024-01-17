using System;
using System.Collections.Generic;
using System.Text;

namespace W5Day19
{
    internal class ChinaCity:City
    {
        public ChinaCity(string name, int population)
        {
            this.Name = name;
            this.Population = population;
        }
        public int Population { 
            get 
            {
                return _population;
            }
            set 
            {
                if (value >= 100000)
                {
                    _population = value;
                }
            }
        }
    }
}
