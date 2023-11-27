using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket_ShoppingCart.Shared.Models
{
    public partial class ShoppingDetails
    {
        public int ShopId { get; set; }
        public int? ItemId { get; set; }
        public string? UserName { get; set; }
        public int Qty { get; set; }
        public int? TotalAmount { get; set; }
        public string? Description { get; set; }
        public DateTime? ShoppingDate { get; set; }
    }
}
