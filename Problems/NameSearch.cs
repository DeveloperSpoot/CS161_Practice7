namespace CS161_Practice7.Problems
{
    public partial class NameSearch : Form
    {
        public NameSearch()
        {
            InitializeComponent();
        }

        private List<string> popNames = new List<string>();

        private void NameSearch_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader namesFile = File.OpenText("popular_names.txt");

                while(!namesFile.EndOfStream)
                {
                    popNames.Add(namesFile.ReadLine());
                }
                namesFile.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string nameToSearch = inputTextBox.Text;

            if(popNames.Contains(nameToSearch))
            {
                resaultLabel.Text = "This name was one of the most popular names!";
            }
            else
            {
                resaultLabel.Text = "This name was NOT the most popular.";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
