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
                int greatesAmount = usPOP[0];

                int leastYear = 1950;
                int leastsAmount = usPOP[0];

                int average = 0 ;
                int totalChange = 0;

                int LastChange = 0;

                int lastIndex = 0;
                
                /*
                 * IDK WHAt TO DO, TAKE A BREAK NATHANIEL......
                 * 
                 * 
                 * 
                 * COME BACK LATer.........
                 * 
                 * 
                 * 
                 * DON'T FORGEt ABOUT THIS.......
                 * 
                 * 
                 * CLEAR YOUr MIND.........
                 * 
                 */


            }
            catch (Exception ex)
            {
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
