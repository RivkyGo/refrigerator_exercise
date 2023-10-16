using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorExercise
{
    class Refrigerator
    {
        
        public Guid RefrigeratorId { get; set; }
        public string RefrigeratorModel { get; set; }
        public string RefrigeratorColor { get; set; }
        public int NumOfShelves { get; set; }
        public List<Shelf> Shelves { get; set; }

        public Refrigerator(string refrigeratorModel, string refrigeratorColor, int numOfShelves)
        {
            RefrigeratorId = Guid.NewGuid();
            RefrigeratorModel = refrigeratorModel;
            RefrigeratorColor = refrigeratorColor;
            NumOfShelves = numOfShelves;
            Shelves = new List<Shelf>();
        }


        public void AddShelf(Shelf shelf)
        {
            Shelves.Add(shelf);
        }




    }
}
