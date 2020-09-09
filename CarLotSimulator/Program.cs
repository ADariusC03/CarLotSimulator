using System;

namespace CarLotSimulator
{
    class Program
    {

       


        static void Main(string[] args)
        {


            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            

            CarsLot lot = new CarsLot();


            Cars audi = new Cars();
            lot.Cars.Add(audi);

            audi.Year = 2018;
            audi.Make = "Audi";
            audi.Model = "R8 Spyder";
            audi.EngineNoise = "Skrrt Skrrt";
            audi.HonkNoise = "Beep Beep";
            audi.isDrivable = true;

            audi.MakeEngineNoise();
            audi.MakeHonkNoise();


            Console.WriteLine("...................................................");
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            Cars fusion = new Cars() { Year = 2015, Make = "Ford", Model = "Fusion", EngineNoise = "Vroooom vroom", HonkNoise = "Beep Boop", isDrivable = true };
            lot.Cars.Add(fusion);

            fusion.MakeEngineNoise();
            fusion.MakeHonkNoise();

            Console.WriteLine("....................................................");


            Cars renegade = new Cars(2019, "Renegade", "Jeep", "Nothing", "Boop bop");
            lot.Cars.Add(renegade);

            renegade.MakeEngineNoise();
            renegade.MakeHonkNoise();

            Console.WriteLine(".............................................");

            Console.WriteLine($"Number of cars created: {CarsLot.numberOfCars}");


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine();

            foreach(var cars in lot.Cars)
            {
                Console.WriteLine();
                Console.WriteLine($"Years: {cars.Year}, Make: {cars.Make}, Model: {cars.Model}");
            }



        }



    }
}
