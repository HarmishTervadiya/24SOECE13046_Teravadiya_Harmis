using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4
{
    internal class Q3
    {

        class Vehicle
        {
            private string vehicleID;
            protected string brand;
            public int year;

            public Vehicle(string id, string brandName, int manufactureYear)
            {
                vehicleID = id;
                brand = brandName;
                year = manufactureYear;
            }

            public void DisplayVehicleInfo()
            {
                Console.WriteLine($"Vehicle ID: {vehicleID}");
                Console.WriteLine($"Brand: {brand}");
                Console.WriteLine($"Year: {year}");
            }

            public void UpdateYear(int newYear)
            {
                year = newYear;
            }
        }

        class Car : Vehicle
        {
            private string model;
            protected string color;
            public int numberOfDoors;

            public Car(string id, string brandName, int manufactureYear, string modelName, string carColor, int doors)
                : base(id, brandName, manufactureYear)
            {
                model = modelName;
                color = carColor;
                numberOfDoors = doors;
            }

            public void DisplayCarInfo()
            {
                DisplayVehicleInfo();
                Console.WriteLine($"Model: {model}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Number of doors: {numberOfDoors}");
            }

            public void Repaint(string newColor)
            {
                color = newColor;
                Console.WriteLine($"Car repainted to {color}");
            }
        }

        class Demo
        {
            static void Main()
            {
                Car car1 = new Car("V001", "Toyota", 2018, "Corolla", "Red", 4);
                Console.WriteLine("Details of Car 1:");
                car1.DisplayCarInfo();
                car1.Repaint("Blue");
                car1.UpdateYear(2019);
                car1.DisplayCarInfo();

                Console.WriteLine();

                Car car2 = new Car("V002", "Honda", 2020, "Civic", "Black", 2);
                Console.WriteLine("Details of Car 2:");
                car2.DisplayCarInfo();
                car2.Repaint("White");
                car2.UpdateYear(2021);
                car2.DisplayCarInfo();
            }


        }
    }
}
