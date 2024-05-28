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
    public partial class deleteTrain : Form
    {
        DataTable grid1 = new DataTable();
        DataTable grid2 = new DataTable();
        public deleteTrain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (trainDL.searchTrain(textBox1.Text))
                {

                    trainDL.deleteTrain(textBox1.Text);
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
                    MessageBox.Show("Data has been Deleting", "Deleting ");
                }
                else
                {
                    MessageBox.Show("Train is not Available", "Deleting Failed ");
                }

            }
            else
            {
                MessageBox.Show("Fill the Box", "Deleting Failed");
            }
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminMenu m = new adminMenu();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grid1.Columns.Clear();
            grid1.Rows.Clear();
            grid1.Columns.Add("Train Name", typeof(System.String));
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

        private void deleteTrain_Load(object sender, EventArgs e)
        {
            grid2.Columns.Clear();
            grid2.Rows.Clear();
            grid2.Columns.Add("Train Name", typeof(System.String));
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
