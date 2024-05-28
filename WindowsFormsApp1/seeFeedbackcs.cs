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
    public partial class seeFeedbackcs : Form
    {
        DataTable grid1 = new DataTable();
        public seeFeedbackcs()
        {
            InitializeComponent();
        }

        private void seeFeedbackcs_Load(object sender, EventArgs e)
        {
            grid1.Columns.Clear();
            grid1.Rows.Clear();
            grid1.Columns.Add("Feedback", typeof(System.String));
            grid1.Rows.Clear();
            for(int n =0; n<feedbackDL.data.Count;n++)
            {
            grid1.Rows.Add(feedbackDL.data[n]);
            }
            dataGridView1.DataSource = grid1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminMenu p = new adminMenu();
            p.Show();
            this.Hide();
        }
    }
}
