using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSalesReport
{
    public class MonthlySalesReportHeader
    {
        string RunReportDate { get; set; }
        string StoreNumber { get; set; }
        string TotalUnitsSold { get; set; }
        string TotalAmountSold { get; set; }
    }
}
