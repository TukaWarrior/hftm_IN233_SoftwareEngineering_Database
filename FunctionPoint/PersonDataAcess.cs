using Google.Protobuf.Compiler;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPoint
{
    internal class PersonDataAcess
    {
        string connectionString = "datasource=localhost;port=3306;user=root;database=functionpoint;";

        public List<Person> GetAllPersons()
        {
            List<Person> returnThese = new List<Person>();

            //connect to the mysql server

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all persons
            MySqlCommand command = new MySqlCommand("SELECT * FROM Person", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Person a = new Person
                    {
                        PersonID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Vorname = reader.GetString(2),
                        Geburtsdatum = reader.GetInt32(3),
                        Heimatort = reader.GetString(4),
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();


            return returnThese;

        }

        public List<Person> searchPerson(String searchTerm)
        {
            List<Person> returnThese = new List<Person>();

            //connect to the mysql server

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";
            //define the sql statement to fetch all persons
            MySqlCommand command = new MySqlCommand("SELECT * FROM Person where Name like @search", connection);
            command.CommandText = "SELECT * FROM Person where Name like @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Person a = new Person
                    {
                        PersonID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Vorname = reader.GetString(2),
                        Geburtsdatum = reader.GetInt32(3),
                        Heimatort = reader.GetString(4),
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();


            return returnThese;

        }

        internal int addOnePerson(Person person)
        {
            //connect to the mysql server

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

          
            //define the sql statement to fetch all persons
            MySqlCommand command = new MySqlCommand("INSERT INTO `person`(`Name`, `Vorname`, `Geburtsdatum`, `Heimatort`) VALUES (@name, @vorname, @geburtsdatum, @heimatort)", connection);
            command.Parameters.AddWithValue("@name", person.Name);
            command.Parameters.AddWithValue("@vorname", person.Vorname);
            command.Parameters.AddWithValue("@geburtsdatum", person.Geburtsdatum);
            command.Parameters.AddWithValue("@heimatort", person.Heimatort);

            int newRows  = command.ExecuteNonQuery();


            connection.Close();


            return newRows;
        }

        internal int deletePerson(int personID)
        {
            //connect to the mysql server

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();


            //define the sql statement to fetch all persons
            MySqlCommand command = new MySqlCommand("DELETE FROM `person` WHERE `person`.`PersonID` = @personID;", connection);
            command.Parameters.AddWithValue("@personID", personID);
            

            int result = command.ExecuteNonQuery();
            connection.Close();


            return result;
        }
    }


}



