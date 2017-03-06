using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Cabrador
{
    public class CustomerTest : IDisposable
    {
        public CustomerTest()
        {
            DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=cabrador_test;Integrated Security=SSPI;";
        }

        [Fact]
        public void GetAll_CustomerEmptyAtFirst_True()
        {
            int result = Customer.GetAll().Count;
            Assert.Equal(0, result);
        }

        [Fact]
        public void Equals_CustomersReturnEqualIfSameProperties_True()
        {
            Customer firstCustomer = new Customer ("Alice Jenkins", "www.pic.coh", "alice@gmail.com", "w!ee3w");
            Customer secondCustomer = new Customer ("Alice Jenkins", "www.pic.coh", "alice@gmail.com", "w!ee3w");

            Assert.Equal(firstCustomer, secondCustomer);
        }

        [Fact]
        public void Save_SavesCustomerToDatabase_True()
        {
            Customer testCustomer = new Customer("Alice Jenkins", "www.pic.coh", "alice@gmail.com", "w!ee3w");
            testCustomer.Save();

            List<Customer> result = Customer.GetAll();
            List<Customer> testList = new List<Customer>{testCustomer};

            Assert.Equal(testList, result);
        }

        [Fact]
        public void Save_AssignsIdToCustomerObject_true()
        {
            //Arrange
            Customer testCustomer = new Customer("Alice Jenkins", "www.pic.coh", "alice@gmail.com", "w!ee3w");
            testCustomer.Save();

            //Act
            Customer savedCustomer = Customer.GetAll()[0];

            int result = savedCustomer.GetId();
            int testId = testCustomer.GetId();

            //Assert
            Assert.Equal(testId, result);
        }



        public void Dispose()
        {
            Customer.DeleteAll();
        }
    }
}
