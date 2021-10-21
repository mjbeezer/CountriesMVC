using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class Country
    {
        //properties
        public string Name;
        public string Continent;
        public List<string> Colors;

        //constructors
        public string _Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public string _Continent
        {
            get { return this.Continent; }
            set { this.Continent = value; }
        }

        public List<string> _Colors
        {
            get { return this.Colors; }
            set { this.Colors = value; }
        }

        //methods
        public Country(string name, string continent, List<string> colors)
        {
            this.Name = name;
            this.Continent = continent;
            this.Colors = colors;
        }
    }
}
