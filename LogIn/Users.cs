using LoginAndRegistration;

namespace WaterBillCalculator
{
    public partial class Users : Form
    {

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userEntry = "";
            //validate filling all fields
            if (txtfirstname.Text.Contains("#") || txtsurname.Text.Contains("#") || txtphonenumber.Text.Contains("#"))
                MessageBox.Show("'#' character not allowed");
            else if (txtfirstname.Text.Equals("") || txtsurname.Text.Equals("") || txtphonenumber.Text.Equals(""))
                MessageBox.Show("All fields must be filled");


            else
            {


                MessageBox.Show("User Added Successfully");
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
