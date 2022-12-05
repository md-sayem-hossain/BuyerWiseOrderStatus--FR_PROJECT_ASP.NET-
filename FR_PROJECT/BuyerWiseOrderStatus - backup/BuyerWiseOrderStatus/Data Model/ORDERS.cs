//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuyerWiseOrderStatus.Data_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDERS
    {
        public int ORDER_ID { get; set; }
        public string ORDER_NAME { get; set; }
        public string ORIGINAL_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public int ORDER_SET { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public int PRODUCT_ID { get; set; }
        public int CUSTOMER_ID { get; set; }
        public int TIMETABLE_ID { get; set; }
        public string STATUS { get; set; }
        public int RGB_COLOUR { get; set; }
        public byte EFFICIENCY { get; set; }
        public short WIDTH { get; set; }
        public int QTY_DELIVERED { get; set; }
        public int FLAGS_4 { get; set; }
        public short MFG_TIME { get; set; }
        public short WH_TIME { get; set; }
        public int SELL_PRICE_X1000 { get; set; }
        public int SELL_COST_X1000 { get; set; }
        public int TRANS_METHOD_ID { get; set; }
        public int SOURCE_LOCATION_ID { get; set; }
        public short SALES_YEAR { get; set; }
        public byte SALES_SEASON { get; set; }
        public int PROVIDER_LOCATION_ID { get; set; }
        public System.DateTime LAST_UPDATED { get; set; }
        public int PRIORITY { get; set; }
        public int ROUTE_ID { get; set; }
        public int PRIOR_ORDER_ID { get; set; }
        public int NEXT_ORDER_ID { get; set; }
        public int EVENT_BASE_DATE { get; set; }
        public int AUTO_PLAN_GROUP { get; set; }
        public int AUTO_PLAN_BASE_DATE { get; set; }
        public string OVERRIDE_PROPERTY { get; set; }
        public int LAST_IN_CUST { get; set; }
        public int DIST_FROM_GROUP { get; set; }
        public int DELIVERY_LOCATION { get; set; }
        public int BATCH_FACTOR { get; set; }
        public int FLOW_ID { get; set; }
        public int SCHEDULE_OFFSET { get; set; }
        public int CHANGE_ID { get; set; }
        public int CHANGE_DATE { get; set; }
        public int TRANSPORT_OVERRIDE { get; set; }
        public int STOCK_OUT_DATE { get; set; }
        public int HOST_GROUP_ID { get; set; }
        public int INHERIT_FROM { get; set; }
        public System.DateTime RECEIVED_DATE { get; set; }
        public int PROCESS_WITH { get; set; }
        public int CONTRACT_QTY { get; set; }
        public int USER_STATUS { get; set; }
        public int PO_ID { get; set; }
        public int PO_LINE_ID { get; set; }
        public int COLLAB_REMOTE_ID { get; set; }
        public int HOST_ORDER_ID { get; set; }
        public int ORDER_GROUPING_ID { get; set; }
        public int VENDOR_DATE { get; set; }
        public int APEX_ORDER_ITEM_ID { get; set; }
        public System.DateTime ARCHIVED_DATE { get; set; }
        public int RESERVATION_ID { get; set; }
        public int COLLAB_CHANGE_ID { get; set; }
        public int LAST_COLLAB_SITE { get; set; }
        public int COLLAB_COMP_CHANGE { get; set; }
        public System.DateTime COMPLETE_DATE { get; set; }
        public byte OVERRIDE_CUSTOMER_PROF { get; set; }
        public int MAKE_COST_X1000 { get; set; }
    }
}