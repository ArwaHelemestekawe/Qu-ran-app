using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace quaran_app
{
    internal class Surah_data_access_object
    {
        string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=quaran_data_base";

        public List<Surah> get_all_surahs()
            // create function that return list of objects from class surah that have same attributtes of the data base 
        {
            List<Surah> surahs = new List<Surah>();
            // creation of the empty lost to repare it to filling then return it 

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand select_all_command = new MySqlCommand("select * from surah", connection);

            using (MySqlDataReader reader = select_all_command.ExecuteReader())
                // to read the sql command we provide as string and apply it through each row
            {
                while (reader.Read())
                // extract the values from data base based on its type
// object is represent table and this object contans list of rows
                {

                    Surah s = new Surah()
                    {
                        surah_id=reader.GetInt32(0),
                        name=reader.GetString(1),
                        total_number_of_ayat=reader.GetInt32(2),    
                        revalation_order=reader.GetInt32(3),
                        type=reader.GetString(4), 
                        reader_id=reader.GetInt32(5),

                    };
                    surahs.Add(s);
                }

            };

            connection.Close();

            return surahs;
        }







        public List<Surah> search_surah_name(string surah_name)
        // create function that return list of objects from class surah that have same attributtes of the data base 
        {
            List<Surah> surahs = new List<Surah>();
            // creation of the empty lost to repare it to filling then return it 

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand select_surah_command = new MySqlCommand("SELECT * FROM surah WHERE name = @surah_name", connection);
            select_surah_command.Parameters.AddWithValue("@surah_name", surah_name);

            using (MySqlDataReader reader = select_surah_command.ExecuteReader())
            // to read the sql command we provide as string and apply it through each row
            {
                while (reader.Read())
                // extract the values from data base based on its type
                // object is represent table and this object contans list of rows
                {

                    Surah s = new Surah()
                    {
                        surah_id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        total_number_of_ayat = reader.GetInt32(2),
                        revalation_order = reader.GetInt32(3),
                        type = reader.GetString(4),
                        reader_id = reader.GetInt32(5),

                    };
                    surahs.Add(s);
                }

            }
            ;

            connection.Close();


           
            return surahs;
        }

        public string surah_url_search(int order)
        {
 List<string> list_url = new List<string>();
list_url = ["file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/001.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/002.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/003.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/004.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/005.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/006.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/007.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/008.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/009.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/010.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/011.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/012.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/013.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/014.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/015.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/016.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/017.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/018.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/019.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/020.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/021.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/022.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/023.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/024.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/025.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/026.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/027.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/028.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/029.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/030.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/031.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/032.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/033.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/034.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/035.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/036.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/037.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/038.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/039.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/040.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/041.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/042.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/043.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/044.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/045.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/046.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/047.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/048.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/049.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/050.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/051.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/052.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/053.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/054.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/055.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/056.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/057.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/058.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/059.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/060.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/061.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/062.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/063.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/064.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/065.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/066.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/067.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/068.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/069.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/070.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/071.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/072.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/073.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/074.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/075.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/076.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/077.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/078.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/079.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/080.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/081.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/082.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/083.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/084.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/085.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/086.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/087.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/088.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/089.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/090.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/091.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/092.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/093.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/094.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/095.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/096.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/097.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/098.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/099.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/100.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/101.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/102.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/103.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/104.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/105.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/106.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/107.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/108.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/109.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/110.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/111.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/112.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/113.mp3" ,
"file:///C:/Users/arwah/Downloads/koonoz_blogspot_com_Maher/114.mp3" ];

            string Path = list_url[order - 1];


            return Path;
        }








        public List<Surah> search_surah_order(string surah_order)
        // create function that return list of objects from class surah that have same attributtes of the data base 
        {
            List<Surah> surahs = new List<Surah>();
            // creation of the empty lost to repare it to filling then return it 

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand select_surah_order = new MySqlCommand("SELECT * FROM surah WHERE surah_id= @surah_order", connection);
            select_surah_order.Parameters.AddWithValue("@surah_order", surah_order);

            using (MySqlDataReader reader = select_surah_order.ExecuteReader())
            // to read the sql command we provide as string and apply it through each row
            {
                while (reader.Read())
                // extract the values from data base based on its type
                // object is represent table and this object contans list of rows
                {

                    Surah s = new Surah()
                    {
                        surah_id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        total_number_of_ayat = reader.GetInt32(2),
                        revalation_order = reader.GetInt32(3),
                        type = reader.GetString(4),
                        reader_id = reader.GetInt32(5),
                        video_url = reader.GetString(6),

                    };
                    surahs.Add(s);
                }

            }
            ;

            connection.Close();

            return surahs;
        }



        public List<Surah> extract_surah_name(int surah_order)
        // create function that return list of objects from class surah that have same attributtes of the data base 
        {
            List<Surah> names = new List<Surah>();
            // creation of the empty lost to repare it to filling then return it 

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand select_surah_order = new MySqlCommand("SELECT name FROM surah WHERE surah_id= @surah_order", connection);
            select_surah_order.Parameters.AddWithValue("@surah_order", surah_order);

            using (MySqlDataReader reader = select_surah_order.ExecuteReader())
            // to read the sql command we provide as string and apply it through each row
            {
                while (reader.Read())
                // extract the values from data base based on its type
                // object is represent table and this object contans list of rows
                {

                    Surah s = new Surah()
                    {
                        name = reader.GetString(0),
                        
                    };
                    names.Add(s);
                }

            }
            ;

            connection.Close();

            return names;
        }



























        public List<Surah> view_surah_audio(string number)
        // create function that return list of objects from class surah that have same attributtes of the data base 
        {
            List<Surah> surahs_url = new List<Surah>();
            // creation of the empty lost to repare it to filling then return it 

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand select_surah_audio = new MySqlCommand("SELECT video_url FROM surah WHERE surah_id= @number", connection);
            select_surah_audio.Parameters.AddWithValue("@number", number);

            using (MySqlDataReader reader = select_surah_audio.ExecuteReader())
            // to read the sql command we provide as string and apply it through each row
            {
                while (reader.Read())
                // extract the values from data base based on its type
                // object is represent table and this object contans list of rows
                {

                    Surah s = new Surah()
                    {
                        surah_id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        total_number_of_ayat = reader.GetInt32(2),
                        revalation_order = reader.GetInt32(3),
                        type = reader.GetString(4),
                        reader_id = reader.GetInt32(5),
                        video_url = reader.GetString(6),

                    };
                    surahs_url.Add(s);
                }

            }
           ;

            connection.Close();

            return surahs_url;
        }
        

            
        


    }
}
