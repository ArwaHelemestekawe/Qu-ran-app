using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quaran_app
{
    public partial class Form3 : Form
    {
        private BindingSource surahBindingSource = new BindingSource();
        private BindingSource ayahBindingSource = new BindingSource();


        public Form3()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Surah_data_access_object surah = new Surah_data_access_object();
            string name = guna2TextBox1.Text;
            surahBindingSource.DataSource = surah.search_surah_name(name);
            guna2DataGridView1.DataSource = surahBindingSource;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Surah_data_access_object surah = new Surah_data_access_object();
            surahBindingSource.DataSource = surah.get_all_surahs();
            guna2DataGridView1.DataSource = surahBindingSource;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            Surah_data_access_object surah = new Surah_data_access_object();
            string order = guna2TextBox2.Text;
            surahBindingSource.DataSource = surah.search_surah_order(order);
            guna2DataGridView1.DataSource = surahBindingSource;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Surah_data_access_object surah = new Surah_data_access_object();
            int surah_order = int.Parse(guna2TextBox2.Text);

            axWindowsMediaPlayer1.URL = surah.surah_url_search(surah_order);
            axWindowsMediaPlayer1.Ctlcontrols.play();


        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ayah_data_access ayah_Data_Access = new ayah_data_access();
            Surah_data_access_object surah = new Surah_data_access_object();
            string order = guna2TextBox2.Text;
            ayahBindingSource.DataSource = ayah_Data_Access.search_ayat_of_surah(order);
            // guna2TextBox3.Text = string.Join(Environment.NewLine, ayah_Data_Access.search_ayat_of_surah(order).Select(a => a.ayah_text));
            StringBuilder ayahTextBuilder = new StringBuilder();

            foreach (ayah a in ayah_Data_Access.search_ayat_of_surah(order))
            {
                ayahTextBuilder.AppendLine(a.ayah_text + '\n');
            }

            guna2TextBox3.Text = ayahTextBuilder.ToString();

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(); // Create instance of the new form
            newForm.Show(); // Show the new form
            this.Close();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4(); // Create instance of the new form
            newForm.Show(); // Show the new form
            this.Close();

        }
    }
}
