using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class ItemDetail
    {
        [Key]
        [ForeignKey("item")]
        public int Id { get; set; }
        public float? Quantity { get; set; }
        public float? Amount { get; set; }

        public virtual Item Item { get; set; }
        public virtual ItemStoreKeeper ItemStoreKeeper { get; set; }
    }
}
