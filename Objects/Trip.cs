using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Cabrador
{
    public class Trip
    {
        private int _id;
        private string _start;
        private string _destination;
        private int _price;
        private int _miles;
        private DateTime _date;
        private int _driverid;
        private int _dogid;
        private int _customerid;

        public Trip(string Start, string Destination, int Price, int Miles, DateTime Date, int DriverId, int DogId, int CustomerId, int Id = 0)
        {
            _id = Id;
            _start = Start;
            _destination = Destination;
            _price = Price;
            _miles = Miles;
            _date = Date;
            _driverid = DriverId;
            _dogid = DogId;
            _customerid = CustomerId;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetStartPoint()
        {
            return _start;
        }

        public string GetDestination()
        {
            return _destination;
        }

        public int GetPrice()
        {
            return _price;
        }

        public int GetMiles()
        {
            return _miles;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public int GetDriverId()
        {
            return _driverid;
        }

        public Driver GetDriverName()
        {
            return Driver.Find(_driverid);
            // thisTrip.GetDriverName().GetName();
        }

        public int GetDogId()
        {
            return _dogid;
        }

        public Dog GetDogName()
        {
            return Dog.Find(_dogid);
            // thisTrip.GetDogName().GetName();
        }

        public int GetCustomerId()
        {
            return _customerid;
        }

        public override int GetHashCode()
        {
            return this.GetId().GetHashCode();
        }

        public override bool Equals(System.Object otherTrip)
        {
            if(!(otherTrip is Trip))
            {
                return false;
            }
            else
            {
                Trip newTrip = (Trip) otherTrip;
                bool idEquality = (this.GetId() == newTrip.GetId());
                bool startEquality = (this.GetStartPoint() == newTrip.GetStartPoint());
                bool destinationEquality = (this.GetDestination() == newTrip.GetDestination());
                bool priceEquality = (this.GetPrice() == newTrip.GetPrice());
                bool milesEquality = (this.GetMiles() == newTrip.GetMiles());
                bool dateTimeEquality = (this.GetDate() == newTrip.GetDate());
                bool driverIdEquality = (this.GetDriverId() == newTrip.GetDriverId());
                bool dogIdEquality = (this.GetDogId() == newTrip.GetDogId());
                bool customerIdEquality = (this.GetCustomerId() == newTrip.GetCustomerId());
                return (idEquality && startEquality && destinationEquality && priceEquality && milesEquality && driverIdEquality && dogIdEquality && customerIdEquality);
            }
        }

        public static List<Trip> GetAll()
        {
            List<Trip> AllTrips = new List<Trip> {};

            SqlConnection conn = DB.Connection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM trips;", conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                int tripId = rdr.GetInt32(0);
                string start = rdr.GetString(1);
                string destination = rdr.GetString(2);
                int price = rdr.GetInt32(3);
                int miles = rdr.GetInt32(4);
                DateTime date = rdr.GetDateTime(5);
                int driverid = rdr.GetInt32(6);
                int dogid = rdr.GetInt32(7);
                int customerid = rdr.GetInt32(8);

                Trip newTrip = new Trip(start, destination, price, miles, date, driverid, dogid, customerid, tripId);
                AllTrips.Add(newTrip);
            }

            if(rdr != null)
            {
                rdr.Close();
            }
            if(conn != null)
            {
                conn.Close();
            }
            return AllTrips;
        }

        public void Save()
        {
            SqlConnection conn = DB.Connection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO trips (start_point, destination, price, miles, date, driver_id, dog_id, customer_id) OUTPUT INSERTED.id VALUES(@StartPoint, @Destination, @Price, @Miles, @Date, @DriverId, @DogId, @CustomerId);", conn);

            SqlParameter start = new SqlParameter();
            start.ParameterName = "@StartPoint";
            start.Value = this.GetStartPoint();
            cmd.Parameters.Add(start);

            SqlParameter destination = new SqlParameter();
            destination.ParameterName = "@Destination";
            destination.Value = this.GetDestination();
            cmd.Parameters.Add(destination);

            SqlParameter price = new SqlParameter();
            price.ParameterName = "@Price";
            price.Value = this.GetPrice();
            cmd.Parameters.Add(price);

            SqlParameter miles = new SqlParameter();
            miles.ParameterName = "@Miles";
            miles.Value = this.GetMiles();
            cmd.Parameters.Add(miles);

            SqlParameter date = new SqlParameter();
            date.ParameterName = "@Date";
            date.Value = this.GetDate();
            cmd.Parameters.Add(date);

            SqlParameter driverId = new SqlParameter();
            driverId.ParameterName = "@DriverId";
            driverId.Value = this.GetDriverId();
            cmd.Parameters.Add(driverId);

            SqlParameter dogId = new SqlParameter();
            dogId.ParameterName = "@DogId";
            dogId.Value = this.GetDogId();
            cmd.Parameters.Add(dogId);

            SqlParameter customerId = new SqlParameter();
            customerId.ParameterName = "@CustomerId";
            customerId.Value = this.GetCustomerId();
            cmd.Parameters.Add(customerId);

            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                this._id = rdr.GetInt32(0);
            }

            if(conn != null)
            {
                conn.Close();
            }
        }

        public static void DeleteAll()
        {
            SqlConnection conn = DB.Connection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM trips;", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
