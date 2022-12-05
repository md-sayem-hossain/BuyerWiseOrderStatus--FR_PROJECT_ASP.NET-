using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyerWiseOrderStatus.Models
{
    public class DeliveryData
    { 
        public int id { get; set; } 
        public string UD_FIELD_VALUE { get; set; } 
        public string CUSTOMER_NAME { get; set; } 
        public bool Status { get; set; } 
        public string ORD_QTY { get; set; } 
        public string DELIVERY_DATE { get; set; } 
        public string ORDER_NAME { get; set; } 
        public string PF_NO { get; set; } 
        public string PO_NO { get; set; }  
    }
}