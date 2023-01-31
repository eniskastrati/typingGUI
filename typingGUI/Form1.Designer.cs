namespace typingGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.exerciseWords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wordsCountInput = new System.Windows.Forms.TextBox();
            this.userInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(256, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Typing Excercises";
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitBtn.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.exitBtn.Location = new System.Drawing.Point(766, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(22, 27);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // startGameBtn
            // 
            this.startGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(56)))));
            this.startGameBtn.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startGameBtn.Location = new System.Drawing.Point(364, 194);
            this.startGameBtn.Margin = new System.Windows.Forms.Padding(1);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(85, 33);
            this.startGameBtn.TabIndex = 3;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = false;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // exerciseWords
            // 
            this.exerciseWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exerciseWords.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exerciseWords.Location = new System.Drawing.Point(49, 88);
            this.exerciseWords.Name = "exerciseWords";
            this.exerciseWords.Size = new System.Drawing.Size(693, 178);
            this.exerciseWords.TabIndex = 4;
            this.exerciseWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(328, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "NumberOfWords";
            // 
            // wordsCountInput
            // 
            this.wordsCountInput.Location = new System.Drawing.Point(432, 166);
            this.wordsCountInput.Name = "wordsCountInput";
            this.wordsCountInput.Size = new System.Drawing.Size(41, 23);
            this.wordsCountInput.TabIndex = 6;
            this.wordsCountInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wordsCountInput_KeyDown);
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.Color.LightBlue;
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInput.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userInput.Location = new System.Drawing.Point(246, 304);
            this.userInput.Name = "userInput";
            this.userInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.userInput.Size = new System.Drawing.Size(336, 80);
            this.userInput.TabIndex = 7;
            this.userInput.Text = "";
            this.userInput.Visible = false;
            this.userInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userInput_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(309, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Click Enter when you finish the exercise";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.wordsCountInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exerciseWords);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button exitBtn;
        private Button startGameBtn;
        private Label exerciseWords;
        private Label label3;
        private TextBox wordsCountInput;
        private RichTextBox userInput;
        private Label label2;
    }
}