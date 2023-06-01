namespace TicTacToe
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcoming = new Label();
            StartGameButton = new Button();
            FirstPlayerNameLabel = new Label();
            SecondPlayerNameLabel = new Label();
            FirstPlayerNameTextBox = new TextBox();
            SecondPlayerNameTextBox = new TextBox();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // welcoming
            // 
            welcoming.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            welcoming.AutoSize = true;
            welcoming.Font = new Font("Yu Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point);
            welcoming.ForeColor = Color.White;
            welcoming.Location = new Point(42, 45);
            welcoming.Name = "welcoming";
            welcoming.Size = new Size(229, 51);
            welcoming.TabIndex = 0;
            welcoming.Text = "Tic Tac Toe";
            welcoming.TextAlign = ContentAlignment.MiddleCenter;
            welcoming.MouseDown += MyForm_MouseDown;
            // 
            // StartGameButton
            // 
            StartGameButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StartGameButton.BackColor = Color.FromArgb(33, 33, 33);
            StartGameButton.FlatAppearance.BorderSize = 0;
            StartGameButton.FlatStyle = FlatStyle.Flat;
            StartGameButton.Font = new Font("Yu Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            StartGameButton.ForeColor = Color.White;
            StartGameButton.Location = new Point(316, 340);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(174, 54);
            StartGameButton.TabIndex = 3;
            StartGameButton.Text = "Start Game";
            StartGameButton.UseVisualStyleBackColor = false;
            StartGameButton.Click += StartGame;
            // 
            // FirstPlayerNameLabel
            // 
            FirstPlayerNameLabel.AutoSize = true;
            FirstPlayerNameLabel.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FirstPlayerNameLabel.ForeColor = Color.White;
            FirstPlayerNameLabel.Location = new Point(52, 174);
            FirstPlayerNameLabel.Name = "FirstPlayerNameLabel";
            FirstPlayerNameLabel.Size = new Size(212, 31);
            FirstPlayerNameLabel.TabIndex = 2;
            FirstPlayerNameLabel.Text = "First Player Name";
            FirstPlayerNameLabel.MouseDown += MyForm_MouseDown;
            // 
            // SecondPlayerNameLabel
            // 
            SecondPlayerNameLabel.AutoSize = true;
            SecondPlayerNameLabel.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SecondPlayerNameLabel.ForeColor = Color.White;
            SecondPlayerNameLabel.Location = new Point(52, 228);
            SecondPlayerNameLabel.Name = "SecondPlayerNameLabel";
            SecondPlayerNameLabel.Size = new Size(243, 31);
            SecondPlayerNameLabel.TabIndex = 3;
            SecondPlayerNameLabel.Text = "Second Player Name";
            SecondPlayerNameLabel.MouseDown += MyForm_MouseDown;
            // 
            // FirstPlayerNameTextBox
            // 
            FirstPlayerNameTextBox.BackColor = Color.FromArgb(33, 33, 33);
            FirstPlayerNameTextBox.BorderStyle = BorderStyle.None;
            FirstPlayerNameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FirstPlayerNameTextBox.ForeColor = Color.White;
            FirstPlayerNameTextBox.Location = new Point(309, 171);
            FirstPlayerNameTextBox.MaxLength = 9;
            FirstPlayerNameTextBox.Name = "FirstPlayerNameTextBox";
            FirstPlayerNameTextBox.Size = new Size(220, 28);
            FirstPlayerNameTextBox.TabIndex = 1;
            // 
            // SecondPlayerNameTextBox
            // 
            SecondPlayerNameTextBox.BackColor = Color.FromArgb(33, 33, 33);
            SecondPlayerNameTextBox.BorderStyle = BorderStyle.None;
            SecondPlayerNameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SecondPlayerNameTextBox.ForeColor = Color.White;
            SecondPlayerNameTextBox.Location = new Point(309, 225);
            SecondPlayerNameTextBox.MaxLength = 9;
            SecondPlayerNameTextBox.Name = "SecondPlayerNameTextBox";
            SecondPlayerNameTextBox.Size = new Size(220, 28);
            SecondPlayerNameTextBox.TabIndex = 2;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CloseButton.BackColor = Color.FromArgb(33, 33, 33);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.WhiteSmoke;
            CloseButton.Location = new Point(741, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(31, 37);
            CloseButton.TabIndex = 6;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += Close;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(784, 461);
            Controls.Add(CloseButton);
            Controls.Add(SecondPlayerNameTextBox);
            Controls.Add(FirstPlayerNameTextBox);
            Controls.Add(SecondPlayerNameLabel);
            Controls.Add(FirstPlayerNameLabel);
            Controls.Add(StartGameButton);
            Controls.Add(welcoming);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Tic Tac Toe";
            MouseDown += MyForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcoming;
        private Button StartGameButton;
        private Label FirstPlayerNameLabel;
        private Label SecondPlayerNameLabel;
        private TextBox FirstPlayerNameTextBox;
        private TextBox SecondPlayerNameTextBox;
        private Button CloseButton;
    }
}