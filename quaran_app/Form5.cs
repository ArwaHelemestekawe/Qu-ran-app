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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            user_info_data_access user_data_access = new user_info_data_access();
            string name = guna2TextBox3.Text;
            string password = guna2TextBox2.Text;
            int phone_number = int.Parse(guna2TextBox4.Text);
            user_data_access.InsertUser(name, password, phone_number);

            Form3 newForm = new Form3(); // Create instance of the new form
            newForm.Show(); // Show the new form
            this.Close();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
