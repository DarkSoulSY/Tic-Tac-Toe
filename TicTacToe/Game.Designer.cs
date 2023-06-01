namespace TicTacToe
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            turn = new Label();
            button1 = new CustomButton();
            button2 = new CustomButton();
            button3 = new CustomButton();
            button4 = new CustomButton();
            button5 = new CustomButton();
            button6 = new CustomButton();
            button7 = new CustomButton();
            button8 = new CustomButton();
            button9 = new CustomButton();
            FirstPlayerName = new Label();
            SecondPlayerName = new Label();
            continueGame = new Button();
            closeGame = new Button();
            resetGame = new Button();
            CloseButton = new Button();
            FirstUserScore = new Label();
            SecondUserScore = new Label();
            button10 = new Button();
            SuspendLayout();
            // 
            // turn
            // 
            turn.AutoSize = true;
            turn.Font = new Font("Yu Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            turn.ForeColor = Color.White;
            turn.Location = new Point(71, 79);
            turn.Margin = new Padding(4, 0, 4, 0);
            turn.Name = "turn";
            turn.Size = new Size(0, 35);
            turn.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(33, 33, 33);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(71, 132);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(125, 125);
            button1.TabIndex = 1;
            button1.TextAlign = ContentAlignment.TopRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += ChangeButtonState;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(33, 33, 33);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(71, 262);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(125, 125);
            button2.TabIndex = 4;
            button2.TextAlign = ContentAlignment.TopRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += ChangeButtonState;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(33, 33, 33);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Yu Gothic", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(71, 394);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(125, 125);
            button3.TabIndex = 7;
            button3.TextAlign = ContentAlignment.TopRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += ChangeButtonState;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(33, 33, 33);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Yu Gothic", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(202, 132);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(125, 125);
            button4.TabIndex = 2;
            button4.TextAlign = ContentAlignment.TopRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += ChangeButtonState;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.FromArgb(33, 33, 33);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Yu Gothic", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(202, 262);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(125, 125);
            button5.TabIndex = 5;
            button5.TextAlign = ContentAlignment.TopRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += ChangeButtonState;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.BackColor = Color.FromArgb(33, 33, 33);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Yu Gothic", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(202, 394);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(125, 125);
            button6.TabIndex = 8;
            button6.TextAlign = ContentAlignment.TopRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += ChangeButtonState;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackColor = Color.FromArgb(33, 33, 33);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Yu Gothic", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(332, 132);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(125, 125);
            button7.TabIndex = 3;
            button7.TextAlign = ContentAlignment.TopRight;
            button7.UseVisualStyleBackColor = false;
            button7.Click += ChangeButtonState;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.BackColor = Color.FromArgb(33, 33, 33);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Yu Gothic", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(332, 262);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(125, 125);
            button8.TabIndex = 6;
            button8.TextAlign = ContentAlignment.TopRight;
            button8.UseVisualStyleBackColor = false;
            button8.Click += ChangeButtonState;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.BackColor = Color.FromArgb(33, 33, 33);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Yu Gothic", 70F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(332, 394);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(125, 125);
            button9.TabIndex = 9;
            button9.TextAlign = ContentAlignment.TopRight;
            button9.UseVisualStyleBackColor = false;
            button9.Click += ChangeButtonState;
            // 
            // FirstPlayerName
            // 
            FirstPlayerName.AutoSize = true;
            FirstPlayerName.Font = new Font("Yu Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            FirstPlayerName.ForeColor = Color.White;
            FirstPlayerName.Location = new Point(489, 132);
            FirstPlayerName.Margin = new Padding(4, 0, 4, 0);
            FirstPlayerName.Name = "FirstPlayerName";
            FirstPlayerName.Size = new Size(0, 35);
            FirstPlayerName.TabIndex = 10;
            // 
            // SecondPlayerName
            // 
            SecondPlayerName.AutoSize = true;
            SecondPlayerName.Font = new Font("Yu Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SecondPlayerName.ForeColor = Color.White;
            SecondPlayerName.Location = new Point(489, 202);
            SecondPlayerName.Margin = new Padding(4, 0, 4, 0);
            SecondPlayerName.Name = "SecondPlayerName";
            SecondPlayerName.Size = new Size(0, 35);
            SecondPlayerName.TabIndex = 11;
            // 
            // continueGame
            // 
            continueGame.BackColor = Color.FromArgb(33, 33, 33);
            continueGame.FlatAppearance.BorderSize = 0;
            continueGame.FlatStyle = FlatStyle.Flat;
            continueGame.Font = new Font("Yu Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            continueGame.ForeColor = Color.White;
            continueGame.Location = new Point(498, 412);
            continueGame.Margin = new Padding(4, 3, 4, 3);
            continueGame.Name = "continueGame";
            continueGame.Size = new Size(132, 61);
            continueGame.TabIndex = 10;
            continueGame.Text = "Continue";
            continueGame.UseVisualStyleBackColor = false;
            continueGame.Click += ContinueGame;
            // 
            // closeGame
            // 
            closeGame.BackColor = Color.FromArgb(33, 33, 33);
            closeGame.FlatAppearance.BorderSize = 0;
            closeGame.FlatStyle = FlatStyle.Flat;
            closeGame.Font = new Font("Yu Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            closeGame.ForeColor = Color.White;
            closeGame.Location = new Point(570, 479);
            closeGame.Margin = new Padding(4, 3, 4, 3);
            closeGame.Name = "closeGame";
            closeGame.Size = new Size(132, 61);
            closeGame.TabIndex = 12;
            closeGame.Text = "Return to Main Menu";
            closeGame.UseVisualStyleBackColor = false;
            closeGame.Click += Close;
            // 
            // resetGame
            // 
            resetGame.BackColor = Color.FromArgb(33, 33, 33);
            resetGame.FlatAppearance.BorderSize = 0;
            resetGame.FlatStyle = FlatStyle.Flat;
            resetGame.Font = new Font("Yu Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            resetGame.ForeColor = Color.White;
            resetGame.Location = new Point(638, 412);
            resetGame.Margin = new Padding(4, 3, 4, 3);
            resetGame.Name = "resetGame";
            resetGame.Size = new Size(132, 61);
            resetGame.TabIndex = 11;
            resetGame.TabStop = false;
            resetGame.Text = "Reset";
            resetGame.UseVisualStyleBackColor = false;
            resetGame.Click += ResetGame;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CloseButton.BackColor = Color.FromArgb(33, 33, 33);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.WhiteSmoke;
            CloseButton.Location = new Point(757, 12);
            CloseButton.Margin = new Padding(4, 3, 4, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(61, 38);
            CloseButton.TabIndex = 17;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += Close;
            // 
            // FirstUserScore
            // 
            FirstUserScore.AutoSize = true;
            FirstUserScore.Font = new Font("Yu Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            FirstUserScore.ForeColor = Color.White;
            FirstUserScore.Location = new Point(709, 132);
            FirstUserScore.Margin = new Padding(4, 0, 4, 0);
            FirstUserScore.Name = "FirstUserScore";
            FirstUserScore.Size = new Size(30, 35);
            FirstUserScore.TabIndex = 18;
            FirstUserScore.Text = "0";
            // 
            // SecondUserScore
            // 
            SecondUserScore.AutoSize = true;
            SecondUserScore.Font = new Font("Yu Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SecondUserScore.ForeColor = Color.White;
            SecondUserScore.Location = new Point(709, 202);
            SecondUserScore.Margin = new Padding(4, 0, 4, 0);
            SecondUserScore.Name = "SecondUserScore";
            SecondUserScore.Size = new Size(30, 35);
            SecondUserScore.TabIndex = 19;
            SecondUserScore.Text = "0";
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button10.BackColor = Color.FromArgb(33, 33, 33);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.WhiteSmoke;
            button10.Location = new Point(674, 12);
            button10.Margin = new Padding(4, 3, 4, 3);
            button10.Name = "button10";
            button10.Size = new Size(75, 38);
            button10.TabIndex = 20;
            button10.Text = "About";
            button10.UseVisualStyleBackColor = false;
            button10.Click += About;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(830, 601);
            Controls.Add(button10);
            Controls.Add(SecondUserScore);
            Controls.Add(FirstUserScore);
            Controls.Add(CloseButton);
            Controls.Add(resetGame);
            Controls.Add(closeGame);
            Controls.Add(continueGame);
            Controls.Add(SecondPlayerName);
            Controls.Add(FirstPlayerName);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(turn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Game";
            Text = "Tic Tac Toe";
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label turn;
        private Label FirstPlayerName;
        private Label SecondPlayerName;
        private Button continueGame;
        private Button closeGame;
        private Button resetGame;
        private Button CloseButton;
        public CustomButton button1;
        public CustomButton button2;
        public CustomButton button3;
        public CustomButton button4;
        public CustomButton button5;
        public CustomButton button6;
        public CustomButton button7;
        public CustomButton button8;
        public CustomButton button9;
        private Label FirstUserScore;
        private Label SecondUserScore;
        private Button button10;
    }
}