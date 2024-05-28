using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminMenu a = new adminMenu();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = adminDL.index(textBox1.Text);
            if(textBox1.Text != "" || textBox2.Text != "")
            {
                if(adminDL.searchPassword(textBox1.Text))
                {
                    adminDL.admin[index].setPassword(textBox2.Text);
                    adminDL.storeData(adminDL.admin);
                    MessageBox.Show("Data has been Saved", "Save");

                }
                else
                {
                    MessageBox.Show("Old Password is not Correct", "Save Failed");
                }
            }
            else
            {
                MessageBox.Show("Fill in the Box", "Save Failed");
            }
        }
    }
}
