namespace CS161_Practice7.Problems
{
    public partial class US_Population : Form
    {
        public US_Population()
        {
            InitializeComponent();
        }
        private void US_Population_Load(object sender, EventArgs e)
        {
            List<int> usPOP = new List<int>();

            try
            {
                StreamReader popFile = File.OpenText("USPopulation.txt");

                
                while(!popFile.EndOfStream)
                {
                    usPOP.Add(int.Parse(popFile.ReadLine()));
                }
                popFile.Close();

                int greatestYear = 1950;
                int greatesAmount = 0;

                int leastYear = 1950;
                int leastsAmount = 100000000;

                double average = 0.00 ;
                int totalChange = 0;

                /*
                 * IDK WHAt TO DO, TAKE A BREAK NATHANIEL......
                 * 
                 * COME BACK LATer.........
                 * 
                 * DON'T FORGEt ABOUT THIS.......
                 * 
                 * CLEAR YOUr MIND.........
                 * 
                 */

                List<int> increaseChanges = new List<int>();

                for(int i = 1; i <= usPOP.Count-1; i++)
                {
                    int changeIncreaseAmount = 0;
                   
                   changeIncreaseAmount = Math.Abs(usPOP[i] - usPOP[i -1 ]);
                    System.Diagnostics.Debug.WriteLine(changeIncreaseAmount);
                   increaseChanges.Add(changeIncreaseAmount);
                    

                    totalChange += changeIncreaseAmount;

                    if(changeIncreaseAmount > greatesAmount)
                    {
                        greatestYear = 1950 + i;
                        greatesAmount = changeIncreaseAmount;
                    }

                    if(changeIncreaseAmount < leastsAmount)
                    {
                        leastYear = 1950 + i;
                        leastsAmount = changeIncreaseAmount;
                    }
                }

                System.Diagnostics.Debug.WriteLine("<<< TOTAL >>>");
                System.Diagnostics.Debug.WriteLine(totalChange);

                System.Diagnostics.Debug.WriteLine("<<< CHANGE COUNT >>>");
                System.Diagnostics.Debug.WriteLine(increaseChanges.Count);

                average = (((double)totalChange) / (double)increaseChanges.Count)*1000.00;

                lowestChangeLabel.Text = leastYear.ToString();
                highestChangeLabel.Text = greatestYear.ToString();

                averageLabel.Text = average.ToString("n2");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }
        }

        //Exit method handle.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
