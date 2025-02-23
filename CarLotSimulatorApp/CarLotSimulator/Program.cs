using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    public class Program

    {



        static void Main(string[] args)
        {
            //TODO

            //1. Create a seperate class file called Car
            //2. Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //3. Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //4. The methods should take one string parameter: the respective noise property


            //5. Now that the Car class is created we can instanciate 3 new cars
            //6. Set the properties for each of the cars
            //7. Call each of the methods for each car

            //8. Instantiate CarLot

            //START of Program

            // Creation and instantiation of CarLot class

            var carLotOne = new CarLot();


            // 1st Property method - "Direct Assignment"


            Car firstCar = new Car();
            firstCar.Make = "Lexus";
            firstCar.Model = "ES";
            firstCar.Year = 2025;
            firstCar.EngineNoise = "Smooth";
            firstCar.HonkNoise = "Loud";
            firstCar.IsDriveable = true;

            //Use the methods created in the Car class file to enter the relevant noise
            firstCar.MakeEngineNoise("smooth");
            firstCar.MakeHonkNoise("loud");

            //Add the created car to the list within the CarLot class
            carLotOne.CarLotList.Add(firstCar);


            

            // 2nd Property Method - "Object Initializer Syntax"

            Car secondCar = new Car() { Make = "Cadillac", Model = "CTS", Year = 2024, EngineNoise = "Hum", HonkNoise = "squeak", IsDriveable = true };

            //Use the methods created in the Car class file to enter the relevant noise
            secondCar.MakeEngineNoise("Hum");
            secondCar.MakeHonkNoise("Squeak");

            //Add the created car to the list within the CarLot class
            carLotOne.CarLotList.Add(secondCar);



            // 3rd Property Method - "Custom Constructor"

            Car thirdCar = new Car(make: "Jeep", model: "Cherokee", year: 2013, isDriveable: false);

            //Use the methods created in the Car class file to enter the relevant noise
            thirdCar.MakeEngineNoise("Clank");
            thirdCar.MakeHonkNoise("Screech");


            //Add the created car (or the instantiation of the class) to the list within the CarLot class
            carLotOne.CarLotList.Add(thirdCar);

           

            Console.WriteLine("");
            Console.WriteLine("List of All Cars on the Lot:");

            
            
            //Print names of each car on the lot
            carLotOne.ListAllCars();

               
                

                  



                    //*************BONUS*************//

                    // Set the properties utilizing the 3 different ways we learned about, one way for each car

                    //*************BONUS X 2*************//

                    //Create a CarLot class
                    //It should have at least one property: a List of cars
                    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
                    //At the end iterate through the list printing each of car's Year, Make, and Model to the console

                }
        }
    
}
