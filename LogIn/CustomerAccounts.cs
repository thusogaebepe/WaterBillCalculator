namespace ABC203
{
    class CustomerAccounts
    {

        private string customerFilePath = "customerDetails.txt";
        public CustomerAccounts()
        {

        }
        public bool addCustomer(string newCustomerFirstname, string newCustomerSurname, string newCustomerPlotNumber, string newCustomerLocation, string newCustomerUserType)
        {
            bool customerAdded = false;
            string customerDetails = newCustomerFirstname + "#" + newCustomerSurname + "#" + newCustomerPlotNumber + "#" + newCustomerLocation + "#" + newCustomerUserType + "#" + DateTime.Now.ToString();


            if (!customerExists(customerDetails))
            {
                this.fileWriter(customerDetails, customerFilePath);
                customerAdded = true;
            }
            return customerAdded;

        }


        private bool customerExists(String customerDetails)
        {
            bool customerExists = false;
            string[] customerDetailsArray = customerDetails.Split('#');
            string[] existingCustomerDetailsArray = this.getCustomerDetails(customerDetailsArray[2]);


            if (existingCustomerDetailsArray != null) //customer already exists
                customerExists = true;


            return customerExists;
        }

        public string[] getCustomerDetails(string customerNumber)
        {
            string[]? customerDetailsArray = null;
            if (File.Exists(customerFilePath))
                using (StreamReader streamReader = File.OpenText(customerFilePath))
                {
                    string line = "";

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] lineDetails = line.Split('#');
                        if (lineDetails[2].Equals(customerNumber))
                            customerDetailsArray = lineDetails;

                    }
                    streamReader.Close();
                }
            return customerDetailsArray;
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
