using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket_ShoppingCart.Shared.Models
{
    public partial class ItemDetails
    {
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public int ItemPrice { get; set; }       
    }
}
