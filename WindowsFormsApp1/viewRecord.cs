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

namespace WindowsFormsApp1
{
    public partial class viewRecord : Form
    {
        DataTable grid1 = new DataTable();
        public viewRecord()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (passengerDL.searchPerson(textBox1.Text, textBox2.Text))
                {
                    int n = passengerDL.findIndex(textBox1.Text, textBox2.Text);
                    grid1.Columns.Clear();
                    grid1.Rows.Clear();
                    grid1.Columns.Add("Passenger Name", typeof(System.String));
                    grid1.Columns.Add("CNIC NO", typeof(System.String));
                    grid1.Columns.Add("Train Name", typeof(System.String));
                    grid1.Columns.Add("Ticket Categroy", typeof(System.String));
                    grid1.Rows.Clear();
                    passenger passenger = passengerDL.passengerData[n];
                    grid1.Rows.Add(passenger.getName(), passenger.getCNIC(), passenger.getTrainName(), passenger.getCategory());
                    dataGridView1.DataSource = grid1;
                }
                else
                {
                    MessageBox.Show("Record Not Found", "View Failed");
                }

            }
            else
            {
                MessageBox.Show("Fill the Boxes", "View Failed");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            passengerMenu m = new passengerMenu();
            m.Show();
            this.Hide();
        }

        private void viewRecord_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
