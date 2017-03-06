
using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Cabrador
{
    public class DriverTest : IDisposable
    {
        public DriverTest()
        {
            DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=cabrador_test;Integrated Security=SSPI;";
        }

        [Fact]
        public void GetAll_GetAllDrivers_ListOfDrivers()
        {
            // arrange
            Driver firstDriver = new Driver("Bubba", "Subaru", "img/url");
            firstDriver.Save();

            Driver secondDriver = new Driver("Jones", "Toyota", "img/url");
            secondDriver.Save();

            // act
            List<Driver> result = Driver.GetAll();
            List<Driver> expected = new List<Driver>{firstDriver, secondDriver};

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_FindFindsDriverInDatabase()
        {
            //Arrange
            Driver firstDriver = new Driver("Jerry", "Jeep", "img/url");
            firstDriver.Save();

            //Act
            Driver result = Driver.Find(firstDriver.GetId());

            //Assert
            Assert.Equal(firstDriver, result);
        }
        
        public void Dispose()
        {
            Driver.DeleteAll();
        }
    }
}
