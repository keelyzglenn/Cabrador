
using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Cabrador
{
    public class DogTest : IDisposable
    {
        public DogTest()
        {
            DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=cabrador_test;Integrated Security=SSPI;";
        }

        [Fact]
        public void GetAll_GetAllDogs_ListOfDogs()
        {
            // arrange
            Dog firstDog = new Dog("Pamfilo", "English Bulldog", "img/url", "Keelys House", true);
            firstDog.Save();

            Dog secondDog = new Dog("Cheif", "Friend Bulldog", "img/url", "Katy's House", true);
            secondDog.Save();

            // act
            List<Dog> result = Dog.GetAll();
            List<Dog> expected = new List<Dog>{firstDog, secondDog};

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_FindFindsDogInDatabase()
        {
            //Arrange
            Dog firstDog = new Dog("Pamfilo", "English Bulldog", "img/url", "Keelys House", true);
            firstDog.Save();

            //Act
            Dog result = Dog.Find(firstDog.GetId());

            //Assert
            Assert.Equal(firstDog, result);
        }

        public void Dispose()
        {
            Dog.DeleteAll();
        }
    }
}
