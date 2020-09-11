using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSalesReport
{
    public class MonthlySalesReport
    {
        public MonthlySalesReportHeader Header { get; set; }
        public List<SalesTransactions> Transactions { get; set; }

    }
}
