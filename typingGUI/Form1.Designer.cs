namespace typingGUI
{
    partial class TypingGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypingGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.exerciseWords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshGame = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.LinkLabel();
            this.wordsCountInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.wordsCountInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Name = "label1";
            // 
            // exitBtn
            // 
            resources.ApplyResources(this.exitBtn, "exitBtn");
            this.exitBtn.ForeColor = System.Drawing.Color.Red;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // startGameBtn
            // 
            resources.ApplyResources(this.startGameBtn, "startGameBtn");
            this.startGameBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.UseVisualStyleBackColor = false;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // exerciseWords
            // 
            resources.ApplyResources(this.exerciseWords, "exerciseWords");
            this.exerciseWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exerciseWords.ForeColor = System.Drawing.Color.White;
            this.exerciseWords.Name = "exerciseWords";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Name = "label3";
            // 
            // userInput
            // 
            resources.ApplyResources(this.userInput, "userInput");
            this.userInput.BackColor = System.Drawing.Color.DodgerBlue;
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInput.Name = "userInput";
            this.userInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userInput_KeyDown);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Name = "label2";
            // 
            // refreshGame
            // 
            resources.ApplyResources(this.refreshGame, "refreshGame");
            this.refreshGame.BackColor = System.Drawing.Color.Transparent;
            this.refreshGame.ForeColor = System.Drawing.Color.Red;
            this.refreshGame.Name = "refreshGame";
            this.refreshGame.UseVisualStyleBackColor = false;
            this.refreshGame.Click += new System.EventHandler(this.refreshGame_Click);
            // 
            // authorLabel
            // 
            resources.ApplyResources(this.authorLabel, "authorLabel");
            this.authorLabel.LinkColor = System.Drawing.Color.White;
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.TabStop = true;
            this.authorLabel.Click += new System.EventHandler(this.authorLabel_Click);
            // 
            // wordsCountInput
            // 
            resources.ApplyResources(this.wordsCountInput, "wordsCountInput");
            this.wordsCountInput.Name = "wordsCountInput";
            this.wordsCountInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wordsCountInput_KeyDown);
            // 
            // TypingGUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.wordsCountInput);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.refreshGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exerciseWords);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "TypingGUI";
            this.Opacity = 0.95D;
            ((System.ComponentModel.ISupportInitialize)(this.wordsCountInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button exitBtn;
        private Button startGameBtn;
        private Label exerciseWords;
        private Label label3;
        private RichTextBox userInput;
        private Label label2;
        private Button refreshGame;
        private LinkLabel authorLabel;
        private NumericUpDown wordsCountInput;
    }
}