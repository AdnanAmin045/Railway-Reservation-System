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
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passengerMenu m = new passengerMenu();
            m.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                feedbackDL.data.Add(textBox1.Text);
                feedbackDL.storeData(feedbackDL.data);
                MessageBox.Show("Data has been Saved", "Save");
            }
            else
            {
                MessageBox.Show("Write in the Box", "Save Failed");
            }
        }
    }
}
