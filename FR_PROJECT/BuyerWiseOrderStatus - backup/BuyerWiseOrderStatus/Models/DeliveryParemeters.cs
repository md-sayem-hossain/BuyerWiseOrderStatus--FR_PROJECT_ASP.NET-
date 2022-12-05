using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyerWiseOrderStatus.Models
{
    public class DeliveryParemeters
    {
        public int Id { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }
        public string CustomerName { get; set; }
    }
}