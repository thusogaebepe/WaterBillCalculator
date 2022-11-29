using System.Data.SqlClient;

namespace LoginAndRegistration
{
    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            //switches to log in form when u click the button
            //First, we hide the current form which is registration //
            //Then we create an object of login page and show login form using that object//
        }

        private void button1_Click(object sender, EventArgs e, SqlConnection cn)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userEntry = "";
            //validate filling all fields
            if (txtusername.Text.Contains("#") || txtpassword.Text.Contains("#") || txtemail.Text.Contains("#"))
                MessageBox.Show("'#' character not allowed");
            else if (txtusername.Text.Equals("") || txtpassword.Text.Equals("") || txtemail.Text.Equals(""))
                MessageBox.Show("All fields must be filled");
            //validate email address format
            else if (!txtemail.Text.Contains("@"))
                MessageBox.Show("Invalid email address");

            else
            {

                //when all fields are correctly filled it shows a status message then switches to log in 
                MessageBox.Show("Registration is successful");
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }

        }













    }



}


