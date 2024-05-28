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
    public partial class addTrainInformation : Form
    {
        DataTable grid2 = new DataTable();
        public addTrainInformation()
        {
            InitializeComponent();
        }

        private void addTrainInformation_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (trainDL.searchTrain(textBox1.Text) == false)
            {

                if (!(textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == ""))
                {
                    train t = new train();
                    t.setName(textBox1.Text);
                    t.setSeat(int.Parse(textBox2.Text));
                    t.setRoute(textBox3.Text);
                    t.setEconomyPrice(float.Parse(textBox4.Text));
                    t.setBusinessPrice(float.Parse(textBox5.Text));
                    trainDL.trainData.Add(t);
                    trainDL.storeData(trainDL.trainData);
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
                    MessageBox.Show("Your Data has been Saved", "Add Information");
                }
                else
                    MessageBox.Show("Please! Enter Complete Information", "Add Informtion");
            }
            else
            {
                MessageBox.Show("This Train is also Available Use another Name", "Add Informtion");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminMenu m = new adminMenu();
            m.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
