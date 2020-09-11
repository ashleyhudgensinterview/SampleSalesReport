using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSalesReport
{
    [Serializable]
    public class SalesTransactions
    {
        public string OrderId { get; set; }
        public string ProductDescription { get; set; }
        public string TotalUnitsSold { get; set; }
        public string TotalAmount { get; set; }
        public string PurchaseDate { get; set; }

        public override string ToString()
        {
            return OrderId + ProductDescription + TotalUnitsSold + TotalAmount + PurchaseDate;
        }
    }
}
