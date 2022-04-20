using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textUsername.Text;
            pass = textPassword.Text;
            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("successfull");
            }
            else
            {
                MessageBox.Show("error");
            }

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
