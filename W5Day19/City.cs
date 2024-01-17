using System;
using System.Collections.Generic;
using System.Text;

namespace W5Day19
{
    internal class City
    {
        protected string _name;
        protected int _population;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 20 && HasOnlyLetter(value))
                {
                    _name = value;
                }
            }
        }

        

        public bool HasOnlyLetter(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
