using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace quaran_app
{
    internal class tafsir_data_access
    {
        string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=quaran_data_base";
        public List<Tafsir> extract_surah_tafsir(int ayah_id)
        // create function that return list of objects from class surah that have same attributtes of the data base 
        {
            List<Tafsir> tafser_text = new List<Tafsir>();
            // creation of the empty lost to repare it to filling then return it 

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand select_surah_tafsir = new MySqlCommand("SELECT tafsir_text FROM tafsir WHERE ayah_id= @ayah_id", connection);
            select_surah_tafsir.Parameters.AddWithValue("@ayah_id", ayah_id);

            using (MySqlDataReader reader = select_surah_tafsir.ExecuteReader())
            // to read the sql command we provide as string and apply it through each row
            {
                while (reader.Read())
                // extract the values from data base based on its type
                // object is represent table and this object contans list of rows
                {

                    Tafsir s = new Tafsir()
                    {
                        tafsir_text = reader.GetString(0),

                    };
                    tafser_text.Add(s);
                }

            }
          ;

            connection.Close();

            return tafser_text;
        }








    }
}
