using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class Item
    {

        
        public int Id { get; set; }
        public int? Price { get; set; }
        public int? Profit { get; set; }
        public int? Discount { get; set; }
        [ForeignKey("ItemStoreKeeper")]
        public int? ItemStoreKepeerId { get; set; }
        public virtual ItemStoreKeeper ItemStoreKeeper { get; set; }

        //[ForeignKey("ItemStoreKeeper"), Key]
        //public int Id { get; set; }
        //public int? Price { get; set; }
        //public int? Profit { get; set; }
        //public int? Discount { get; set; }
        //public virtual ItemStoreKeeper ItemStoreKeeper { get; set; }

    }
}
