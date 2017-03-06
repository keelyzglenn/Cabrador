using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Data;

namespace Cabrador
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _photo;
        private string _email;
        private string _password;


        public Customer(string Name, string Photo, string Email, string Password, int Id = 0)
        {
            _id = Id;
            _name = Name;
            _photo = Photo;
            _email = Email;
            _password = Password;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetPhoto()
        {
            return _photo;
        }

        public string GetEmail()
        {
            return _email;
        }

        public string GetPassword()
        {
            return _password;
        }


        public override bool Equals(System.Object otherCustomer)
        {
            if(!(otherCustomer is Customer))
            {
                return false;
            }
            else
            {
                Customer newCustomer = (Customer) otherCustomer;
                bool idEquality = this.GetId() == newCustomer.GetId();
                bool nameEquality = this.GetName() == newCustomer.GetName();
                bool photoEquality = this.GetPhoto() == newCustomer.GetPhoto();
                bool emailEquality = this.GetEmail() == newCustomer.GetEmail();
                bool passwordEquality = this.GetPassword() == newCustomer.GetPassword();
                return (idEquality && nameEquality && photoEquality && emailEquality && passwordEquality);
            }
        }

        public static List<Customer> GetAll()
        {
            List<Customer> allCustomers = new List<Customer>{};

            SqlConnection conn = DB.Connection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM customers;", conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                int customerId = rdr.GetInt32(0);
                string customerName = rdr.GetString(1);
                string customerPhoto = rdr.GetString(2);
                string customerEmail = rdr.GetString(3);
                string customerPassword = rdr.GetString(4);
                Customer newCustomer = new Customer(customerName, customerPhoto, customerEmail, customerPassword, customerId);
                allCustomers.Add(newCustomer);
            }

            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
            return allCustomers;
        }








        public static void DeleteAll()
        {
            SqlConnection conn = DB.Connection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM customers;", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
