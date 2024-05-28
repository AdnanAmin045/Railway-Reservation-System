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
    public partial class addInformation : Form
    {
        DataTable grid2 = new DataTable();
        public addInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == ""))
            {
                if (textBox2.Text.Length == 13)
                {
                    if (trainDL.searchTrain(textBox3.Text))
                    {
                        if((textBox4.Text == "Economy" || textBox4.Text == "Economy") || (textBox4.Text == "Business" || textBox4.Text == "business"))
                        {
                        passenger d = new passenger();
                        d.setName(textBox1.Text);
                        d.setCNIC(textBox2.Text);
                        d.setTrainName(textBox3.Text);
                        d.setCategory(textBox4.Text);
                        passengerDL.passengerData.Add(d);
                        passengerDL.storeData(passengerDL.passengerData);
                        MessageBox.Show("Your Data has been Saved", "Add Information");
                        }
                        else
                        {
                            MessageBox.Show("Category is not Available:  Select(Economy/Business)", "Add Information Failed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Train is not Available", "Add Information Failed");
                    }

                }
                else
                {
                    MessageBox.Show("CNIC should have 13 digit", "Add Information Failed");
                }
            }
            else
                MessageBox.Show("Please! Enter Complete Information", "Add Informtion");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            passengerMenu m = new passengerMenu();
            m.Show();
            this.Hide();
        }

        private void addInformation_Load(object sender, EventArgs e)
        {
            grid2.Columns.Clear();
            grid2.Rows.Clear();
            grid2.Columns.Add("Trarin Name", typeof(System.String));
            grid2.Columns.Add("Total Seats", typeof(System.String));
            grid2.Columns.Add("Route", typeof(System.String));
            grid2.Columns.Add("Economy Price", typeof(System.String));
            grid2.Columns.Add("Business Price", typeof(System.String));
            grid2.Rows.Clear();
            for (int n = 0; n < trainDL.trainData.Count; n++)
            {
                train train = trainDL.trainData[n];
                grid2.Rows.Add(train.getName(), train.getSeat(), train.getRoute(), train.getEconomyPrice(), train.getBusinessPrice());
            }
            dataGridView1.DataSource = grid2;

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
