using System;

namespace CarLot {

    public class Car {

        private string _baseSound = "Boink";
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car (int year) {
            Year = year;
        }

        public Car (double price) {
            Price = price;
        }

        public Car () { }

        // Overloading Drive with different arities
        public void Drive() {
            Console.WriteLine(_baseSound);
        }

        public void Drive(int kilometers) {
            Console.WriteLine($"I drove {kilometers} kilometers");
        }

        public void Drive(int kilometers, string sound) {
            Console.WriteLine($"I drove {kilometers} kilometers - {sound}");
        }

        public void Drive(string soundToMake) {
            Console.WriteLine(soundToMake);
        }
    }
}