using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class out_And_into : Form
    {
        public out_And_into()
        {
            InitializeComponent();
        }

        private void out_And_into_Load(object sender, EventArgs e)
        {

        }
        
        //在label1中显示现在的时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form admin_login = new admin_login();
            admin_login.Show();
        }
    }
}
