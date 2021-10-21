using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryController
    {
        //properties
        public List<Country> CountryDb;

        //constructor
        public CountryController(List<Country> Countries)
        {
            CountryDb = Countries;
        }
        public List<Country> _CountryDb
        {
            get { return this.CountryDb; }
            set { this.CountryDb = value; }
        }

        //methods
        public void CountryAction(Country c)
        {
            CountryView cView = new CountryView(c);
            cView.Display();
        }

        public void WelcomeAction()
        {
            CountryListView clView = new CountryListView(this.CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            bool learning = true;
            while (learning)
            {
                CountryListAction(clView);
                Console.WriteLine();
                Console.WriteLine("Would you like to learn about another country on the list? y/n");
                string choice = Console.ReadLine().ToLower().Trim();
                if(choice == "y")
                {
                    learning = true;
                    continue;
                }
                else if(choice == "n")
                {
                    learning = false;
                    Console.WriteLine("Godd bye.");
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid input.");
                    continue;
                }
            }
        }

        public void CountryListAction(CountryListView View)
        {
            View.Display();
            int select = int.Parse(Console.ReadLine());
            
            while (true)
            {
                if (select < 1 || select > this.CountryDb.Count)
                {
                    Console.WriteLine("That wasnt a number on the list.");
                }
                else
                {
                    CountryAction(CountryDb[select - 1]);
                    break;
                }                
            }
        }
    }
}
