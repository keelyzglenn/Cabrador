
using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Cabrador
{
    public class TripTest : IDisposable
    {
        public TripTest()
        {
            DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=cabrador_test;Integrated Security=SSPI;";
        }

        [Fact]
        public void GetAll_GetAllTrips_ListOfTrips()
        {
            // arrange
            DateTime date = new DateTime(2017, 1, 1);

            Trip firstTrip = new Trip("1701", "801", 1, 2, date, 1, 2, 3);
            firstTrip.Save();
            Console.WriteLine(firstTrip.GetPrice());

            Trip secondTrip = new Trip("2018", "801", 1, 2, date, 1, 2, 3);
            secondTrip.Save();

            // act
            List<Trip> result = Trip.GetAll();
            List<Trip> expected = new List<Trip>{firstTrip, secondTrip};

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindById_ReturnsTripWhenSearchedById()
        {
            DateTime date = new DateTime(2017, 1, 1);

            Trip firstTrip = new Trip("1701", "801", 10, 2, date, 1, 2, 3);
            firstTrip.Save();

            Trip result = Trip.FindById(firstTrip.GetId());

            Assert.Equal(firstTrip, result);
        }

        public void Dispose()
        {
            Trip.DeleteAll();
        }
    }
}
