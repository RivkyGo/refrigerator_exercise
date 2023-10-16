using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorExercise
{
    class Item
    {
        public Guid ItemID { get; set; } 
        public string Name { get; set; }
        public int ShelfId { get; set; }
        public string ItemType { get; set; }
        public string KosherType { get; set; }
        public DateTime ExpirationData { get; set; }
        public double StorageSpace { get; set; }

        public Item(string name, int shelfId, string itemType, string kosherType, DateTime expirationData, double storageSpace)
        {
            ItemID = Guid.NewGuid();
            Name = name;
            ShelfId = shelfId;
            ItemType = itemType;
            KosherType = kosherType;
            ExpirationData = expirationData;
            StorageSpace = storageSpace;

        }
    }
}
