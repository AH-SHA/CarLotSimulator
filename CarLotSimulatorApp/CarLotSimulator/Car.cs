using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car

    {
        //Create properties for the Car class
        public int Year { get; set; }
        public string Make { get; set; }                                
        public string Model { get; set; }
        


        public string EngineNoise { get ; set; }	    
        public string HonkNoise { get; set; } 
        public bool IsDriveable { get; set; } 
    
      //Create methods for the Car class
        public void MakeEngineNoise(string engineNoise) 
        {
            EngineNoise = engineNoise;
            Console.WriteLine($"{Make} {Model} engine sounds: { EngineNoise}."); 
        }
        public void MakeHonkNoise(string honkNoise) 
        {
            HonkNoise = honkNoise;
            Console.WriteLine($"{Make} {Model} horn blows: {HonkNoise}."); 
        }


        // Practice using an alternate method to populate a class called, "Custom Constructor"

        //First, create an empty constructor
        public Car()
        {

        }

        //Next, Populate the information into the constructor.  This method turns the Properties above into Variables
        public Car(string make , string model, int year, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            IsDriveable = isDriveable;

        }

            
    }
}
