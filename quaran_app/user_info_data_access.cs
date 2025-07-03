using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace quaran_app
{
    internal class user_info_data_access
    {
        string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=quaran_data_base";

        public void InsertUser(string name, string user_password, int phone_number)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand insert_into_command = new MySqlCommand(
                    "INSERT INTO user_info (user_name, user_password, phone_number) VALUES (@name, @user_password, @phone_number)",
                    connection);

                insert_into_command.Parameters.AddWithValue("@name", name);
                insert_into_command.Parameters.AddWithValue("@user_password", user_password);
                insert_into_command.Parameters.AddWithValue("@phone_number", phone_number);

                int rowsAffected = insert_into_command.ExecuteNonQuery(); // Executes the query

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account creation is done welcom");

                }
                else
                {
                    MessageBox.Show("خش سجل يا حبيب اخوك");
                }
            }
        }

     


            public bool SearchUser(string name, string user_password)
            {
            bool status = false; ; // Will hold the matching user info if found

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                connection.Open();


                MySqlCommand searchCommand = new MySqlCommand(
                        "SELECT user_name, user_password FROM user_info WHERE user_name = @name AND user_password = @user_password",connection);

                    searchCommand.Parameters.AddWithValue("@name", name);
                    searchCommand.Parameters.AddWithValue("@user_password", user_password);
                using (MySqlDataReader reader = searchCommand.ExecuteReader())
                    {
                        if (reader.Read()) // If a match is found
                        {
                        status=true;
                        //MessageBox.Show("Success!");
                    }



                }
                }
            return status;
                
            }
        }
    }
































