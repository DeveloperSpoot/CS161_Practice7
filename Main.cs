using CS161_Practice7.Problems;
namespace CS161_Practice7
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void salesAnalysisButton_Click(object sender, EventArgs e)
        {
            Form form = new Sales_Analysis();
            form.Show();

        }

        private void chargeValidationButton_Click(object sender, EventArgs e)
        {
            Form form = new Charge_Account_Validation();
            form.Show();
        }

        private void driversTestButton_Click(object sender, EventArgs e)
        {
            Form form = new Drivers_License_Exam();
            form.Show();
        }

        private void worldSeriesButton_Click(object sender, EventArgs e)
        {
            Form form = new Word_Series_Champions();
            form.Show();
        }

        private void nameSearchButton_Click(object sender, EventArgs e)
        {
            Form form = new NameSearch();
            form.Show();
        }

        private void populationDataButton_Click(object sender, EventArgs e)
        {
            Form form = new US_Population();
            form.Show();
        }
    }
}
