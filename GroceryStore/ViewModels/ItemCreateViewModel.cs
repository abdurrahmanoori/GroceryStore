using GroceryStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.ViewModels
{
    public class ItemCreateViewModel
    {
        
        public int Id { get; set; }
        public int Price{ get; set; }
        public int Profit { get; set; }
        public int Discount { get; set; }
        public List<ItemStoreKeeper> itemStoreKeepersList { get; set; }

    }
}
