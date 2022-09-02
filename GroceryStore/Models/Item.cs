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
        [ForeignKey("ItemStoreKeeper"), Key]
        public int Id { get; set; }
        public int? Price { get; set; }
        public int? Profit { get; set; }
        public int? Discount { get; set; }
        public virtual ItemStoreKeeper ItemStoreKeeper { get; set; }

        //public string Description { get; set; }
        //public string? Photo { get; set; }
        //        public string CompanyName { get; set; }

        //public int? ItemStoreKeeperId { get; set; }

    }
}
