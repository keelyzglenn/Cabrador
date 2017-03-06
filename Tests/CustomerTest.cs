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

        [Fact]
        public void Find_FindsCustomerInDatabase()
        {
            //Arrange
            Customer testCustomer = new Customer("Alice Jenkins", "www.pic.coh", "alice@gmail.com", "w!ee3w");
            testCustomer.Save();

            //Act
            Customer foundCustomer = Customer.Find(testCustomer.GetId());

            //Assert
            Assert.Equal(testCustomer, foundCustomer);
        }


        [Fact]
        public void Delete_RemoveCustomerFromDatabase_Deleted()
        {
            Customer newCustomer = new Customer("Alice Jenkins", "www.pic.coh", "alice@gmail.com", "w!ee3w");
            newCustomer.Save();

            Customer.Delete(newCustomer.GetId());

            Assert.Equal(0, Customer.GetAll().Count);
        }

        [Fact]
        public void Update_UpdateInDatabase_true()
        {
            //Arrange
            string name = "Bianca Miller";
            string photo = "www.jjjjj.com";

            Customer testCustomer = new Customer(name, photo, "hzdlhsg", "sgsgwKRGHI");
            testCustomer.Save();
            string newName = "Bee Miller";
            string newPhoto = "www.ddreeffr.com";

            //Act
            testCustomer.Update(newName, newPhoto);
            Customer result = Customer.GetAll()[0];

            //Assert
            Assert.Equal(testCustomer, result);
            // Assert.Equal(newName, result.GetName());
        }

<<<<<<< HEAD
        [Fact]
        public void AddTrip_AddsTripToCustomer()
        {
            //Arrange
            Customer testCustomer = new Customer("Alice Jenkins", "www.pic.coh", "alice@gmail.com", "w!ee3w");
            testCustomer.Save();

            DateTime date1 = new DateTime(2008, 4, 10);
            Trip testTrip = new Trip("123 E Happy St", "1202 3rd Ave", 4, 8, date1, 2, 3, testCustomer.GetId());
            testTrip.Save();

            DateTime date2 = new DateTime(2009, 5, 12);
            Trip testTrip2 = new Trip("123 E Sad St", "1202 4rd Ave", 3, 12, date2, 1, 4, testCustomer.GetId());
            testTrip2.Save();

            //Act
            testCustomer.AddTrip(testTrip);
            testCustomer.AddTrip(testTrip2);

            List<Trip> result = testCustomer.GetTrips();
            List<Trip> testList = new List<Trip>{testTrip, testTrip2};

            //Assert
            Assert.Equal(testList, result);
        }

=======
    
>>>>>>> c2864e5853aacbefef69994a11e4a55ea6c22b2b


        public void Dispose()
        {
            Customer.DeleteAll();
        }
    }
}
