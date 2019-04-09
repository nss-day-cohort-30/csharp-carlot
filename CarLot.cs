using System.Collections.Generic;

namespace CarLot {
    public class CarLot {
        public List<Car> Inventory {get; set;} = new List<Car>();

        public string Owner {get; set;}

        public int Size { get; set; }

        public string Address { get; set; }
    }
}