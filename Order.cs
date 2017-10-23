using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiveCode4
{
    public class Order
    {
        [Column("OrderId")]
        public int OrderId { get; set; }
        public int Id { get; set; }
        public String CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public double Freight { get; set; }
        public String ShipName { get; set; }
        public String ShipAddress { get; set; }
        public String ShipCity { get; set; }
        public String ShipPostalCode { get; set; }
        public String ShipCountry { get; set; }
    }
}

