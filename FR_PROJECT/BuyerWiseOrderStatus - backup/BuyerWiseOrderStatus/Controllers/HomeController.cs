using BuyerWiseOrderStatus.Data_Model;
using BuyerWiseOrderStatus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuyerWiseOrderStatus.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult GetDeliveryData()
        {
            ViewBag.toDate = DateTime.Now.Date.ToString("dd-MMM-yyyy");
            ViewBag.fromDate = DateTime.Now.Date.ToString("dd-MMM-yyyy");
            return View();
        }

        [HttpPost]
        public ActionResult GetDeliveryData(DateTime fromDate, DateTime toDate)
        {
            List<DeliveryDataValues> deliveryDataValues = new List<DeliveryDataValues>();
            try
            {
                string[] productionType = new string[] { "Denim", "Knit" };
                ViewBag.dateInfo = "Date " + fromDate.Date.ToString("dd-MMM-yyyy") + " To " + toDate.Date.ToString("dd-MMM-yyyy");
                ViewBag.toDate = toDate.Date.ToString("dd-MMM-yyyy");
                ViewBag.fromDate = fromDate.Date.ToString("dd-MMM-yyyy");
                using (FR_PJLEntities dbcon = new FR_PJLEntities())
                {
                     
                    var DeliveryLst3 = (from od in dbcon.ORDER_DELIVERIES
                                        join ord in dbcon.ORDERS on od.ORDER_ID equals ord.ORDER_ID
                                        join cu in dbcon.CUSTOMERS on ord.CUSTOMER_ID equals cu.CUSTOMER_ID
                                        join prdType in dbcon.ORDER_USER_DEFINED_VALUES on ord.ORDER_ID equals prdType.ORDER_ID
                                        where ord.COMPLETE_DATE < ord.RECEIVED_DATE
                                              && od.DEL_DATE >= fromDate && od.DEL_DATE <= toDate
                                              && productionType.Contains(prdType.UD_FIELD_VALUE)
                                        select od.ORDER_ID).ToList();

                    var DeliveryLst2 = (from od in dbcon.ORDER_DELIVERIES
                                        join ord in dbcon.ORDERS on od.ORDER_ID equals ord.ORDER_ID
                                        join cu in dbcon.CUSTOMERS on ord.CUSTOMER_ID equals cu.CUSTOMER_ID
                                        where ord.COMPLETE_DATE < ord.RECEIVED_DATE
                                              && od.DEL_DATE >= fromDate && od.DEL_DATE <= toDate
                                              && !DeliveryLst3.Contains(od.ORDER_ID)
                                        select new
                                        {
                                            UD_FIELD_VALUE = "Others",
                                            cu.CUSTOMER_NAME,
                                            ORD_QTY = (od.DEL_QTY == null ? 0 : od.DEL_QTY),
                                            ord.ORDER_NAME,
                                            od.DEL_DATE,
                                            Status = (ord.STATUS == "F" ? "Confirmed" : (ord.STATUS == "P" ? "Provisional" : "Transit"))
                                        }).ToList();
                      
                    var DeliveryLst = (from od in dbcon.ORDER_DELIVERIES
                                       join ord in dbcon.ORDERS on od.ORDER_ID equals ord.ORDER_ID
                                       join cu in dbcon.CUSTOMERS on ord.CUSTOMER_ID equals cu.CUSTOMER_ID
                                       join prdType in dbcon.ORDER_USER_DEFINED_VALUES on ord.ORDER_ID equals prdType.ORDER_ID
                                       where ord.COMPLETE_DATE < ord.RECEIVED_DATE
                                             && od.DEL_DATE >= fromDate && od.DEL_DATE <= toDate
                                             && productionType.Contains(prdType.UD_FIELD_VALUE)
                                       select new
                                       {
                                           prdType.UD_FIELD_VALUE,
                                           cu.CUSTOMER_NAME,
                                           ORD_QTY = (od.DEL_QTY == null ? 0 : od.DEL_QTY),
                                           ord.ORDER_NAME,
                                           od.DEL_DATE,
                                           Status = (ord.STATUS == "F" ? "Confirmed" : (ord.STATUS == "P" ? "Provisional" : "Transit"))
                                       }).ToList();
                    foreach (var dl in DeliveryLst)
                    {
                        DeliveryDataValues dt = new DeliveryDataValues();
                        dt.UD_FIELD_VALUE = dl.UD_FIELD_VALUE;
                        dt.CUSTOMER_NAME = dl.CUSTOMER_NAME;
                        dt.ORD_QTY = dl.ORD_QTY;
                        string[] orders = dl.ORDER_NAME.Split(new[] { "::" }, StringSplitOptions.None);
                        dt.BPO = orders[1];
                        dt.PF_NO = orders[0];
                        dt.DEL_DATE = dl.DEL_DATE.ToString("dd-MM-yyyy");
                        dt.Status = dl.Status;
                        deliveryDataValues.Add(dt);
                    }
                    foreach (var dl in DeliveryLst2)
                    {
                        DeliveryDataValues dt = new DeliveryDataValues();
                        dt.UD_FIELD_VALUE = dl.UD_FIELD_VALUE;
                        dt.CUSTOMER_NAME = dl.CUSTOMER_NAME;
                        dt.ORD_QTY = dl.ORD_QTY;
                        string[] orders = dl.ORDER_NAME.Split(new[] { "::" }, StringSplitOptions.None);
                        dt.BPO = orders[1];
                        dt.PF_NO = orders[0];
                        dt.DEL_DATE = dl.DEL_DATE.ToString("dd-MM-yyyy");
                        dt.Status = dl.Status;
                        deliveryDataValues.Add(dt);
                    }
                }
            }
            catch (Exception exp)
            {
            }
            return View(deliveryDataValues);
        }  
    }
}