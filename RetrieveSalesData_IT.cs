using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SampleSalesReport.Tests
{
    public class RetrieveSalesData_IT
    {
        private readonly RetrieveSalesData _testObject;
        public RetrieveSalesData_IT()
        {
            _testObject = new RetrieveSalesData();
        }

        [Fact]
        public void RetrieveSalesData_Retrieve_Pulls_Back_Data()
        {
            //Arrange
            DateTime dateTime = DateTime.Now;
            var timeFrame = dateTime.AddMonths(-1);
            //Act
            var result = _testObject.Retrieve(timeFrame);
            //Assert
            Assert.NotNull(result);
        }

        //possible test to confirm count of records
    }
}
