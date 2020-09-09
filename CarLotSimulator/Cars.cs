using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Cars
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool isDrivable { get; set; } = true;

        

        public Cars()
        {
            CarsLot.numberOfCars++;
        }

        public Cars(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable = true)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

          

      

           



    }
 }




































 











