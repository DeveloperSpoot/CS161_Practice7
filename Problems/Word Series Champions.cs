namespace CS161_Practice7.Problems
{
    public partial class Word_Series_Champions : Form
    {
        public Word_Series_Champions()
        {
            InitializeComponent();
        }

        private void Word_Series_Champions_Load(object sender, EventArgs e) // Load event
        {
            try
            {
                StreamReader teamsFile = File.OpenText("Teams.txt"); // Access the teams list.

                while (!teamsFile.EndOfStream)
                {
                    teamsListBox.Items.Add(teamsFile.ReadLine()); // Add all the teams to the selection box/list box.
                }

                teamsFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teamsListBox_SelectedItemChanged(object sender, EventArgs e) // Method to get the number of times a selected team has won.
        {
            try
            {
                StreamReader champsFile = File.OpenText("WorldSeriesWinners.txt"); // Opening the world series winners file.

                int count = 0;
                while (!champsFile.EndOfStream) // Looping through the file and coutning all the wins for the selected team.
                {
                    string curTeam = champsFile.ReadLine();
                    if( curTeam == teamsListBox.SelectedItem.ToString())
                    {
                        count++;
                    }
                }
                champsFile.Close();

                totalLabel.Text = count.ToString(); // Displaying the number of times th selected team has won.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ExitButton method.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
