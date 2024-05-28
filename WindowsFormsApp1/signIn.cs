using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using signUp;

namespace WindowsFormsApp1
{
    public partial class signIn : Form
    {
        string name, password;
        public signIn()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            if (name == "Adnan" && password == "123")
            {
                adminMenu m = new adminMenu();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("InValid Input! Please Enter Correct Inforamtion", "LogIn Failed");
                textBox2.Text = "";
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            register s = new register();
            s.Show();
            this.Hide();
        }

        private void signIn_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            if (!(textBox1.Text == "" && textBox2.Text == ""))
            {
                if (adminDL.searchName(textBox1.Text) && adminDL.searchPassword(textBox2.Text))
                {
                    adminMenu m = new adminMenu();
                    m.Show();
                    this.Hide();
                }
                if (signUpRecord.checkdata(textBox1.Text, textBox2.Text))
                {
                    passengerMenu m = new passengerMenu();
                    m.Show();
                    this.Hide();
                }
                if(!((adminDL.searchName(textBox1.Text) && adminDL.searchPassword(textBox2.Text)) || signUpRecord.checkdata(textBox1.Text, textBox2.Text)))
                {
                    MessageBox.Show("Invalid Input! Please Enter Correct Information", "LogIn Failed");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Invalid Input! Please Enter Correct Information", "LogIn Failed");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
           /* forget f = new forget();
            f.Show();
            this.Hide();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }
    }
}
