using System;
using System.Collections.Generic;

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
            var Dodge = new Car();
            var Chevy = new Car();
            var Porsche = new Car();


            Dodge.Year = 2017;
            Dodge.Make = "Challanger";
            Dodge.Model = "Hellcat";
            Dodge.EngineNoise = "RAWRRRRRR!!!";
            Dodge.HonkNoise = "Beep";
            Dodge.IsDirveable = true;

            Chevy.Year = 2018;
            Chevy.Make = "Camaro";
            Chevy.Model = "ZL1";
            Chevy.EngineNoise = "BRWAAAAR!!!!";
            Chevy.HonkNoise = "Beep";
            Chevy.IsDirveable = true;

            Porsche.Year = 2020;
            Porsche.Make = "911";
            Porsche.Model = "GT Turbo";
            Porsche.EngineNoise = "VROOOM!";
            Porsche.HonkNoise = "Beep Beep";
            Porsche.IsDirveable = true;


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Dodge.MakeEngineNoise();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Dodge.MakeHonkNoise();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Chevy.MakeEngineNoise();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Chevy.MakeHonkNoise();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Porsche.MakeEngineNoise();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Porsche.MakeHonkNoise();
            //*************BONUS*************//

            Car car1 = new Car() { Year = 2017, Make = "Honda", Model = "Accord" };
            Console.WriteLine(car1.Year);

            Cars car2 = new Cars(2017, "Honda", "Civic", "vroom", "beep", true);

            var carlot=new List<Cars>();
            carlot.Add(car2);

            foreach (var car in carlot)
            {
                Console.WriteLine(car.Year1 + car.Make2);
            }


            //*************BONUS X 2*************//
            var carlot2 = new List<Car>();
            carlot2.Add(Dodge);
            carlot2.Add(Porsche);
            carlot2.Add(Chevy);

            foreach (var car in carlot2)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
