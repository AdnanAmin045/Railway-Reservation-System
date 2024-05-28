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
    public partial class passengerMenu : Form
    {
        DataTable grid = new DataTable();
        public passengerMenu()
        {
            InitializeComponent();
        }

        private void passengerMenu_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            register f = new register();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addInformation i = new addInformation();
            i.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewTrainDetail t = new viewTrainDetail();
            t.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewRecord r = new viewRecord();
            r.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeTrain t = new changeTrain();
            t.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            changeCategory c = new changeCategory();
            c.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cancelTrain c = new cancelTrain();
            c.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            feedback f = new feedback();
            f.Show();
            this.Hide();
        }
    }
}
