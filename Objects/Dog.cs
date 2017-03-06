using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Cabrador
{
    public class Dog
    {
        private int _id;
        private string _name;
        private string _breed;
        private string _photo;
        private string _shelter;
        private bool _adopt;

        public Dog(string Name, string Breed, string Photo, string Shelter, bool Adopt = false,  int Id = 0)
        {
            _id = Id;
            _name = Name;
            _breed = Breed;
            _photo = Photo;
            _shelter = Shelter;
            _adopt = Adopt;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetBreed()
        {
            return _breed;
        }

        public string GetPhoto()
        {
            return _photo;
        }

        public string GetShelter()
        {
            return _shelter;
        }

        public bool GetAdoptStatus()
        {
            return _adopt;
        }

        public void SetAdopt(bool newAdopt)
        {
            _adopt = newAdopt;
        }

        public int TranslateAdopt()
        {
            if (this._adopt == false)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public override int GetHashCode()
        {
            return this.GetName().GetHashCode();
        }

        public override bool Equals(System.Object otherDog)
        {
            if(!(otherDog is Dog))
            {
                return false;
            }
            else
            {
                Dog newDog = (Dog) otherDog;
                bool idEquality = this.GetId() == newDog.GetId();
                bool nameEquality = this.GetName() == newDog.GetName();
                bool breedEquality = this.GetBreed() == newDog.GetBreed();
                bool photoEquality = this.GetPhoto() == newDog.GetPhoto();
                bool shelterEquality = this.GetShelter() == newDog.GetShelter();
                bool adoptEquality = this.GetAdoptStatus() == newDog.GetAdoptStatus();
                return (idEquality && nameEquality && breedEquality && photoEquality && shelterEquality && adoptEquality);
            }
        }


        public static List<Dog> GetAll()
        {
            List<Dog> AllDogs = new List<Dog> {};

            SqlConnection conn = DB.Connection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM dogs;", conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                int dogId = rdr.GetInt32(0);
                string dogName = rdr.GetString(1);
                string dogBreed = rdr.GetString(2);
                string dogPhoto = rdr.GetString(3);
                string dogShelter = rdr.GetString(4);
                bool dogAdopt;
                if(rdr.GetByte(5) == 1)
                {
                    dogAdopt = true;
                }
                else
                {
                    dogAdopt = false;
                }

                Dog newDog = new Dog(dogName, dogBreed, dogPhoto, dogShelter, dogAdopt, dogId);
                AllDogs.Add(newDog);
            }


            if(rdr != null)
            {
                rdr.Close();
            }
            if(conn != null)
            {
                conn.Close();
            }

            return AllDogs;
        }

        public void Save()
        {
            SqlConnection conn = DB.Connection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO dogs(name, breed, photo, shelter, adopted) OUTPUT INSERTED.id VALUES (@DogName, @DogBreed, @DogPhoto, @DogShelter, @DogAdopt);", conn);

            SqlParameter nameParameter = new SqlParameter();
            nameParameter.ParameterName = "@DogName";
            nameParameter.Value = this.GetName();

            SqlParameter breedParameter = new SqlParameter();
            breedParameter.ParameterName = "@DogBreed";
            breedParameter.Value = this.GetBreed();

            SqlParameter photoParameter = new SqlParameter();
            photoParameter.ParameterName = "@DogPhoto";
            photoParameter.Value = this.GetPhoto();

            SqlParameter shelterParameter = new SqlParameter();
            shelterParameter.ParameterName = "@DogShelter";
            shelterParameter.Value = this.GetShelter();

            SqlParameter adoptParameter = new SqlParameter();
            adoptParameter.ParameterName = "@DogAdopt";
            adoptParameter.Value = this.TranslateAdopt();

            cmd.Parameters.Add(nameParameter);
            cmd.Parameters.Add(breedParameter);
            cmd.Parameters.Add(photoParameter);
            cmd.Parameters.Add(shelterParameter);
            cmd.Parameters.Add(adoptParameter);

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

        public static Dog Find(int id)
        {
            SqlConnection conn = DB.Connection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM dogs WHERE id = @DogId", conn);

            SqlParameter dogIdParameter = new SqlParameter();
            dogIdParameter.ParameterName = "@DogId";
            dogIdParameter.Value = id.ToString();
            cmd.Parameters.Add(dogIdParameter);

            SqlDataReader rdr = cmd.ExecuteReader();

            int foundDogId = 0;
            string foundDogName = null;
            string foundDogBreed = null;
            string foundDogPhoto = null;
            string foundDogShelter = null;
            bool foundDogAdopt = false;

            while(rdr.Read())
            {
                foundDogId = rdr.GetInt32(0);
                foundDogName = rdr.GetString(1);
                foundDogBreed = rdr.GetString(2);
                foundDogPhoto = rdr.GetString(3);
                foundDogShelter = rdr.GetString(4);
                if(rdr.GetByte(5) == 1)
                {
                    foundDogAdopt = true;
                }
                else
                {
                    foundDogAdopt = false;
                }
            }
            Dog foundDog = new Dog(foundDogName, foundDogBreed, foundDogPhoto, foundDogShelter, foundDogAdopt, foundDogId);

            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
            return foundDog;
        }

        public void UpdateAdoptStatus(bool newAdopted)
        {
            SqlConnection conn = DB.Connection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE dogs SET adopted = @newAdopted OUTPUT INSERTED.* WHERE id = @DogId;", conn);


            SqlParameter newAdoptedParameter = new SqlParameter();
            newAdoptedParameter.ParameterName = "@NewAdopted";
            if (newAdopted == true)
            {
                newAdoptedParameter.Value = 1;
            } else {
                newAdoptedParameter.Value = 0;
            }
            cmd.Parameters.Add(newAdoptedParameter);

            SqlParameter dogIdParameter = new SqlParameter();
            dogIdParameter.ParameterName = "@DogId";
            dogIdParameter.Value = this.GetId();
            cmd.Parameters.Add(dogIdParameter);
            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                bool dogAdopt;
                if (rdr.GetByte(5) == 1)
                {
                    this._adopt = true;
                }
                else
                {
                    this._adopt = false;
                }
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


        public static void DeleteAll()
        {
            SqlConnection conn = DB.Connection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM dogs;", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
