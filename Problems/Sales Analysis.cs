namespace CS161_Practice7.Problems
{
    public partial class Sales_Analysis : Form
    {
        public Sales_Analysis()
        {
            InitializeComponent();
        }

        private void loadFileButton_Method(object sender, EventArgs e)
        {
            double total = 0.00;

            try
            {

                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader inputFile = new StreamReader(openFileDialog1.FileName);

                    double[] inputedSales = new double[100];

                    int lineIdex = 0;

                    while (!inputFile.EndOfStream)
                    {
                        double currentSale = double.Parse(inputFile.ReadLine());
                        inputedSales[lineIdex] = currentSale;
                        lineIdex++;

                        total += currentSale;

                        salesListBox.Items.Add(currentSale.ToString());
                    }

                    double highest = inputedSales[0];
                    double lowest = inputedSales[0];

                    for(int i = 0; i < lineIdex; i++)
                    {
                        if (inputedSales[i] > highest) {
                            highest = inputedSales[i];
                        }

                        if (inputedSales[i] < lowest)
                        {
                            lowest = inputedSales[i];
                        }
                    }

                    totalLabel.Text = total.ToString("c");
                    averageLabel.Text = (total/lineIdex).ToString("c");
                    largestLabel.Text = highest.ToString("c");
                    smallestLabel.Text = lowest.ToString("c");
              
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void exitButton_Method(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
