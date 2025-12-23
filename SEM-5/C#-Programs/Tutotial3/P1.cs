using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutotial3
{
    // Task 1: Create a class
    class Car
    {
        // Task 2: Add private data members
        private string brand;
        private string color;
        private int speed;

        // Task 3: Public method to set data (setter)
        public void SetCarDetails(string carBrand, string carColor, int carSpeed)
        {
            brand = carBrand;
            color = carColor;
            speed = carSpeed;
        }

        // Task 3: Public method to display car details
        public void DisplayCar()
        {
            Console.WriteLine("Car Brand: " + brand);
            Console.WriteLine("Car Color: " + color);
            Console.WriteLine("Car Speed: " + speed + " km/h");
            Console.WriteLine();
        }

        // Task 3: Public method to simulate driving
        public void Drive()
        {
            Console.WriteLine($"{brand} is driving at {speed} km/h.");
        }

        // Task 3: Public method to apply brakes
        public void ApplyBrakes()
        {
            Console.WriteLine($"{brand} has applied brakes and stopped.");
        }
    }

    // Task 4: Create Demo class with Main method
    class Demo
    {
        static void Main()
        {
            // Task 5: Create first object
            Car car1 = new Car();
            car1.SetCarDetails("Toyota", "Red", 100);   // Setting details
            car1.DisplayCar();                          // Displaying details
            car1.Drive();                               // Driving
            car1.ApplyBrakes();                         // Applying brakes

            Console.WriteLine("---------------------------");

            // Task 5: Create second object
            Car car2 = new Car();
            car2.SetCarDetails("BMW", "Black", 150);
            car2.DisplayCar();
            car2.Drive();
            car2.ApplyBrakes();
        }
    }

}
