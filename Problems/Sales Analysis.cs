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
            double total = 0.00; // initalizing a total double vairable.

            try // Catching any incompetence.
            {

                if(openFileDialog1.ShowDialog() == DialogResult.OK) // Show the user the file dialog and get the selected file.
                {
                    StreamReader inputFile = new StreamReader(openFileDialog1.FileName); // Opening the selected file.

                    double[] inputedSales = new double[100]; // Initalizing a new double array, and assuming there wont be over 100 sales. Could add an input so the user can increase/decrease;

                    int lineIdex = 0; // Tracking the current index of of the file and the number of items in the sales file.

                    while (!inputFile.EndOfStream) // Looping through said file.
                    {
                        double currentSale = double.Parse(inputFile.ReadLine()); // Reading the current line of said file.
                        inputedSales[lineIdex] = currentSale; // Adding said sale to our array.
                        lineIdex++; // Updating our index.

                        total += currentSale; // Updating our total.

                        salesListBox.Items.Add(currentSale.ToString()); // Adding said sale to the display list box.
                    }

                    inputFile.Close(); // Closing the selected file.

                    //Delcaring double vairables to hold the highest and lowest values of our array.
                    double highest = inputedSales[0];
                    double lowest = inputedSales[0];

                    for(int i = 0; i < lineIdex; i++)//Hey look at that, using the index as a refernce for the total amount of actual inputed sales. To figure out lowest and highest values.
                    {
                        //Sorting for the highest value.
                        if (inputedSales[i] > highest) { 
                            highest = inputedSales[i];
                        }

                        //Sorting for the lowest value.
                        if (inputedSales[i] < lowest)
                        {
                            lowest = inputedSales[i];
                        }
                    }

                    //Updating all of our display labels.
                    totalLabel.Text = total.ToString("c");
                    averageLabel.Text = (total/lineIdex).ToString("c");
                    largestLabel.Text = highest.ToString("c");
                    smallestLabel.Text = lowest.ToString("c");
              
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message); // Displaying how the user is being incompetent.
            }

        }

        //Exit button method. Need anything else be mentioned?
        private void exitButton_Method(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
