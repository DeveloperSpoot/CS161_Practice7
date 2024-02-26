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
    }
}
