using ABC203;
using WaterBillCalculator;

namespace LoginAndRegistration
{
    public partial class Home : Form
    {
        UserAccounts userAccounts = new UserAccounts();
        public Home()
        {
            InitializeComponent();
        }

        double a;
        double b;
        double c;
        double d;
        double ex;
        double f;
        double g;
        double h;
        double i;
        double j;
        double y;
        double z;

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MonthlyReport_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers customer = new Customers();
            customer.ShowDialog();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CalculateBill_Click(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                y = 0.00;
            }

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                z = 0.00;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                a = 3.60;
            }
            else
            {
                radioButton12.Checked = true;
                a = 4.92;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                b = 13.43;
            }
            else
            {
                radioButton12.Checked = true;
                b = 14.61;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                c = 23.51;
            }
            else radioButton12.Checked = true;
            {
                c = 25.58;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                d = 36.16;
            }
            else radioButton12.Checked = true;
            {
                d = 36.16;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                ex = 45.21;
            }
            else radioButton12.Checked = true;
            {
                ex = 49.20;
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                f = 0.65;
                label7.Text = (y + a + f).ToString();
            }
            else radioButton12.Checked = true;
            {
                f = 0.74;
                label7.Text = (z + a + f).ToString();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                g = 3.36;
                label7.Text = (y + b + g).ToString();
            }
            else radioButton12.Checked = true;
            {
                g = 3.36;
                label7.Text = (z + b + g).ToString();
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                h = 5.03;
                label7.Text = (y + c + h).ToString();
            }
            else radioButton12.Checked = true;
            {
                h = 5.03;
                label7.Text = (z + c + h).ToString();
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                i = 6.71;
                label7.Text = (y + d + i).ToString();
            }
            else radioButton12.Checked = true;
            {
                i = 6.71;
                label7.Text = (z + d + i).ToString();
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                j = 8.39;
                label7.Text = (y + ex + j).ToString();
            }
            else radioButton12.Checked = true;
            {
                j = 8.39;
                label7.Text = (z + ex + j).ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
   
}


