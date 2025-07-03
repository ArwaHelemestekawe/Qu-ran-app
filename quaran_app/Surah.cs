using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quaran_app
{
    internal class Surah
    {
        public int surah_id { get; set; }

        public string name { get; set; }

        public int total_number_of_ayat { get; set; }

        public int revalation_order { get; set; }

        public string type { get; set; }

        public int reader_id {  get; set; }


        public string video_url { get; set; }


    }
}
