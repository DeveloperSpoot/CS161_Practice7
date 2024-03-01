namespace CS161_Practice7.Problems
{
    public partial class NameSearch : Form
    {
        public NameSearch()
        {
            InitializeComponent();
        }

        private List<string> popNames = new List<string>(); // Global list to contain all the popular names.

        private void NameSearch_Load(object sender, EventArgs e) // Load event to load all names into the above list.
        {
            try
            {
                StreamReader namesFile = File.OpenText("popular_names.txt");

                while(!namesFile.EndOfStream)
                {
                    popNames.Add(namesFile.ReadLine()); // Adding each name to the list.
                }
                namesFile.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e) // Search button to search for the inputed name.
        {
            string nameToSearch = inputTextBox.Text; // Getting the input text.

            if(popNames.Contains(nameToSearch)) // Checking to see if the input is in the list. and outputting the results.
            {
                resaultLabel.Text = "This name was one of the most popular names!";
            }
            else
            {
                resaultLabel.Text = "This name was NOT the most popular.";
            }
        }

        //Exit button event method, obv.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
