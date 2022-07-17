// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
//-----------------------------------------------------------------
// CarLotSimulatorRevisited
//
// Name: David Zientara
// Date: 7-16-2022
// Comments: An exercise in the static keyword (exercise 2)
// Added methods per the instructions
//-----------------------------------------------------------------
namespace CarLotSimulator
{
    
    class Carlot
    {
        // Make carlist private because we know all
        // about encapsulation: 
        private List<Car> carlist;
        public static int NumberOfCars = 0;

        // Constructor for the Carlot class:
        public Carlot()
        {
            carlist = new List<Car>();
            
        }
        // Add 
        // Given a car object, add a car to carlist
        // and increment the NumberOfCars
        // PARAMS: car (Car object)
        // RETURNS: Nothing; car added to carlist
        // and NumberoFCars incremented
        public void Add(Car car)
        {
            carlist.Add(car);
            NumberOfCars++;
        }

        
    }
    class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public string HonkNoise { get; set; }
        public enum ENoise { Quiet, Noisy, OK };
        public ENoise EngineNoise { get; set; }
        public int Year { get; set; }
        public bool IsDriveable { get; set; }

        public ENoise MakeEngineNoise()
        {
            return EngineNoise;
        }
        public string MakeHonkNoise()
        {
            return HonkNoise;
        }
       
        // Visual Studio makes it super-easy to add a ctor w/ parameters:
        public Car(string make, string model, string honkNoise, ENoise engineNoise, int year, bool isDriveable)
        {
            Make = make;
            Model = model;
            HonkNoise = honkNoise;
            EngineNoise = engineNoise;
            Year = year;
            IsDriveable = isDriveable;
        }
        // Also add a ctor w/o parameters and reasonable default values:
        public Car()
        {
            Make = "Plymouth";
            Model = "Valiant";
            HonkNoise = "Beep";
            EngineNoise = Car.ENoise.OK;
            Year = 1980;
            IsDriveable = true;
        }
    }

    class Program
    {
        static void Main()
        {
            //We're going to initialize three cars and add them to carlot:
            Carlot carlot = new Carlot();
            Car Golf = new Car();
            Golf.Make = "Volkswagen";
            Golf.Model = "Golf";
            Golf.Year = 1992;
            Golf.EngineNoise = Car.ENoise.Noisy;
            Golf.HonkNoise = "Beep, beep";
            carlot.Add(Golf);
            Console.WriteLine($"Added the Golf; current # of cars in the lot: {Carlot.NumberOfCars}");
            //Now initialize and add the Festiva:
            Car Festiva = new Car();
            Festiva.Make = "Ford";
            Festiva.Model = "Festiva";
            Festiva.Year = 2005;
            Festiva.EngineNoise = Car.ENoise.OK;
            Festiva.HonkNoise = "Ah-ooo-gah";
            carlot.Add(Festiva);
            Console.WriteLine($"Added the Festiva; current # of cars in the lot: {Carlot.NumberOfCars}");
            //Add the GTO:
            Car GTO = new Car();
            GTO.Make = "Pontiac";
            GTO.Model = "GTO";
            GTO.Year = 2018;
            GTO.EngineNoise = Car.ENoise.Quiet;
            GTO.HonkNoise = "Reeeeee";
            carlot.Add(GTO);
            Console.WriteLine($"Added the GTO; current # of cars in the lot: {Carlot.NumberOfCars}");
        }

    }
}