using System.Runtime.InteropServices;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public static string? playerName1;
        public static string? playerName2;
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = StartGameButton;
            this.MouseDown += MyForm_MouseDown!;
        }

        private void StartGame(object sender, EventArgs e)
        {
            if (CheckNameFieldEmptiness())
            {

                Game game1 = new Game();
                this.Hide();
                game1.ShowDialog();
                this.Show();

            }
            else
            {
                Dialog dialog = new Dialog();
                dialog.ShowDialog();

            }


        }

        //check's if the players filled their names
        public bool CheckNameFieldEmptiness()
        {
            if (FirstPlayerNameTextBox.Text != "" && SecondPlayerNameTextBox.Text != "")
            {
                playerName1 = FirstPlayerNameTextBox.Text;
                playerName2 = SecondPlayerNameTextBox.Text;
                return true;
            }
            else
                return false;

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}