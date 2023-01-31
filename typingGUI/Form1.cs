using System.Reflection;

namespace typingGUI
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        public Form1()
        {
            InitializeComponent();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            if (this.wordsCountInput.Text != "")
            {
                this.startGameBtn.Visible = false;
                this.label3.Visible = false;
                this.wordsCountInput.Visible = false;
                game.StartGame(Convert.ToInt32(this.wordsCountInput.Text));
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
                }
                else
                {
                    this.exerciseWords.Text = "Every word succesfully written";
                }
                this.label2.Visible = true;
            }
        }

        private void wordsCountInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                startGameBtn.PerformClick();
            }
        }
    }
}