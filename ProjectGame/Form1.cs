using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectGame
{
    public partial class Form1 : Form
    {
        private readonly Player player1 = new Player();
        private readonly Player player2 = new Player();
        private readonly Random randomGenerator = new Random();
        private int totalRounds;
        private int currentRound;
        private int player1DiceValue;
        private int player2DiceValue;
        private bool gameStarted;
        private bool gameFinished;
        private bool player1IsSetup;
        private bool player2IsSetup;
        private string winnerName;
        private string resultsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GameResults.txt");

        public Form1()
        {
            InitializeComponent();
            btnRollDice.Enabled = false;
            numTotalRounds.Minimum = 5;
            numTotalRounds.Maximum = 30;
            btnResetAll.Click += (s, e) => ResetAll();
            btnShowResults.Click += (s, e) => ShowGameResults();
            btnRollDice.Click += (s, e) => PlayRound();
            UpdateGameInterface();
        }

        private void txtPlayer1Name_TextChanged(object sender, EventArgs e)
        {
            UpdateGameInterface();
        }

        private void txtPlayer2Name_TextChanged(object sender, EventArgs e)
        {
            UpdateGameInterface();
        }

        private int SelectedAvatar()
        {
            if (rbAvatar1.Checked) return 1;
            if (rbAvatar2.Checked) return 2;
            if (rbAvatar3.Checked) return 3;
            if (rbAvatar4.Checked) return 4;
            return 0;
        }

        private void SetupPlayer1()
        {
            if (String.IsNullOrWhiteSpace(txtPlayer1Name.Text))
            {
                MessageBox.Show("Enter Player 1's name.");
                return;
            }
            int avatar = SelectedAvatar();
            if (avatar == 0)
            {
                MessageBox.Show("Choose an avatar first.");
                return;
            }
            if (avatar == player2.avatars)
            {
                MessageBox.Show("Choose a different avatar from Player 2.");
                return;
            }
            player1.Name = txtPlayer1Name.Text.Trim();
            player1.avatars = avatar;
            player1IsSetup = true;
            btnSetupPlayer1.Enabled = false;
            picdefaultPlayer1.Image = AvatarImage(avatar);
            UpdateGameInterface();
        }

        private void SetupPlayer2()
        {
            if (String.IsNullOrWhiteSpace(txtPlayer2Name.Text))
            {
                MessageBox.Show("Enter Player 2's name.");
                return;
            }
            int avatar = SelectedAvatar();
            if (avatar == 0)
            {
                MessageBox.Show("Choose an avatar first.");
                return;
            }
            if (avatar == player1.avatars)
            {
                MessageBox.Show("Choose a different avatar from Player 1.");
                return;
            }
            player2.Name = txtPlayer2Name.Text.Trim();
            player2.avatars = avatar;
            player2IsSetup = true;
            btnSetupPlayer2.Enabled = false;
            picdefaultPlayer2.Image = AvatarImage(avatar);
            UpdateGameInterface();
        }

        private System.Drawing.Image AvatarImage(int avatar)
        {
            switch (avatar)
            {
                case 1: return Properties.Resources.avatar1;
                case 2: return Properties.Resources.avatar2;
                case 3: return Properties.Resources.avatar3;
                default: return Properties.Resources.avatar4;
            }
        }

        private void btnSetupPlayer1_Click(object sender, EventArgs e) { SetupPlayer1(); }
        private void btnSetupPlayer2_Click(object sender, EventArgs e) { SetupPlayer2(); }

        private void btnstart_Click(object sender, EventArgs e) { StartGame(); }

        private void StartGame()
        {
            if (!player1IsSetup || !player2IsSetup)
            {
                MessageBox.Show("Set up both players first.");
                return;
            }

            totalRounds = (int)numTotalRounds.Value;
            currentRound = 1;
            player1.points = 0;
            player2.points = 0;
            gameStarted = true;
            gameFinished = false;
            winnerName = null;
            picDice.Image = picDice2.Image = Properties.Resources.dice1;
            lblPlayerTurn.Text = "Both players roll each round";
            UpdateGameInterface();
        }

        private int RollDice() { return randomGenerator.Next(1, 7); }

        private void PlayRound()
        {
            if (!gameStarted) return;
            player1DiceValue = RollDice();
            player2DiceValue = RollDice();
            picDice.Image = DiceImage(player1DiceValue);
            picDice2.Image = DiceImage(player2DiceValue);
            lblPlayerTurn.Text = player1.Name + ": " + player1DiceValue + "   |   " + player2.Name + ": " + player2DiceValue;
            CalculateScores();
            currentRound++;
            if (currentRound > totalRounds)
            {
                FinishGame();
            }
            UpdateGameInterface();
        }

        private void CalculateScores()
        {
            if (player1DiceValue >= player2DiceValue) player1.points++;
            if (player2DiceValue >= player1DiceValue) player2.points++;
        }

        private System.Drawing.Image DiceImage(int value)
        {
            switch (value)
            {
                case 1: return Properties.Resources.dice1; case 2: return Properties.Resources.dice2;
                case 3: return Properties.Resources.dice3; case 4: return Properties.Resources.dice4;
                case 5: return Properties.Resources.dice5; default: return Properties.Resources.dice6;
            }
        }

        private void FinishGame()
        {
            gameFinished = true;
            gameStarted = false;
            if (player1.points == player2.points) winnerName = "Draw";
            else if (player1.points > player2.points) winnerName = player1.Name;
            else winnerName = player2.Name;
            lblPlayerTurn.Text = winnerName == "Draw" ? "It's a draw!" : winnerName + " wins!";
            string record = DateTime.Now.ToString("yyyy-MM-dd HH:mm") + " | " + player1.Name + " " + player1.points + " - " + player2.points + " " + player2.Name + " | Rounds: " + totalRounds + " | " + winnerName;
            try { File.AppendAllText(resultsFilePath, record + Environment.NewLine); }
            catch (IOException ex) { MessageBox.Show("Could not save game history: " + ex.Message); }
        }

        private void ShowGameResults()
        {
            lstGameResults.Items.Clear();
            if (!File.Exists(resultsFilePath)) { lstGameResults.Items.Add("No saved results yet."); return; }
            string[] lines = File.ReadAllLines(resultsFilePath);
            if (lines.Length == 0) lstGameResults.Items.Add("No saved results yet.");
            else lstGameResults.Items.AddRange(lines);
        }

        private void ResetAll()
        {
            player1.Name = player2.Name = String.Empty;
            player1.points = player2.points = 0;
            player1.avatars = player2.avatars = 0;
            player1IsSetup = player2IsSetup = false;
            gameStarted = gameFinished = false;
            winnerName = null;
            totalRounds = currentRound = 0;
            txtPlayer1Name.Clear(); txtPlayer2Name.Clear(); rbAvatar1.Checked = rbAvatar2.Checked = rbAvatar3.Checked = rbAvatar4.Checked = false;
            numTotalRounds.Value = 5; picdefaultPlayer1.Image = picdefaultPlayer2.Image = Properties.Resources.avatar_default;
            picDice.Image = picDice2.Image = Properties.Resources.dice1; lblPlayerTurn.Text = String.Empty; lstGameResults.Items.Clear();
            UpdateGameInterface();
        }

        private void UpdateGameInterface()
        {
            btnSetupPlayer1.Enabled = !gameStarted && !player1IsSetup && !String.IsNullOrWhiteSpace(txtPlayer1Name.Text);
            btnSetupPlayer2.Enabled = !gameStarted && !player2IsSetup && !String.IsNullOrWhiteSpace(txtPlayer2Name.Text);
            btnStartGame.Enabled = !gameStarted && !gameFinished && player1IsSetup && player2IsSetup && numTotalRounds.Value >= 5 && numTotalRounds.Value <= 30;
            btnRollDice.Enabled = gameStarted && !gameFinished;
            numTotalRounds.Enabled = !gameStarted && !gameFinished;
            rbAvatar1.Enabled = rbAvatar2.Enabled = rbAvatar3.Enabled = rbAvatar4.Enabled = !gameStarted && !gameFinished;
            btnSetupPlayer1.Enabled &= !gameFinished;
            btnSetupPlayer2.Enabled &= !gameFinished;
            lblPlayer1Points.Text = player1.points.ToString(); lblPlayer2Points.Text = player2.points.ToString();
            lblCurrentRound.Text = totalRounds > 0 ? Math.Min(currentRound, totalRounds) + " / " + totalRounds : "0";
        }
    }
}
