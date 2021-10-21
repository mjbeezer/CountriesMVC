using System;
using System.Collections.Generic;

namespace MVC_Countries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enum.Parse<ConsoleColor>(color)

            //list of countries
            List<Country> Countries = new List<Country>
            {                
                new Country("Canada", "North America", new List<string> { "Red", "White" }),
                new Country("United States", "North America", new List<string> { "Red", "White", "Blue" }),
                new Country("Brazil", "South America", new List<string> { "Green", "Yellow", "Blue" }),
                new Country("Colombia", "South America", new List<string> { "Yellow", "Blue", "Red" }),
                new Country("Sweden", "Europe", new List<string> { "DarkCyan", "Yellow"}),
                new Country("Spain", "Europe", new List<string> { "Red", "Yellow", "Red" }),
                new Country("Bangladesh", "Asia", new List<string> { "Green", "Red" }),
                new Country("China", "Asia", new List<string> { "Red", "Yellow" }),
                new Country("Morroco", "Africa", new List<string> { "Red", "Green" }),
                new Country("Rwanda", "Africa", new List<string> { "Cyan", "Yellow", "Green" }),
                new Country("Australia", "Australia", new List<string> { "Red", "White", "Blue" }),
                new Country("Antartica", "Antartica", new List<string> { "Blue", "White" })
            };

            CountryController Control = new CountryController(Countries);
            Control.WelcomeAction();            
        }
    }
}
