using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorExercise
{
    class Shelf
    {
        public Guid ShelfId { get; set; }
        public int FloorNumberShelf { get; set; }
        public double SpaceOnShelf { get; set; }
        //public List<Item> ListOfShelves = new List<Item>;


        public Shelf(int floorNumberShelf, double spaceOnShelf)
        {
            ShelfId = Guid.NewGuid();
            FloorNumberShelf = floorNumberShelf;
            SpaceOnShelf = spaceOnShelf;
        }
    }
}
