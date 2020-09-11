using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SampleSalesReport.Tests
{
    public class WriteReports_UT
    {
        private readonly WriteReports writeReports;
        public WriteReports_UT()
        {
            writeReports = new WriteReports();
        }

        [Fact]
        public void WriteReports_WriteMonthlySalesReports_Handles_Null_List()
        {
            //Arrange
            string outputPath = @"C:\temp\testresults.txt";
            //Act
            writeReports.WriteMonthlySalesReport(null, outputPath);

            //Assert
            //If exception is thrown, test will fail
        }

        [Fact]
        public void WriteReports_WriteMonthlySalesReport_Returns_True_When_Transactions_Present_File_Written()
        {
            //Arrange
            string outputPath = @"C:\temp\testresults.txt";
            SalesTransactions st = new SalesTransactions();
            List<SalesTransactions> listOfSt = new List<SalesTransactions>();
            listOfSt.Add(st);
            //Act
            var result = writeReports.WriteMonthlySalesReport(listOfSt, outputPath);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void WriteReports_WriteMonthlySalesReport_Returns_False_When_Transactions_Present_File_Written()
        {
            //Arrange
            string outputPath = @"C:\temp\testresults.txt";
            //Act
            var result = writeReports.WriteMonthlySalesReport(null, outputPath);
            //Assert
            Assert.False(result);
        }
        //possible test to confirm output file path is legitimate
    }
}
