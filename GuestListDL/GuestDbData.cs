using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GuestListModel;


namespace GuestListDL
{
    public class GuestDbData
    {
        string connectionString
               = "Data Source =LAPTOP-VESUE4DG\\SQLEXPRESS01; Initial Catalog = GuestListManagement; Integrated Security = True;";

        SqlConnection sqlConnection;

        public GuestDbData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<Guest> GetUsers()
        {
            string selectStatement = "SELECT name, nationality, email, age FROM guest";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            List<Guest> users = new List<Guest>();

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                string nationality = reader["nationality"].ToString();
                string email = reader["email"].ToString();
                string age = reader["age"].ToString();

                Guest readUser = new Guest();
                readUser.name = name;
                readUser.nationality = nationality;
                readUser.email = email;
                readUser.age = age;
                users.Add(readUser);
            }

            sqlConnection.Close();

            return users;
        }

        public int AddGuest(string name, string nationality, string email, string age)
        {
            int success;

            string insertStatement = "INSERT INTO users VALUES (@name, @natinality, @email, @age)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@name", name);
            insertCommand.Parameters.AddWithValue("@nationality", nationality);
            insertCommand.Parameters.AddWithValue("@email", email);
            insertCommand.Parameters.AddWithValue("@age", age);
            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int UpdateGuest(string name, string nationality, string email, string age)
        {
            int success;

            string updateStatement = $"UPDATE users SET address = @address WHERE name = @name";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@nationality", nationality);
            updateCommand.Parameters.AddWithValue("@name", name);

            success = updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int DeleteGuest(string name)
        {
            int success;

            string deleteStatement = $"DELETE FROM users WHERE name = @name";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            sqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@name", name);

            success = deleteCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }
    }
}
