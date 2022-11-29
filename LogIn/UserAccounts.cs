namespace ABC203
{
    class UserAccounts
    {

        private string userFilePath = "Users.txt";
        private string userLogsFilePath = "log.txt";
        public string userName = "";
        public UserAccounts()
        {

        }
        public bool AddUser(string userFirstName, string userSurname, string userType, string userPlotNumber, string userLocation)
        {
            string userDetails = userFirstName + "#" + userSurname + "#" + userType + "#" + userPlotNumber + "#" + userLocation + "#";
            bool userAdded = false;

            fileWriter(userDetails, userFilePath);
            userAdded = true;
            return userAdded;

        }

        public bool userLogin(string username, string password)
        {
            bool loginSuccessful = false;
            if (File.Exists(userFilePath))
                using (StreamReader streamReader = File.OpenText(userFilePath))
                {
                    string line = "";

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] lineDetails = line.Split('#');
                        if (lineDetails[0].Equals(username) && lineDetails[1].Equals(password)) //username and password are a match
                        {
                            loginSuccessful = true;
                            string logString = username + ", " + DateTime.Now.ToString();
                            fileWriter(logString, userLogsFilePath);
                        }

                    }
                    streamReader.Close();
                }

            return loginSuccessful;

        }




        private void fileWriter(string content, string filePath)
        {


            StreamWriter streamWriter;
            if (!File.Exists(filePath))
            {
                // Create a file to write to.
                streamWriter = new StreamWriter(filePath, true);
            }
            else
                streamWriter = File.AppendText(filePath);

            streamWriter.WriteLine(content);

            streamWriter.Close();

        }


    }
}