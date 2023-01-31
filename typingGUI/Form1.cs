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
            this.startGameBtn.Visible = false;
            game.StartGame();
            this.exerciseWords.Text = game.GetExerciseWords();
        }
    }
}