using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Models
{
    public class ItemStoreKeeper
    {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Item Is Not Allowed To Be Empty!")]
        [Range(3, 50, ErrorMessage = "Name Must Be Between 3-50 Characters.")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? RealPrice { get; set; }
        public string? Photo { get; set; }
        public string? MadeIn { get; set; }
        public byte? Type { get; set; } //First, Second...
        public int? Quantity { get; set; }

        public DateTime? ExpireDate { get; set; }

        public string? Company { get; set; }

        public int? Profit { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Item Item { get; set; }



        //public decimal? Price { get; set; }
        //public int? RealPrice { get; set; }
        //public string Description { get; set; }
        //public string? Photo { get; set; }
        //        public string CompanyName { get; set; }
        //public int? CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        //public virtual Category Category { get; set; }

    }
}
