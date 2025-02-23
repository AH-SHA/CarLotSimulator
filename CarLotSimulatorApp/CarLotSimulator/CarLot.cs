using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarLotSimulator
{
    public class CarLot
    {
        //Buliding CarLot class with one prpoerty only, a list accepting a car type.
        //To avoid doing so in the code of main method, = the class to the creation of a new list each time the list name is invoked
        public List<Car> CarLotList { get; set; } = new List<Car> ();

        //Created a method that prints each prpoerty for each member added to the CarLotList
        public void ListAllCars()
        {
            foreach (var item in CarLotList)
            {
                Console.WriteLine($"{item.Make} {item.Model} {item.Year}");
            }
        }

    }
}
