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
    public partial class entry_pic : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();




        public entry_pic()
        {
            InitializeComponent();
            timer.Interval = 4000;  // 4000 milliseconds = 4 seconds
            timer.Tick += Timer_Tick;  // Attach event handler
            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Hide();  // Hide splash screen
            Form2 form2 = new Form2();  // Create an instance of Form2
            form2.Show();

        }


        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void entry_pic_Load(object sender, EventArgs e)
        {

        }

        private void entry_pic_Load_1(object sender, EventArgs e)
        {

        }
    }
}
