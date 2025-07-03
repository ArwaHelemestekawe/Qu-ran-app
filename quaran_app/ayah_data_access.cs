using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace quaran_app
{
    internal class ayah_data_access
    {
        string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=quaran_data_base";

        public List<ayah> search_ayat_of_surah(string surah_id_order)
        {
            List<ayah> ayat = new List<ayah>();

            // Open MySQL connection
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Prepare SQL command
                using (MySqlCommand select_surah_command = new MySqlCommand("SELECT ayah_text,ayah_id FROM ayat WHERE surah_id= @surah_id_order", connection))
                {
                    select_surah_command.Parameters.AddWithValue("@surah_id_order", surah_id_order);

                    // Execute reader
                    using (MySqlDataReader reader = select_surah_command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ayah a = new ayah()
                            {
                                ayah_text = reader.GetString(0),
                                ayah_id=reader.GetInt32(1),
                            };

                            ayat.Add(a);
                        }
                    }
                }
            }

            

            return ayat; // If you need stringArray, consider modifying the return type
        }


        public List<ayah> search_similar(string ayah_text)
        {
            List<ayah> ayat_s = new List<ayah>();

            // Open MySQL connection
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Prepare SQL command
                using (MySqlCommand select_ayah_command = new MySqlCommand("SELECT ayah_text_no_tashkeel,surah_id FROM ayat WHERE ayah_text_no_tashkeel LIKE @ayah_text or ayah_text_no_tashkeel LIKE @ayah_text2", connection))
                {

                    
                        select_ayah_command.Parameters.AddWithValue("@ayah_text",  ayah_text + "%");
                        select_ayah_command.Parameters.AddWithValue("@ayah_text2", "%" + ayah_text );


                    // Execute reader
                    using (MySqlDataReader reader = select_ayah_command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ayah a = new ayah()
                            {
                                ayah_text_no_tashkeel = reader.GetString(0),
                                surah_id = reader.GetInt32(1)
                            };

                            ayat_s.Add(a);
                        }
                    }
                }
            }



            return ayat_s; // If you need stringArray, consider modifying the return type
        }

















    }
}

