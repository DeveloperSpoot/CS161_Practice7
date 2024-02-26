using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS161_Practice7.Problems
{
    public partial class Drivers_License_Exam : Form
    {
        public Drivers_License_Exam()
        {
            InitializeComponent();
        }

        private string[] correctAnswers = new string[20];

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            incorrectListBox.Items.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader studentsAnswersFile = File.OpenText(openFileDialog1.FileName);

                    int index = -1;

                    while (!studentsAnswersFile.EndOfStream)
                    {
                        index++;

                        string currentQuestion = studentsAnswersFile.ReadLine();

                        if (correctAnswers[index] != currentQuestion)
                        {
                            incorrectListBox.Items.Add(index.ToString());
                        }
                    }

                    studentsAnswersFile.Close();

                    if (incorrectListBox.Items.Count > 5)
                    {
                        outcomeLabel.Text = "FAILED";
                        outcomeLabel.BackColor = Color.Tomato;

                        totalLabel.Text = $"{20 - incorrectListBox.Items.Count} / 20";
                    }
                    else
                    {
                        outcomeLabel.Text = "PASSED";
                        outcomeLabel.BackColor = Color.LimeGreen;

                        totalLabel.Text = $"{20 - incorrectListBox.Items.Count} / 20";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Drivers_License_Exam_Load(object sender, EventArgs e)
        {
            int index = -1;
            try
            {
                StreamReader correctAnswersFile = File.OpenText("correctAnswers.txt");

                while (!correctAnswersFile.EndOfStream)
                {
                    index++;
                    correctAnswers[index] = correctAnswersFile.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
