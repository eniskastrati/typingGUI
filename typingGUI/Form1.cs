using System.Diagnostics;
using System.Reflection;
using static System.Windows.Forms.LinkLabel;

namespace typingGUI
{
    public partial class TypingGUI : Form
    {
        Game game = new Game();
        public TypingGUI()
        {
            InitializeComponent();
            this.wordsCountInput.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            if (this.wordsCountInput.Value != 0)
            {
                this.startGameBtn.Visible = false;
                this.label3.Visible = false;
                this.wordsCountInput.Visible = false;
                game.StartGame(Convert.ToInt32(this.wordsCountInput.Value));
                this.exerciseWords.Text = game.GetExerciseWords();
                this.userInput.Visible = true;
                this.userInput.Focus();
                this.label2.Visible = true;
            }
        }

        private void userInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                game.StopGame(userInput.Text.ToString());
                this.userInput.Visible = false;
                if(game.GetDiff().Length > 0)
                {
                    label2.Text = "The words above were not typed correctly";
                    this.exerciseWords.Text = game.GetDiff();
                    this.label2.Visible = true;
                }
                else
                {
                    this.exerciseWords.Text = "Every word succesfully written";
                }
            }
        }

        private void wordsCountInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                startGameBtn.PerformClick();
            }
        }

        private void refreshGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void authorLabel_Click(object sender, EventArgs e)
        {
            var form = new AuthorInfo();
            form.Show();
        }
    }
}