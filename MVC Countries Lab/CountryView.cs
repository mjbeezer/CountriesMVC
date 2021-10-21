using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryView
    {
        //properties
        private Country DisplayCountry;

        //constructors
        public Country _DisplayCountry
        {
            get { return this.DisplayCountry; }
            set { this.DisplayCountry = value; }
        }

        public CountryView(Country country)
        {
            this.DisplayCountry = country;
        }

        //methods
        public void Display()
        {
            Console.WriteLine($"Name: {this.DisplayCountry.Name}\nContinent: {this.DisplayCountry.Continent}");
            foreach(string i in this.DisplayCountry.Colors)
            {
                //Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), "Gray", true);
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), i, true);
                Console.WriteLine(i);
                Console.ResetColor();
            }            
        }        
    }
}
