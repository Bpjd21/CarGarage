using System;

namespace CarGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage BriansGarage = new Garage();

            string userInput;

            Console.WriteLine("Select 1 to add a new car to your garage");
            Console.WriteLine("Select 2 to remove a car from your garage");
            Console.WriteLine("Select 3 to view all cars in your garage");
            Console.WriteLine("Select 4 to test drive a car");
            Console.WriteLine("Select 5 to refuel all the cars in your garage");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    BriansGarage.AddCar();
                    break;
                case "2":
                    BriansGarage.RemoveCar();
                    break;
                //case "3":
                //    BriansGarage.RemoveCar.
                //        break;
                //case "4":
                //    BriansGarage.myGarage.
                case "5":
                    BriansGarage.FuelAllCars();
                    break;
                
            }
                  
        }
    }
}
