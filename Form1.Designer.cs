namespace PingPongGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void ballPictureBox_Click(object sender, EventArgs e)
        {
            // Your event handling code here
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ballPictureBox = new PictureBox();
            player1PictureBox = new PictureBox();
            player2PictureBox = new PictureBox();
            player1ScoreLabel = new Label();
            player2ScoreLabel = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ballPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2PictureBox).BeginInit();
            SuspendLayout();
            // 
            // ballPictureBox
            // 
            ballPictureBox.BackColor = SystemColors.ActiveCaptionText;
            ballPictureBox.Location = new Point(455, 191);
            ballPictureBox.Name = "ballPictureBox";
            ballPictureBox.Size = new Size(14, 15);
            ballPictureBox.TabIndex = 0;
            ballPictureBox.TabStop = false;
            ballPictureBox.Click += ballPictureBox_Click;
            // 
            // player1PictureBox
            // 
            player1PictureBox.BackColor = SystemColors.ActiveCaption;
            player1PictureBox.Location = new Point(64, 142);
            player1PictureBox.Name = "player1PictureBox";
            player1PictureBox.Size = new Size(27, 154);
            player1PictureBox.TabIndex = 1;
            player1PictureBox.TabStop = false;
            // 
            // player2PictureBox
            // 
            player2PictureBox.BackColor = SystemColors.Highlight;
            player2PictureBox.Location = new Point(729, 142);
            player2PictureBox.Name = "player2PictureBox";
            player2PictureBox.Size = new Size(27, 154);
            player2PictureBox.TabIndex = 2;
            player2PictureBox.TabStop = false;
            // 
            // player1ScoreLabel
            // 
            player1ScoreLabel.AutoSize = true;
            player1ScoreLabel.Location = new Point(207, 48);
            player1ScoreLabel.Name = "player1ScoreLabel";
            player1ScoreLabel.Size = new Size(38, 15);
            player1ScoreLabel.TabIndex = 3;
            player1ScoreLabel.Text = "label1";
            // 
            // player2ScoreLabel
            // 
            player2ScoreLabel.AutoSize = true;
            player2ScoreLabel.Location = new Point(561, 48);
            player2ScoreLabel.Name = "player2ScoreLabel";
            player2ScoreLabel.Size = new Size(38, 15);
            player2ScoreLabel.TabIndex = 4;
            player2ScoreLabel.Text = "label2";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 50;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(player2ScoreLabel);
            Controls.Add(player1ScoreLabel);
            Controls.Add(player2PictureBox);
            Controls.Add(player1PictureBox);
            Controls.Add(ballPictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ballPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ballPictureBox;
        private PictureBox player1PictureBox;
        private PictureBox player2PictureBox;
        private Label player1ScoreLabel;
        private Label player2ScoreLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}
