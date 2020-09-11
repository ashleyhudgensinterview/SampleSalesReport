using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SampleSalesReport.Tests
{
    public class SalesReportService_UT
    {
        private readonly SalesReportService _testObject;
        public SalesReportService_UT()
        {
            _testObject = new SalesReportService();
        }

        [Fact]
        public void SalesReportService_ParseDate_Able_To_Parse_String_Date()
        {
            //Arrange
            string dateInput = "Jan 1, 2020";
            DateTime expected = new DateTime(2020, 1, 1);
            //Act
            var actual = _testObject.ParseDate(dateInput);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SalesReportService_ParseDate_Throw_Exception_When_Invalid_String_Date()
        {
            //Arrange
            string dateInput = "Jaa 1, 2020";
            DateTime expected = new DateTime(2020, 1, 1);
            //Act
            //Assert
            Assert.ThrowsAny<FormatException>(() => _testObject.ParseDate(dateInput));
        }
    }
}
