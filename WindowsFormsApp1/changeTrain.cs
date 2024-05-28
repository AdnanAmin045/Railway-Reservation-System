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
    public partial class changeTrain : Form
    {
        DataTable grid1 = new DataTable();
        public changeTrain()
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
            if (textBox3.Text != "")
            {
                if(trainDL.searchTrain(textBox3.Text))
                {
                int x = passengerDL.findIndex(textBox1.Text, textBox2.Text);
                passengerDL.passengerData[x].setTrainName(textBox3.Text);
                passengerDL.storeData(passengerDL.passengerData);
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
                    MessageBox.Show("Data has been Saved", "Save");
                }
                else
                {
                MessageBox.Show("Train Not Available", "Save Failed"); 
                }
            }
            else
            {
                MessageBox.Show("Fill the Box", "Save Failed");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            passengerMenu m = new passengerMenu();
            m.Show();
            this.Hide();
        }

        private void changeTrain_Load(object sender, EventArgs e)
        {

        }
    }
}

