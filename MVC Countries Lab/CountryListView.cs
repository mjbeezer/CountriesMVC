using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryListView
    {
        //properties
        public List<Country> Countries;

        //constructors
        public List<Country> _Countries
        {
            get { return this.Countries; }
            set { this.Countries = value; }
        }
                
        public CountryListView(List<Country> countries)
        {
            this.Countries = countries;
        }

        //method
        public void Display()
        {
            int count = 1;
            foreach (Country c in Countries)
            {
                Console.WriteLine($"{count} Country: {c.Name}");
                count++;
            }
        }
    }
}
