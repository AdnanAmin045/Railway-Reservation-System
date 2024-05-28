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
    public partial class viewTrain : Form
    {
        DataTable grid1 = new DataTable();
        public viewTrain()
        {
            InitializeComponent();
        }

        private void viewTrain_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            adminMenu m = new adminMenu();
            m.Show();
            this.Hide();
        }
    }
}
