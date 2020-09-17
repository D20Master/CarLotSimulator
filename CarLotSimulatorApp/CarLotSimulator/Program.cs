using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //X_Create a seperate class file called Car 
            //X_Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //X_Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //X_The methods should take one string parameter: the respective noise property
            var lot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            var car1 = new Car(2020, "Honda", "CRV","BEEP!","Puuuuuur",true);
            var car2 = new Car(1992, "Ford", "Focus", "BEEP!", "Rattle", true);
            var car3 = new Car(2020, "Volvo", "Volvo", "Woooo!", "silence...", false);

            lot.Cars.Add(car1);
            lot.Cars.Add(car2);
            lot.Cars.Add(car3);

            //Call each of the methods for each car

            car1.MakeEngineNoise();
            car2.MakeEngineNoise();
            car3.MakeEngineNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make } Model: {car.Model}");
            }
        }
    }
}


