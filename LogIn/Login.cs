using ABC203;
using System.Data.SqlClient;

namespace LoginAndRegistration
{
    public partial class Login : Form
    {

        UserAccounts userAccounts = new UserAccounts();
        CustomerAccounts customerAccounts = new CustomerAccounts();

        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, SqlCommand cmd, SqlDataReader dr, SqlConnection cn)
        {

            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Here, first of all, we check if the user enters a value in both fields. If yes, then continue, otherwise, show an error message.
            //hen we check if the user exists in our database with that username and password.If the user exists, then open the home page which we generated at the start.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userEntry = "";
            //validate filling all fields
            if (txtusername.Text.Contains("#") || txtpassword.Text.Contains("#"))
                MessageBox.Show("'#' character not allowed");
            else if (txtusername.Text.Equals("") || txtpassword.Text.Equals(""))
                MessageBox.Show("All fields must be filled");


            else
            {


                MessageBox.Show("Log in is successful.WELCOME");
                this.Hide();
                Home home = new Home();
                home.ShowDialog();

            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}

