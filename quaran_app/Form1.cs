using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace quaran_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ayah_data_access ayah = new ayah_data_access();

            Surah_data_access_object surah = new Surah_data_access_object();
            string ayah_text = guna2TextBox1.Text;

            StringBuilder ayahTextBuilder = new StringBuilder();


            foreach (ayah a in ayah.search_similar(ayah_text))
            {
                ayahTextBuilder.AppendLine(a.ayah_text_no_tashkeel + '\n');
                foreach (Surah s in surah.extract_surah_name(a.surah_id))
                {
                    ayahTextBuilder.AppendLine("(" + s.name + ")" + '\n');
                    ayahTextBuilder.AppendLine("-------------------------------------------");
                }
            }

            guna2TextBox2.Text = ayahTextBuilder.ToString();




        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(); // Create instance of the new form
            newForm.Show(); // Show the new form
            this.Close();
        }
    }
}
