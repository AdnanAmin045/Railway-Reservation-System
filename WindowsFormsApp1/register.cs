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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {
            bool status = signUpRecord.checkdata(textBox1.Text, textBox2.Text);
            if (!(adminDL.searchName(textBox1.Text) && adminDL.searchPassword(textBox2.Text)))
            {
                if (!(textBox1.Text == "" || textBox2.Text == ""))
                {
                    signUpRecord d = new signUpRecord();
                    d.setName(textBox1.Text);
                    d.setPassword(textBox2.Text);
                    signUpRecord.signUpData.Add(d);
                    passengerMenu m = new passengerMenu();
                    signUpRecord.storeData(signUpRecord.signUpData);
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please! Enter UserName and Password", "Registration Failed");
                }
            }
            else
            {
                MessageBox.Show("Please! SigIn You have already register", "Registration Failed");
                textBox1.Text = "";
                textBox2.Text = "";

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

            signIn i = new signIn();
            i.Show();
            this.Hide();
        }
    }
}
