namespace TicTacToe
{
    partial class About
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
            label1 = new Label();
            CloseButton = new Button();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(301, 36);
            label1.TabIndex = 20;
            label1.Text = "Developed by Nasser Abdullah";
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
            CloseButton.Location = new Point(331, 12);
            CloseButton.Margin = new Padding(4, 3, 4, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(54, 26);
            CloseButton.TabIndex = 21;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += Close;
            // 
            // label3
            // 
            label3.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 186);
            label3.Name = "label3";
            label3.Size = new Size(247, 26);
            label3.TabIndex = 23;
            label3.Text = "All rights are reserved ©.";
            label3.MouseDown += Form1_MouseDown;
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(288, 36);
            label2.TabIndex = 22;
            label2.Text = "Last updated on 06/01/2023";
            label2.MouseDown += Form1_MouseDown;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(398, 221);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CloseButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "About";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button CloseButton;
        private Label label3;
        private Label label2;
    }
}