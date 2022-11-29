using LoginAndRegistration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBillCalculator
{
    public partial class MonthlyBillReport : Form
    {
        public MonthlyBillReport()
        {
            InitializeComponent();
        }

        private void loansViewBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home=new Home();
            home.ShowDialog();  
        }
    }
}
