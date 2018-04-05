using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Model
    {
        DbConnection connection = new DbConnection();
        public List<Student> Select() {
            string query = "SELECT * FROM students";

            //Create a list to store the result
            List<Student> ListStudent = new List<Student>();

            //Open connection
            if (connection.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32("id");
                    string rollnumber = dataReader.GetString("rollNumber");
                    string name = dataReader.GetString("name");
                    Student st = new Student(id, rollnumber, name);
                    ListStudent.Add(st);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return ListStudent;
            }
            else
            {
                return ListStudent;
            }
        }

        public void SelectByRollnumber() {

        }

        public void Insert() {

        }

        public void Update() {

        }

        public void Delete() {

        }


    }
}
