using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Chart
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public virtual Users User { get; set; }
        public virtual ItemDetail ItemDetail { get; set; }// Take the number of quantity form item details table.
        public virtual Item Item { get; set; }
        public virtual ItemStoreKeeper ItemStoreKeeper { get; set; }
        public virtual Category Category { get; set; }
    }
}
