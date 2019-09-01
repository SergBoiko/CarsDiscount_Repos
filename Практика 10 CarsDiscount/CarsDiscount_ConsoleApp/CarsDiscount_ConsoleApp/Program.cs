using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsDiscount_ClassLibrary;

namespace CarsDiscount_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Red", "BMW", 2000, 10);

            CarsHolder.AddCar(car1);

            Car car2 = new Car("Black", "BMW", 3000, 10);

            CarsHolder.AddCar(car2);

            Car car3 = new Car("White", "BMW", 4000, 10);

            CarsHolder.AddCar(car3);


            do
            {
                Console.WriteLine("Enter command");
                Console.WriteLine("1. Add Car - '1'");
                Console.WriteLine("2. Print - '2'");
                string command = Console.ReadLine();

                if (command == "1")
                {
                    Console.WriteLine("Enter Car Color(Red, Black, White)");
                    string command2 = Console.ReadLine();

                    while (command2 != "Red" && command2 != "Black" && command2 != "White")
                    {
                        Console.WriteLine("You entered wrong color");
                        Console.WriteLine("Enter Car Color(Red, Black, White)");
                        command2 = Console.ReadLine();
                    }

                    Console.WriteLine("Enter Car Name");
                    string command3 = Console.ReadLine();

                    Console.WriteLine("Enter Price");
                    double.TryParse(Console.ReadLine(), out double command4);

                    
                    Console.WriteLine("Enter Discount");

                    int command5 = int.Parse(Console.ReadLine());

                    Car newCar = new Car(command2, command3, command4, command5);

                    CarsHolder.AddCar(newCar);
                }

                else if (command == "2")
                {
                    foreach (Car car in CarsHolder.GetCar)
                    {
                        Console.WriteLine($"Cars  - Color: {car.Color}, Name: {car.Name}, Price: {car.Price}, Discount: {car.Discount}");

                        Console.ReadLine();
                    }
                }

                else
                {
                    Console.WriteLine("Please enter correct number");
                }
            }
            while (true);
        }
    }
}
