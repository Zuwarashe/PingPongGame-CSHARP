using System;
using System.Drawing;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form1 : Form
    {
        private const int PaddleSpeed = 5;
        private const int BallSpeed = 5;
        private int player1Score = 0;
        private int player2Score = 0;
        private int ballXSpeed = BallSpeed;
        private int ballYSpeed = BallSpeed;
        private bool ballMovingRight = true;
        private bool ballMovingDown = true;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();

            // Wire up event handlers
            this.KeyDown += Form1_KeyDown;
            gameTimer.Tick += gameTimer_Tick;
        }

        private void InitializeGame()
        {
            // Initialize paddle positions
            player1PictureBox.Location = new Point(10, (ClientSize.Height - player1PictureBox.Height) / 2);
            player2PictureBox.Location = new Point(ClientSize.Width - player2PictureBox.Width - 10, (ClientSize.Height - player2PictureBox.Height) / 2);

            // Initialize ball position
            ballPictureBox.Location = new Point((ClientSize.Width - ballPictureBox.Width) / 2, (ClientSize.Height - ballPictureBox.Height) / 2);

            // Initialize score labels
            UpdateScoreLabels();
        }

        private void UpdateScoreLabels()
        {
            player1ScoreLabel.Text = $"Player 1: {player1Score}";
            player2ScoreLabel.Text = $"Player 2: {player2Score}";
        }

        private void MoveBall()
        {
            Point ballLocation = ballPictureBox.Location;

            if (ballMovingRight)
                ballLocation.X += ballXSpeed;
            else
                ballLocation.X -= ballXSpeed;

            if (ballMovingDown)
                ballLocation.Y += ballYSpeed;
            else
                ballLocation.Y -= ballYSpeed;

            ballPictureBox.Location = ballLocation;
        }

        private void CheckBallCollision()
        {
            // Check collision with top and bottom walls
            if (ballPictureBox.Top <= 0 || ballPictureBox.Bottom >= ClientSize.Height)
                ballMovingDown = !ballMovingDown;

            // Check collision with paddles
            if (ballPictureBox.Bounds.IntersectsWith(player1PictureBox.Bounds) || ballPictureBox.Bounds.IntersectsWith(player2PictureBox.Bounds))
                ballMovingRight = !ballMovingRight;

            // Check if ball is out of bounds
            if (ballPictureBox.Right <= 0)
            {
                player2Score++;
                InitializeGame();
            }
            else if (ballPictureBox.Left >= ClientSize.Width)
            {
                player1Score++;
                InitializeGame();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Player 1 controls
            if (e.KeyCode == Keys.W && player1PictureBox.Top > 0)
                player1PictureBox.Top -= PaddleSpeed;
            if (e.KeyCode == Keys.S && player1PictureBox.Bottom < ClientSize.Height)
                player1PictureBox.Top += PaddleSpeed;

            // Player 2 controls
            if (e.KeyCode == Keys.Up && player2PictureBox.Top > 0)
                player2PictureBox.Top -= PaddleSpeed;
            if (e.KeyCode == Keys.Down && player2PictureBox.Bottom < ClientSize.Height)
                player2PictureBox.Top += PaddleSpeed;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            MoveBall();
            CheckBallCollision();
            UpdateScoreLabels();
        }
    }
}
