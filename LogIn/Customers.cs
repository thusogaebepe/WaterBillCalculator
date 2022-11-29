using LoginAndRegistration;

namespace WaterBillCalculator
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userEntry = "";
            //validate filling all fields
            if (txtfirstname.Text.Contains("#") || txtsurname.Text.Contains("#") || txtplotnumber.Text.Contains("#"))
                MessageBox.Show("'#' character not allowed");
            else if (txtfirstname.Text.Equals("") || txtsurname.Text.Equals("") || txtplotnumber.Text.Equals(""))
                MessageBox.Show("All fields must be filled");


            else
            {


                MessageBox.Show("Customer Added Successfully");
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
            }


        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }
    }
}
