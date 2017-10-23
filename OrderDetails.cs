using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiveCode4
{
    public class OrderDetails
    {
		[Column("orderId")]
		public int OrderId { get; set; }
		public int ProductId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
    }
}