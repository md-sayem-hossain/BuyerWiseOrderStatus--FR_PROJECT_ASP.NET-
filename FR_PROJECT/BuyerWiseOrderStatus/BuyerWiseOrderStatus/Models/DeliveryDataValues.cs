using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyerWiseOrderStatus.Models
{
    public class DeliveryDataValues
    {
        public string UD_FIELD_VALUE { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public decimal ORD_QTY { get; set; }
        public string BPO { get; set; }
        public string DEL_DATE { get; set; }
        public string PF_NO { get; set; }
        public string Status { get; set; }
    }
}