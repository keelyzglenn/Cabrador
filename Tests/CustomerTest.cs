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

        [Fact]
        public void AddDriver_AddsDriverToCustomer()
        {
            //Arrange
            Customer testCustomer = new Customer("Alice Jenkins", "www.pic.coh", "alice@gmail.com", "w!ee3w");
            testCustomer.Save();

            Driver testDriver = new Driver("Bubba", "Subaru", "img/url");
            testDriver.Save();

            Driver testDriver2 = new Driver("BooBoo", "Honda", "img/url2");
            testDriver2.Save();

            //Act
            testCustomer.AddDriver(testDriver);
            testCustomer.AddDriver(testDriver2);

            List<Driver> result = testCustomer.GetDrivers();
            List<Driver> testList = new List<Driver>{testDriver, testDriver2};

            //Assert
            Assert.Equal(testList, result);
        }

        [Fact]
        public void AddDog_AddsDogToCustomer()
        {
            //Arrange
            Customer testCustomer = new Customer("Alice Jenkins", "www.pic.coh", "alice@gmail.com", "w!ee3w");
            testCustomer.Save();

            Dog testDog = new Dog("Porky", "Lab", "www.dskdf.com", "Seattle Humane", 0);
            testDog.Save();

            Dog testDog2 = new Dog("Pukey", "Poodle", "www.ekdels.com", "Shelter", 1);
            testDog2.Save();

            //Act
            testCustomer.AddDog(testDog);
            testCustomer.AddDog(testDog2);

            List<Dog> result = testCustomer.GetDogs();
            List<Dog> testList = new List<Dog>{testDog, testDog2};

            //Assert
            Assert.Equal(testList, result);
        }

        [Fact]
        public void AddTrip_AddsTripToCustomer()
        {
            //Arrange
            Customer testCustomer = new Customer("Alice Jenkins", "www.pic.coh", "alice@gmail.com", "w!ee3w");
            testCustomer.Save();

            DateTime date1 = new DateTime(2008, 4, 10);
            Trip testTrip = new Trip("Shelter", "lsdfks", 4, 8, date1);
            testTrip.Save();

            DateTime date2 = new DateTime(2017, 3, 8);
            Trip testTrip2 = new Trip("Tractor Tavern", "asdf", 3, 4, date2);
            testTrip2.Save();

            //Act
            testCustomer.AddTrip(testTrip);
            testCustomer.AddTrip(testTrip2);

            List<Trip> result = testCustomer.GetTrips();
            List<Trip> testList = new List<Trip>{testTrip, testTrip2};

            //Assert
            Assert.Equal(testList, result);
        }



        public void Dispose()
        {
            Customer.DeleteAll();
        }
    }
}
