using System;
using System.Collections.Generic;

namespace CarLot {

    class Program {
        static void Main (string[] args) {
            /*
            Define a Dictionary to represent a car. Each dictionary should have the following KeyValuePairs.
                * Make
                * Model
                * Year
                * Price
                Create three car dictionaries for three different car models
             */

            Car TheXterra = new Car (2007) {
                Make = "Nissan",
                Model = "Xterra",
                Price = 11700.99
            };
            TheXterra.Drive("Squeak");

            Car TheF150 = new Car (2011) {
                Make = "Ford",
                Model = "F150",
                Price = 18990.55
            };
            TheF150.Drive("Rummbbbbllleeee");

            Car TheThunderbird = new Car (2002) {
                Make = "Ford",
                Model = "Thunderbird",
                Price = 6910.12
            };

            TheThunderbird.Drive();
            TheThunderbird.Drive(5);
            TheThunderbird.Drive("Badoink");

            /*
             * Create a car lot list.
             * Add each car to the car lot.
             * Iterate the car lot list and output all the details of each car
             */
            CarLot mikesUsedCars = new CarLot() {
                Owner = "Mike Wyczowskiy"
            };
            mikesUsedCars.Inventory.Add(TheF150);
            mikesUsedCars.Inventory.Add(TheThunderbird);
            mikesUsedCars.Inventory.Add(TheXterra);
            mikesUsedCars.Address = "1000 Infinity Way";
            mikesUsedCars.Size = 20000;


            foreach (Car car in mikesUsedCars.Inventory) {
                Console.WriteLine ($@"
Make: {car.Make}
Model: {car.Model}
Year: {car.Year}
Price: {car.Price}
            ");
            }

        }
    }
}