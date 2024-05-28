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
    public partial class changeSeats : Form
    {
        DataTable grid1 = new DataTable();
        DataTable grid2 = new DataTable();

        public changeSeats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
            {

                if (trainDL.searchTrain(textBox1.Text))
                {
                    if (textBox2.Text == "Add" || textBox2.Text == "Subtract")
                    {
                        trainDL.changeSeat(textBox1.Text, textBox2.Text, textBox3.Text);
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
                        MessageBox.Show("Changing has been Saved", "Changing");
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Information", "Changing Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Trian is not available", "Changes Failed");
                }
            }
            else
            {
                MessageBox.Show("Fill in the Box", "Changes Failed");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminMenu m = new adminMenu();
            m.Show();
            this.Hide();
        }

        private void changeSeats_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            grid1.Columns.Clear();
            grid1.Rows.Clear();
            grid1.Columns.Add("Trarin Name", typeof(System.String));
            grid1.Columns.Add("Total Seats", typeof(System.String));
            grid1.Columns.Add("Route", typeof(System.String));
            grid1.Columns.Add("Economy Price", typeof(System.String));
            grid1.Columns.Add("Business Price", typeof(System.String));
            grid1.Rows.Clear();
            for (int n = 0; n < trainDL.trainData.Count; n++)
            {
                train train = trainDL.trainData[n];
                grid1.Rows.Add(train.getName(), train.getSeat(), train.getRoute(), train.getEconomyPrice(), train.getBusinessPrice());
            }
            dataGridView1.DataSource = grid1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
