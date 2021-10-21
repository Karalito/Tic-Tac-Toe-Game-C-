using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Game : Form
    {
        private static int totalSteps;
        private static int madeSteps;
        private string currentPlayer;
        private static int halfSteps;
        private bool gameIsOver = false;
        private Button[,] button;

        public Game(int SIZE, string FIRST)
        {
            madeSteps = 0;
            halfSteps = SIZE;
            totalSteps = SIZE * SIZE;

            currentPlayer = FIRST;

            InitializeComponent();

            currentMoveLbl.Text = "Žaidėjo " + FIRST + " ėjimas";
            movesLbl.Text = Convert.ToString(madeSteps + "/" + totalSteps);

            button = new Button[SIZE, SIZE];

            int buttonTag = 0;

            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Parent = gameBoard;
                    button[i, j].Width = gameBoard.Width / SIZE;
                    button[i, j].Height = gameBoard.Height / SIZE;

                    button[i, j].Top = j * gameBoard.Height / SIZE;
                    button[i, j].Left = i * gameBoard.Width / SIZE;
                    button[i, j].Click += new EventHandler(SelectedSquare);
                    button[i, j].Tag = buttonTag;

                    button[i, j].Font = new Font(button[i, j].Font.FontFamily, 16, FontStyle.Bold);
                    buttonTag++;
                }
        }

        public void SelectedSquare(object sender, EventArgs e)
        {
            int prevStep = madeSteps;
            Button btn = (Button)sender;
            if (btn.Text == "")
            {
                btn.Text = currentPlayer;
                madeSteps++;
            }

            if (madeSteps > prevStep)
            {
                Condition3x3(currentPlayer);
                if (currentPlayer == "O")
                {
                    currentPlayer = "X";
                    currentMoveLbl.Text = "Žaidėjo X ėjimas";
                    movesLbl.Text = Convert.ToString(madeSteps + "/" + totalSteps);
                }
                else
                {
                    currentPlayer = "O";
                    currentMoveLbl.Text = "Žaidėjo O ėjimas";
                    movesLbl.Text = Convert.ToString(madeSteps + "/" + totalSteps);
                }
            }
        }

        public void playAgain(int condition, string XorO)
        {
            gameIsOver = true;
            DialogResult dialogResult = DialogResult.None;
            if (condition == 0)
                dialogResult = MessageBox.Show("Player " + XorO + " won this game!", "Do you want to play again?", MessageBoxButtons.YesNo);
            else if (condition == 1)
                dialogResult = MessageBox.Show("Dėja... Niekas nelaimėjo", "Ar norite žaisti dar kartą?", MessageBoxButtons.YesNo);

            if (Convert.ToString(dialogResult) == "Yes")
            {
                Start start = new Start();
                this.Hide();
                start.Closed += (s, args) => this.Close();
                start.Show();
            }
            else
                this.Close();
        }

        public void Condition3x3(string XorO)
        {
            for (int i = 0; i < halfSteps; i++)
            {
                CheckRow(i, XorO);
                CheckColumn(i, XorO);
            }
            CheckRightDiagonal(XorO);
            CheckLeftDiagonal(XorO);

            if (!gameIsOver && CheckForTie())
                playAgain(1, XorO);
        }

        public void CheckColumn(int j, string XorO)
        {
            bool checking = true;
            int matching = 0;
            for (int i = 0; i < halfSteps; i++)
                if (button[i, j].Text == XorO && checking)
                {
                    matching++;
                    //if (matching > 2)
                    //checkFor3x3(i, j, XorO);
                    if (matching == halfSteps)
                        playAgain(0, XorO);
                }
                else
                    break;
        }

        public void CheckRow(int i, string XorO)
        {
            bool checking = true;
            int matching = 0;
            for (int j = 0; j < halfSteps; j++)
                if (button[i, j].Text == XorO && checking)
                {
                    matching++;
                    if (matching == halfSteps)
                        playAgain(0, XorO);
                }
                else
                    break;
        }

        public void CheckLeftDiagonal(string XorO)
        {
            int matching = 0;
            for (int i = 0; i < halfSteps; i++)
                for (int j = 0; j < halfSteps; j++)
                {
                    if (i == halfSteps - j - 1)
                    {
                        if (button[i, j].Text == XorO)
                            matching++;
                        else
                            break;

                        if (matching == halfSteps)
                            playAgain(0, XorO);
                    }
                }
        }

        public void CheckRightDiagonal(string XorO)
        {
            int matching = 0;
            for (int i = 0; i < halfSteps; i++)
                for (int j = 0; j < halfSteps; j++)
                {
                    if (i == j)
                    {
                        if (button[i, j].Text == XorO)
                            matching++;
                        else
                            break;

                        if (matching == halfSteps)
                            playAgain(0, XorO);
                    }
                }
        }

        public bool CheckForTie()
        {
            return madeSteps == totalSteps;
        }
    }
}