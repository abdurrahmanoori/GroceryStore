using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class ItemStoreKeeperAndCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string? Description { get; set; }
        public int? RealPrice { get; set; }
        public string? Photo { get; set; }
        public string? MadeIn { get; set; }

        public byte? Type { get; set; } //First, Second...

        public int? Quantity { get; set; }

        public DateTime? ExpireDate { get; set; }

        public string? Company { get; set; }

        public int? Profit { get; set; }

    }
}
