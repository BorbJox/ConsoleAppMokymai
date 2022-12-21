using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BasicMokymai
{
    internal class InterfacesLesson
    {
        public static void Run()
        {
            BmwCar car = new BmwCar();
            car.Drive();
            car.Refuel(12);
            car.Drive();
            Console.WriteLine(car.IsXDrive);

            AudiCar car2 = new AudiCar();
            car2.Drive();
            car2.Refuel(0);
            car2.Refuel(-2);
            car2.Refuel(1);
            car2.Drive();
            car2.Drive();
            car2.Drive();
            car2.IsQuattro = true;
            Console.WriteLine(car2.IsQuattro);
        }

        interface IVehicle
        {
            public void Drive();
            public void Refuel(int amount);
        }

        abstract class Car : IVehicle
        {
            public Car(string modelName) { 
                Model = modelName;
            }
            public string Model { get; set; }
            public int Fuel { get; protected set; }
            public void Drive()
            {
                if (Fuel > 0)
                {
                    Fuel--;
                    Console.WriteLine($"Wrooom. Used 1 fuel. {Fuel} left.");
                } else
                {
                    Console.WriteLine("Oh no! Out of fuel!");
                }   
            }

            public void Refuel(int amount)
            {
                if (amount < 0)
                {
                    Console.WriteLine("You can't siphon fuel!");
                    return;
                }

                if (amount == 0)
                {
                    Console.WriteLine("Your can is empty. What are you refueling with?");
                    return;
                }

                if (Fuel + amount <= 10)
                {
                    Fuel += amount;
                    Console.WriteLine($"Glug glug. Refueling. Now I have {Fuel} fuel.");
                } else
                {
                    Console.WriteLine("No! Don't do it! It'll overfill!");
                    Console.WriteLine($"Look what you did.. You spilled {Fuel + amount - 10} fuel on the floor..");
                    Fuel = 10;
                }
            }
        }

        class BmwCar : Car
        {
            public BmwCar() : base("BMW")
            {

            }

            public bool IsXDrive { get; set; }
        }
        class AudiCar : Car
        {
            public AudiCar() : base("Audi")
            {

            }

            public bool IsQuattro { get; set; }
        }
    }
}
