using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicTacToe
{
    public partial class Game : Form
    {
        private static bool Turn;
        private static bool status = false;
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Game()
        {
            InitializeComponent();
            FillPlayersNames();
            initatingTurn();

        }

        //Fills form labels with player names.
        public void FillPlayersNames()
        {
            FirstPlayerName.Text = Form1.playerName1 + " (X)";
            SecondPlayerName.Text = Form1.playerName2 + " (O)";
        }

        //Randomizses turn between players.
        public void initatingTurn()
        {
            Random random = new Random();

            if (random.Next(0, 2) == 0)
            {
                turn.Text = "Player " + Form1.playerName1 + "'s Turn!"; Turn = false;
            }
            else
            {
                turn.Text = "Player " + Form1.playerName2 + "'s Turn!"; Turn = true;
            }
        }

        //Handles button press behavior.
        private void ChangeButtonState(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = Color.FromArgb(42, 42, 42);
            if (Turn)
            {
                b.Text = "O"; Turn = false;
                b.Enabled = false;

            }
            else
            {
                b.Text = "X"; Turn = true;
                b.Enabled = false;
            }

            UpdateStatus();

            if (status)
            {

                if (Turn)
                {
                    turn.Text = Form1.playerName1 + " Won";
                }
                else
                {
                    turn.Text = Form1.playerName2 + " Won";
                }

                DisableGameButtons();

                if (Turn)
                {
                    if (FirstUserScore.Text != "")
                    {
                        FirstUserScore.Text = (Convert.ToInt16(FirstUserScore.Text) + 1) + "";


                    }
                    else
                    {
                        FirstUserScore.Text = "1";
                    }
                }
                else
                {
                    if (SecondUserScore.Text != "")
                    {
                        SecondUserScore.Text = (Convert.ToInt16(SecondUserScore.Text) + 1) + "";
                    }
                    else
                    {
                        SecondUserScore.Text = "1";
                    }
                }
            }
            else
            {
                if (button1.Text != string.Empty && button2.Text != string.Empty && button3.Text != string.Empty && button4.Text != string.Empty && button5.Text != string.Empty && button6.Text != string.Empty && button7.Text != string.Empty && button8.Text != string.Empty && button9.Text != string.Empty)
                {
                    turn.Text = "Draw!";
                }
                else if (Turn)
                {
                    turn.Text = "Player " + Form1.playerName2 + "'s Turn!";
                }
                else
                {
                    turn.Text = "Player " + Form1.playerName1 + "'s Turn!";
                }
            }

        }
        //Checks whether a user has won.
        private void UpdateStatus()
        {


            if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text != "")
            {
                status = true;
            }
            else if (button4.Text == button5.Text && button4.Text == button6.Text && button4.Text != "")
            {
                status = true;
            }
            else if (button7.Text == button8.Text && button7.Text == button9.Text && button7.Text != "")
            {
                status = true;
            }
            else if (button1.Text == button4.Text && button1.Text == button7.Text && button1.Text != "")
            {
                status = true;
            }
            else if (button2.Text == button5.Text && button2.Text == button8.Text && button2.Text != "")
            {
                status = true;
            }
            else if (button3.Text == button6.Text && button3.Text == button9.Text && button3.Text != "")
            {
                status = true;
            }
            else if (button1.Text == button5.Text && button1.Text == button9.Text && button1.Text != "")
            {
                status = true;
            }
            else if (button3.Text == button5.Text && button3.Text == button7.Text && button3.Text != "")
            {
                status = true;
            }

            else status = false;


        }
        //Disables game buttons.
        public void DisableGameButtons()
        {

            if (status)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
            }


        }
        //Rests Text + Disables buttons + Resets Colors
        private void ResetGame(object sender, EventArgs e)
        {
            initatingTurn();
            status = false;
            DisableGameButtons();

            //Resting Text Property From Each Button
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            FirstUserScore.Text = "0";
            SecondUserScore.Text = "0";

            // Resting Colors
            button1.ForeColor = Color.FromArgb(33, 33, 33);
            button2.ForeColor = Color.FromArgb(33, 33, 33);
            button3.ForeColor = Color.FromArgb(33, 33, 33);
            button4.ForeColor = Color.FromArgb(33, 33, 33);
            button5.ForeColor = Color.FromArgb(33, 33, 33);
            button6.ForeColor = Color.FromArgb(33, 33, 33);
            button7.ForeColor = Color.FromArgb(33, 33, 33);
            button8.ForeColor = Color.FromArgb(33, 33, 33);
            button9.ForeColor = Color.FromArgb(33, 33, 33);

        }

        private void ContinueGame(object sender, EventArgs e)
        {
            initatingTurn();
            status = false;
            DisableGameButtons();
            //Resting Text Property From Each Button
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            // Resting Colors
            button1.BackColor = Color.FromArgb(33, 33, 33);
            button2.BackColor = Color.FromArgb(33, 33, 33);
            button3.BackColor = Color.FromArgb(33, 33, 33);
            button4.BackColor = Color.FromArgb(33, 33, 33);
            button5.BackColor = Color.FromArgb(33, 33, 33);
            button6.BackColor = Color.FromArgb(33, 33, 33);
            button7.BackColor = Color.FromArgb(33, 33, 33);
            button8.BackColor = Color.FromArgb(33, 33, 33);
            button9.BackColor = Color.FromArgb(33, 33, 33);


        }
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void About(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
