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
    public partial class adminMenu : Form
    {
        DataTable grid1 = new DataTable();
        DataTable grid2 = new DataTable();
        public adminMenu()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            register f = new register();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTrainInformation i = new addTrainInformation();
            i.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewTrain v = new viewTrain();
            v.Show();
            this.Hide();
        }

        private void adminMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewPassenger v = new viewPassenger();
            v.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeSeats s = new changeSeats();
            s.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            changePrice p = new changePrice();
            p.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            deleteTrain d = new deleteTrain();
            d.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            seeFeedbackcs b = new seeFeedbackcs();
            b.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            update u = new update();
            u.Show();
            this.Hide();
        }
    }
}
