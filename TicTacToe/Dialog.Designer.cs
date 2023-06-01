namespace TicTacToe
{
    partial class Dialog
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
            Okay = new Button();
            label1 = new Label();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // Okay
            // 
            Okay.BackColor = Color.FromArgb(33, 33, 33);
            Okay.FlatAppearance.BorderSize = 0;
            Okay.FlatStyle = FlatStyle.Flat;
            Okay.ForeColor = Color.White;
            Okay.Location = new Point(382, 95);
            Okay.Name = "Okay";
            Okay.Size = new Size(75, 23);
            Okay.TabIndex = 0;
            Okay.Text = "Okay";
            Okay.UseVisualStyleBackColor = false;
            Okay.Click += Close;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(384, 64);
            label1.TabIndex = 1;
            label1.Text = "Please enter the first player name along with the second one!";
            label1.MouseDown += Form1_MouseDown;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CloseButton.BackColor = Color.FromArgb(33, 33, 33);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.WhiteSmoke;
            CloseButton.Location = new Point(403, 12);
            CloseButton.Margin = new Padding(4, 3, 4, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(54, 26);
            CloseButton.TabIndex = 18;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += Close;
            // 
            // Dialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(463, 130);
            Controls.Add(CloseButton);
            Controls.Add(label1);
            Controls.Add(Okay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dialog";
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button Okay;
        private Label label1;
        private Button CloseButton;
    }
}