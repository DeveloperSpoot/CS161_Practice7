namespace CS161_Practice7.Problems
{
    public partial class Charge_Account_Validation : Form
    {
        public Charge_Account_Validation()
        {
            InitializeComponent();
        }

        private List<string> validAccountNumbers = new List<string>();

        private void checkButton_Click(object sender, EventArgs e)
        {
            string enteredAccNumber = accountNumberTextBox.Text;

            if (validAccountNumbers.Contains(enteredAccNumber))
            {
                validationStatusLabel.BackColor = Color.LimeGreen;
                validationStatusLabel.Text = "VALID";
            }
            else
            {
                validationStatusLabel.BackColor = Color.Tomato;
                validationStatusLabel.Text = "INVALID";
            }
        }
        private void Charge_Account_Validation_Load(object sender, EventArgs e)
        {
            try
            {

                StreamReader validAccountsFile = File.OpenText("ChargeAccounts.txt");

                while (!validAccountsFile.EndOfStream)
                {
                    string accountNumber = validAccountsFile.ReadLine();

                    validAccountNumbers.Add(accountNumber);
                }

                validAccountsFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accountNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            validationStatusLabel.Text = "Enter Charge Account Number.";
            validationStatusLabel.BackColor = Color.DarkGoldenrod;
        }
    }
}
