using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quaran_app
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ayah_data_access ayah = new ayah_data_access();
            Surah_data_access_object surah = new Surah_data_access_object();
            tafsir_data_access tafsir = new tafsir_data_access();

            string surah_order = guna2TextBox5.Text;

            StringBuilder ayahTextBuilder = new StringBuilder();
            StringBuilder tafsirTextBuilder = new StringBuilder();


            foreach (ayah a in ayah.search_ayat_of_surah(surah_order))
            {
                ayahTextBuilder.AppendLine(a.ayah_text + '\n');
                foreach (Tafsir s in tafsir.extract_surah_tafsir(a.ayah_id))
                {
                    tafsirTextBuilder.AppendLine(s.tafsir_text + '\n');


                }

            }

            guna2TextBox1.Text = ayahTextBuilder.ToString();
            guna2TextBox2.Text = tafsirTextBuilder.ToString();






        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
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
