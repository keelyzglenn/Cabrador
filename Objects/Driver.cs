using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Cabrador
{
    public class Driver
    {
        private int _id;
        private string _name;
        private string _car;
        private string _photo;

        public Driver(string Name, string Car, string Photo, int Id = 0)
        {
            _id = Id;
            _name = Name;
            _car = Car;
            _photo = Photo;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetCar()
        {
            return _car;
        }

        public string GetPhoto()
        {
            return _photo;
        }

        public override bool Equals(System.Object otherDriver)
          {
              if(!(otherDriver is Driver))
              {
                  return false;
              }
              else
              {
                  Driver newDriver = (Driver) otherDriver;
                  bool idEquality = this.GetId() == newDriver.GetId();
                  bool nameEquality = this.GetName() == newDriver.GetName();
                  bool carEquality = this.GetCar() == newDriver.GetCar();
                  bool photoEquality = this.GetPhoto() == newDriver.GetPhoto();
                  return (idEquality && nameEquality && carEquality && photoEquality);
              }
          }

        public static List<Driver> GetAll()
        {
            List<Driver> AllDrivers = new List<Driver> {};

            SqlConnection conn = DB.Connection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM drivers;", conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                int driverId = rdr.GetInt32(0);
                string driverName = rdr.GetString(1);
                string driverCar = rdr.GetString(2);
                string driverPhoto = rdr.GetString(3);

                Driver newDriver = new Driver(driverName, driverCar, driverPhoto, driverId);
                AllDrivers.Add(newDriver);
            }


                if(rdr != null)
                {
                    rdr.Close();
                }
                if(conn != null)
                {
                    conn.Close();
                }

            return AllDrivers;
        }

        public void Save()
        {
            SqlConnection conn = DB.Connection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO drivers(name, car, photo) OUTPUT INSERTED.id VALUES (@DriverName, @DriverCar, @DriverPhoto);", conn);

            SqlParameter nameParameter = new SqlParameter();
            nameParameter.ParameterName = "@DriverName";
            nameParameter.Value = this.GetName();

            SqlParameter carParameter = new SqlParameter();
            carParameter.ParameterName = "@DriverCar";
            carParameter.Value = this.GetCar();

            SqlParameter photoParameter = new SqlParameter();
            photoParameter.ParameterName = "@DriverPhoto";
            photoParameter.Value = this.GetPhoto();

            cmd.Parameters.Add(nameParameter);
            cmd.Parameters.Add(carParameter);
            cmd.Parameters.Add(photoParameter);

            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                this._id = rdr.GetInt32(0);
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }

        public static Driver Find(int id)
        {
            SqlConnection conn = DB.Connection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM drivers WHERE id = @DriverId", conn);

            SqlParameter driverIdParameter = new SqlParameter();
            driverIdParameter.ParameterName = "@DriverId";
            driverIdParameter.Value = id.ToString();
            cmd.Parameters.Add(driverIdParameter);

            SqlDataReader rdr = cmd.ExecuteReader();

            int foundDriverId = 0;
            string foundDriverName = null;
            string foundDriverCar = null;
            string foundDriverPhoto = null;

            while(rdr.Read())
            {
                foundDriverId = rdr.GetInt32(0);
                foundDriverName = rdr.GetString(1);
                foundDriverCar = rdr.GetString(2);
                foundDriverPhoto = rdr.GetString(3);
            }
            Driver foundDriver = new Driver(foundDriverName, foundDriverCar, foundDriverPhoto, foundDriverId);

            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
            return foundDriver;
        }


        public static void DeleteAll()
        {
          SqlConnection conn = DB.Connection();
          conn.Open();
          SqlCommand cmd = new SqlCommand("DELETE FROM drivers;", conn);
          cmd.ExecuteNonQuery();
          conn.Close();
        }


    }
}
