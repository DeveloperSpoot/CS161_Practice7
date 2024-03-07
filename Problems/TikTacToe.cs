
using System;
using System.Text.Json;

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
            bool taylorWon = false;
            bool travisWon = false;

            if ((gameSpace[0, 0] == true) && (gameSpace[0, 1] == true) && ( gameSpace[0, 2] == true)){ taylorWon = true; }
            if ((gameSpace[1, 0] == true) && (gameSpace[1, 1] == true) && (gameSpace[1, 2] == true)) {taylorWon = true; }
            if ((gameSpace[2, 0] == true) && (gameSpace[2, 1] == true) && (gameSpace[2, 2] == true)) {taylorWon = true;  }

            if ((gameSpace[0, 0] == false) && (gameSpace[0, 1] == false) && (gameSpace[0, 2] == false)) { travisWon = true;  }
            if ((gameSpace[1, 0] == false) && (gameSpace[1, 1] == false) && (gameSpace[1, 2] == false)) { travisWon = true;  }
            if ((gameSpace[2, 0] == false) && (gameSpace[2, 1] == false) && (gameSpace[2, 2] == false)) { travisWon = true;  }


            if ((gameSpace[0, 0] == true) && (gameSpace[1, 0] == true) && (gameSpace[2, 0] == true)) {taylorWon = true;  }
            if ((gameSpace[0, 1] == true) && (gameSpace[1, 1] == true) && (gameSpace[2, 1] == true)) {taylorWon = true;  }
            if ((gameSpace[0, 2] == true) && (gameSpace[1, 2] == true) && (gameSpace[2, 2] == true)) {taylorWon = true;  }

            if ((gameSpace[0, 0] == false) && (gameSpace[1, 0] == false) && (gameSpace[2, 0] == false)) { travisWon = true;  }
            if ((gameSpace[0, 1] == false) && (gameSpace[1, 1] == false) && (gameSpace[2, 1] == false)) { travisWon = true;  }
            if ((gameSpace[0, 2] == false) && (gameSpace[1, 2] == false) && (gameSpace[2, 2] == false)) { travisWon = true;  }


            if ((gameSpace[0, 0] == true) && (gameSpace[1, 1] == true) && (gameSpace[2, 2] == true)) {taylorWon = true;  }
            if ((gameSpace[2, 0] == true) && (gameSpace[1, 1] == true) && (gameSpace[0, 2] == true)) {taylorWon = true;  }

            if ((gameSpace[0, 0] == false) && (gameSpace[1, 1] == false) && (gameSpace[2, 2] == false)) { travisWon = true;  }
            if ((gameSpace[2, 0] == false) && (gameSpace[1, 1] == false) && (gameSpace[0, 2] == false)) { travisWon = true;  }

            if(travisWon && taylorWon) { MessageBox.Show("This Game Was A TIE!"); return; }
            if (taylorWon) { MessageBox.Show("Taylor WON!"); }
            if (travisWon) { MessageBox.Show("Travis WON!"); }
            if(!travisWon && !taylorWon) { MessageBox.Show("No one won."); }

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
