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
    public partial class viewPassenger : Form
    {
        DataTable grid2 = new DataTable();
        public viewPassenger()
        {
            InitializeComponent();
        }

        private void viewPassenger_Load(object sender, EventArgs e)
        {
            grid2.Columns.Clear();
            grid2.Rows.Clear();
            grid2.Columns.Add("Passenger Name", typeof(System.String));
            grid2.Columns.Add("CNIC No", typeof(System.String));
            grid2.Columns.Add("Train Name", typeof(System.String));
            grid2.Columns.Add("Ticket Categroy", typeof(System.String));
            grid2.Rows.Clear();
            for (int n = 0; n < passengerDL.passengerData.Count; n++)
            {
                passenger passenger = passengerDL.passengerData[n];
                grid2.Rows.Add(passenger.getName(), passenger.getCNIC(), passenger.getTrainName(), passenger.getCategory());
            }
            dataGridView1.DataSource = grid2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminMenu m = new adminMenu();
            m.Show();
            this.Hide();
        }
    }
}
