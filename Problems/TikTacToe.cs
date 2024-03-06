
using System;

namespace CS161_Practice7.Problems
{
    public partial class TikTacToe : Form
    {
        public TikTacToe()
        {
            InitializeComponent();
        }

        bool?[,] gameSpace = { {null, null, null },
                               {null, null, null },
                               {null, null, null } };

        private void generateGame()
        {
            Random random = new Random();

            bool player1Played = false;

            for (int i = 0; i < 9; i++)
            {
                int coloum = 0;
                int row = 0;

                bool spotFound = false;

                while (!spotFound)
                {
                    coloum = random.Next(0, 3);
                    row = random.Next(0, 3);

                    if (gameSpace[coloum, row] == null)
                    {
                        spotFound = true;
                    }
                    else
                        continue;
                    {
                    }
                }


                if (!player1Played)
                {
                    gameSpace[coloum, row] = true;
                    player1Played = true;
                }
                else
                {
                    gameSpace[coloum, row] = false;
                    player1Played = false;
                }
            }
        }

        private void displayGame()
        {
            for (int COLOUM = 0; COLOUM < gameSpace.GetLength(0); COLOUM++)
            {
                for (int ROW = 0; ROW < gameSpace.GetLength(1); ROW++)
                {
                    PictureBox spacePictureBox = (PictureBox)this.Controls.Find($"c{COLOUM+1}r{ROW+1}PictureBox", true)[0];

                    bool? spaceValue = gameSpace[COLOUM, ROW];

                    if (spaceValue == true)
                    {
                        spacePictureBox.Image = Resource1.TaylorSwift;
                    }

                    if (spaceValue == false)
                    {
                        spacePictureBox.Image = Resource1.TravisKelece;
                    }

                }
            }
        }

        private void resetGame ()
        {
            for (int COLOUM = 0; COLOUM < gameSpace.GetLength(0); COLOUM++)
            {
                for (int ROW = 0; ROW < gameSpace.GetLength(1); ROW++)
                {
         
                    gameSpace[COLOUM, ROW] = null;

                }
            }
        }

        private void checkForWinners()
        {
            bool?[,] winingOption1 = new bool?[,] { {true, true, true },
                                       {null, null, null },
                                       {null, null, null } };

            bool?[,] winingOption2 = new bool?[,]{ {null, null, null },
                                       {true, true, true },
                                       {null, null, null } };

            bool?[,] winingOption3 = new bool?[,]{ {null, null, null },
                                       {null, null, null },
                                       {true, true, true } };

            bool?[,] winingOption4 = new bool?[,]{ {true, null, null },
                                       {true, null, null },
                                       {true, null, null } };

            bool?[,] winingOption5 = new bool?[,]{ {null, true, null },
                                       {null, true, null },
                                       {null, true, null } };

            bool?[,] winingOption6 = new bool?[,]{ {null, null, true },
                                       {null, null, true },
                                       {null, null, true } };

            bool?[,] winingOption7 = new bool?[,]{ {true, null, null },
                                       {null, true, null },
                                       {null, null, true } };

            bool?[,] winingOption8 = new bool?[,]{ {null, null, true },
                                       {null, true, null },
                                       {true, null, null } };

            bool?[,] player1Plays = new bool?[,]{ {null, null, null },
                                       {null, null, null },
                                       {null, null, null } };

            bool?[,] player2Plays = new bool?[,]{ {null, null, null },
                                       {null, null, null },
                                       {null, null, null } };

            for (int COLOUM = 0; COLOUM < gameSpace.GetLength(0); COLOUM++)
            {
                for (int ROW = 0; ROW < gameSpace.GetLength(1); ROW++)
                {
                    if(gameSpace[COLOUM, ROW] == true)
                    {
                        player1Plays[COLOUM, ROW] = true;
                    }

                    if(gameSpace[COLOUM, ROW] == false)
                    {
                        player2Plays[COLOUM, ROW] = true;
                    }
                   

                }
            }

            if (player1Plays.Equals(winingOption1)){ MessageBox.Show("Taylor Won!");  return; }
            if (player1Plays.Equals(winingOption2)) { MessageBox.Show("Taylor Won!"); return; }
            if (player1Plays.Equals(winingOption3)) { MessageBox.Show("Taylor Won!"); return; }
            if (player1Plays.Equals(winingOption4)) { MessageBox.Show("Taylor Won!"); return; }
            if (player1Plays.Equals(winingOption5)) { MessageBox.Show("Taylor Won!"); return; }
            if (player1Plays.Equals(winingOption6)) { MessageBox.Show("Taylor Won!"); return; }
            if (player1Plays.Equals(winingOption7)) { MessageBox.Show("Taylor Won!"); return; }
            if (player1Plays.Equals(winingOption8)) { MessageBox.Show("Taylor Won!"); return; }

            if (player2Plays.Equals(winingOption1)) { MessageBox.Show("Travis Won!"); return; }
            if (player2Plays.Equals(winingOption2)) { MessageBox.Show("Travis Won!"); return; }
            if (player2Plays.Equals(winingOption3)) { MessageBox.Show("Travis Won!"); return; }
            if (player2Plays.Equals(winingOption4)) { MessageBox.Show("Travis Won!"); return; }
            if (player2Plays.Equals(winingOption5)) { MessageBox.Show("Travis Won!"); return; }
            if (player2Plays.Equals(winingOption6)) { MessageBox.Show("Travis Won!"); return; }
            if (player2Plays.Equals(winingOption7)) { MessageBox.Show("Travis Won!"); return; }
            if (player2Plays.Equals(winingOption8)) { MessageBox.Show("Travis Won!"); return; }



        }

        private void newGameButton_Click(object sender, EventArgs e)
        {

            resetGame();
            generateGame();
            displayGame();
            checkForWinners();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
