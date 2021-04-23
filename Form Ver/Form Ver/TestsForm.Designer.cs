
namespace Form_Ver
{
    partial class TestsForm
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
            this.components = new System.ComponentModel.Container();
            this.PanelLoadErrorLabel = new System.Windows.Forms.Label();
            this.SpeedTestIntroPanel = new System.Windows.Forms.Panel();
            this.SpeedTestPanel = new System.Windows.Forms.Panel();
            this.TestDonePanel = new System.Windows.Forms.Panel();
            this.MistakeTrackerLabel = new System.Windows.Forms.Label();
            this.AnswerAccuracyLabel = new System.Windows.Forms.Label();
            this.WrongCorrectCountLabel = new System.Windows.Forms.Label();
            this.AnswerCorrectCountLabel = new System.Windows.Forms.Label();
            this.TimeResultLabel = new System.Windows.Forms.Label();
            this.TestDoneButton = new System.Windows.Forms.Button();
            this.TestDoneLabel = new System.Windows.Forms.Label();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.SpeedTestWrongAnswerLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SpeedTestCorrectAnswerLabel = new System.Windows.Forms.Label();
            this.TimeTakenLabel = new System.Windows.Forms.Label();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SpeedTestIntroPanel.SuspendLayout();
            this.SpeedTestPanel.SuspendLayout();
            this.TestDonePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLoadErrorLabel
            // 
            this.PanelLoadErrorLabel.AutoSize = true;
            this.PanelLoadErrorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PanelLoadErrorLabel.Location = new System.Drawing.Point(288, 205);
            this.PanelLoadErrorLabel.Name = "PanelLoadErrorLabel";
            this.PanelLoadErrorLabel.Size = new System.Drawing.Size(186, 32);
            this.PanelLoadErrorLabel.TabIndex = 0;
            this.PanelLoadErrorLabel.Text = "Panel Load Error";
            this.PanelLoadErrorLabel.Click += new System.EventHandler(this.PanelLoadErrorLabel_Click);
            // 
            // SpeedTestIntroPanel
            // 
            this.SpeedTestIntroPanel.Controls.Add(this.SpeedTestPanel);
            this.SpeedTestIntroPanel.Controls.Add(this.IntroLabel);
            this.SpeedTestIntroPanel.Controls.Add(this.ReadyButton);
            this.SpeedTestIntroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeedTestIntroPanel.Location = new System.Drawing.Point(0, 0);
            this.SpeedTestIntroPanel.Name = "SpeedTestIntroPanel";
            this.SpeedTestIntroPanel.Size = new System.Drawing.Size(800, 450);
            this.SpeedTestIntroPanel.TabIndex = 1;
            this.SpeedTestIntroPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SpeedTestIntroPanel_Paint);
            // 
            // SpeedTestPanel
            // 
            this.SpeedTestPanel.Controls.Add(this.TestDonePanel);
            this.SpeedTestPanel.Controls.Add(this.AnswerBox);
            this.SpeedTestPanel.Controls.Add(this.SpeedTestWrongAnswerLabel);
            this.SpeedTestPanel.Controls.Add(this.QuestionLabel);
            this.SpeedTestPanel.Controls.Add(this.CheckButton);
            this.SpeedTestPanel.Controls.Add(this.SpeedTestCorrectAnswerLabel);
            this.SpeedTestPanel.Controls.Add(this.TimeTakenLabel);
            this.SpeedTestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeedTestPanel.Location = new System.Drawing.Point(0, 0);
            this.SpeedTestPanel.Name = "SpeedTestPanel";
            this.SpeedTestPanel.Size = new System.Drawing.Size(800, 450);
            this.SpeedTestPanel.TabIndex = 2;
            this.SpeedTestPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SpeedTestPanel_Paint);
            // 
            // TestDonePanel
            // 
            this.TestDonePanel.Controls.Add(this.MistakeTrackerLabel);
            this.TestDonePanel.Controls.Add(this.AnswerAccuracyLabel);
            this.TestDonePanel.Controls.Add(this.WrongCorrectCountLabel);
            this.TestDonePanel.Controls.Add(this.AnswerCorrectCountLabel);
            this.TestDonePanel.Controls.Add(this.TimeResultLabel);
            this.TestDonePanel.Controls.Add(this.TestDoneButton);
            this.TestDonePanel.Controls.Add(this.TestDoneLabel);
            this.TestDonePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestDonePanel.Location = new System.Drawing.Point(0, 0);
            this.TestDonePanel.Name = "TestDonePanel";
            this.TestDonePanel.Size = new System.Drawing.Size(800, 450);
            this.TestDonePanel.TabIndex = 3;
            // 
            // MistakeTrackerLabel
            // 
            this.MistakeTrackerLabel.AutoSize = true;
            this.MistakeTrackerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MistakeTrackerLabel.Location = new System.Drawing.Point(549, 102);
            this.MistakeTrackerLabel.Name = "MistakeTrackerLabel";
            this.MistakeTrackerLabel.Size = new System.Drawing.Size(230, 270);
            this.MistakeTrackerLabel.TabIndex = 5;
            this.MistakeTrackerLabel.Text = "Lesson Content Wrong:\r\nLesson 1:\r\nLesson 2:\r\nLesson 3:\r\nLesson 4:\r\nLesson 5:\r\nLes" +
    "son 6:\r\nLesson 7:\r\nLesson 8:";
            // 
            // AnswerAccuracyLabel
            // 
            this.AnswerAccuracyLabel.AutoSize = true;
            this.AnswerAccuracyLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerAccuracyLabel.Location = new System.Drawing.Point(17, 188);
            this.AnswerAccuracyLabel.Name = "AnswerAccuracyLabel";
            this.AnswerAccuracyLabel.Size = new System.Drawing.Size(113, 32);
            this.AnswerAccuracyLabel.TabIndex = 4;
            this.AnswerAccuracyLabel.Text = "Accuracy:";
            this.AnswerAccuracyLabel.Click += new System.EventHandler(this.AnswerAccuracyLabel_Click);
            // 
            // WrongCorrectCountLabel
            // 
            this.WrongCorrectCountLabel.AutoSize = true;
            this.WrongCorrectCountLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WrongCorrectCountLabel.Location = new System.Drawing.Point(17, 126);
            this.WrongCorrectCountLabel.Name = "WrongCorrectCountLabel";
            this.WrongCorrectCountLabel.Size = new System.Drawing.Size(192, 32);
            this.WrongCorrectCountLabel.TabIndex = 3;
            this.WrongCorrectCountLabel.Text = "Answers Wrong: ";
            this.WrongCorrectCountLabel.Click += new System.EventHandler(this.WrongCorrectCountLabel_Click);
            // 
            // AnswerCorrectCountLabel
            // 
            this.AnswerCorrectCountLabel.AutoSize = true;
            this.AnswerCorrectCountLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerCorrectCountLabel.Location = new System.Drawing.Point(17, 94);
            this.AnswerCorrectCountLabel.Name = "AnswerCorrectCountLabel";
            this.AnswerCorrectCountLabel.Size = new System.Drawing.Size(197, 32);
            this.AnswerCorrectCountLabel.TabIndex = 3;
            this.AnswerCorrectCountLabel.Text = "Answers Correct: ";
            this.AnswerCorrectCountLabel.Click += new System.EventHandler(this.AnswerCorrectCountLabel_Click);
            // 
            // TimeResultLabel
            // 
            this.TimeResultLabel.AutoSize = true;
            this.TimeResultLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeResultLabel.Location = new System.Drawing.Point(17, 264);
            this.TimeResultLabel.Name = "TimeResultLabel";
            this.TimeResultLabel.Size = new System.Drawing.Size(471, 32);
            this.TimeResultLabel.TabIndex = 2;
            this.TimeResultLabel.Text = "You took <> seconds to complete the test!";
            this.TimeResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TimeResultLabel.Click += new System.EventHandler(this.TimeResultLabel_Click);
            // 
            // TestDoneButton
            // 
            this.TestDoneButton.Location = new System.Drawing.Point(324, 351);
            this.TestDoneButton.Name = "TestDoneButton";
            this.TestDoneButton.Size = new System.Drawing.Size(127, 49);
            this.TestDoneButton.TabIndex = 1;
            this.TestDoneButton.Text = "Go back";
            this.TestDoneButton.UseVisualStyleBackColor = true;
            this.TestDoneButton.Click += new System.EventHandler(this.TestDoneButton_Click);
            // 
            // TestDoneLabel
            // 
            this.TestDoneLabel.AutoSize = true;
            this.TestDoneLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TestDoneLabel.Location = new System.Drawing.Point(248, 21);
            this.TestDoneLabel.Name = "TestDoneLabel";
            this.TestDoneLabel.Size = new System.Drawing.Size(298, 64);
            this.TestDoneLabel.TabIndex = 0;
            this.TestDoneLabel.Text = "Well done!\r\nYou have finished the test!";
            this.TestDoneLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TestDoneLabel.Click += new System.EventHandler(this.TestDoneLabel_Click);
            // 
            // AnswerBox
            // 
            this.AnswerBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerBox.Location = new System.Drawing.Point(288, 261);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(198, 35);
            this.AnswerBox.TabIndex = 0;
            this.AnswerBox.TextChanged += new System.EventHandler(this.AnswerBox_TextChanged);
            this.AnswerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerBox_KeyDown);
            // 
            // SpeedTestWrongAnswerLabel
            // 
            this.SpeedTestWrongAnswerLabel.AutoSize = true;
            this.SpeedTestWrongAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeedTestWrongAnswerLabel.Location = new System.Drawing.Point(17, 94);
            this.SpeedTestWrongAnswerLabel.Name = "SpeedTestWrongAnswerLabel";
            this.SpeedTestWrongAnswerLabel.Size = new System.Drawing.Size(205, 32);
            this.SpeedTestWrongAnswerLabel.TabIndex = 5;
            this.SpeedTestWrongAnswerLabel.Text = "Answers Wrong: 0";
            this.SpeedTestWrongAnswerLabel.Click += new System.EventHandler(this.SpeedTestWrongAnswerLabel_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionLabel.Location = new System.Drawing.Point(288, 173);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(111, 32);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Question";
            this.QuestionLabel.Click += new System.EventHandler(this.QuestionLabel_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(324, 332);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(114, 40);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // SpeedTestCorrectAnswerLabel
            // 
            this.SpeedTestCorrectAnswerLabel.AutoSize = true;
            this.SpeedTestCorrectAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeedTestCorrectAnswerLabel.Location = new System.Drawing.Point(17, 53);
            this.SpeedTestCorrectAnswerLabel.Name = "SpeedTestCorrectAnswerLabel";
            this.SpeedTestCorrectAnswerLabel.Size = new System.Drawing.Size(210, 32);
            this.SpeedTestCorrectAnswerLabel.TabIndex = 4;
            this.SpeedTestCorrectAnswerLabel.Text = "Answers Correct: 0";
            this.SpeedTestCorrectAnswerLabel.Click += new System.EventHandler(this.SpeedTestCorrectAnswerLabel_Click);
            // 
            // TimeTakenLabel
            // 
            this.TimeTakenLabel.AutoSize = true;
            this.TimeTakenLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeTakenLabel.Location = new System.Drawing.Point(565, 94);
            this.TimeTakenLabel.Name = "TimeTakenLabel";
            this.TimeTakenLabel.Size = new System.Drawing.Size(147, 32);
            this.TimeTakenLabel.TabIndex = 6;
            this.TimeTakenLabel.Text = "Time Taken: ";
            this.TimeTakenLabel.Click += new System.EventHandler(this.TimeTakenLabel_Click);
            // 
            // IntroLabel
            // 
            this.IntroLabel.AutoSize = true;
            this.IntroLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IntroLabel.Location = new System.Drawing.Point(154, 173);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(516, 32);
            this.IntroLabel.TabIndex = 1;
            this.IntroLabel.Text = "Hit the button when you are ready for the test!";
            // 
            // ReadyButton
            // 
            this.ReadyButton.Location = new System.Drawing.Point(324, 322);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(110, 40);
            this.ReadyButton.TabIndex = 0;
            this.ReadyButton.Text = "Ready";
            this.ReadyButton.UseVisualStyleBackColor = true;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpeedTestIntroPanel);
            this.Controls.Add(this.PanelLoadErrorLabel);
            this.Name = "TestsForm";
            this.Text = "TestsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestsForm_FormClosed);
            this.SpeedTestIntroPanel.ResumeLayout(false);
            this.SpeedTestIntroPanel.PerformLayout();
            this.SpeedTestPanel.ResumeLayout(false);
            this.SpeedTestPanel.PerformLayout();
            this.TestDonePanel.ResumeLayout(false);
            this.TestDonePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PanelLoadErrorLabel;
        private System.Windows.Forms.Panel SpeedTestIntroPanel;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.Panel SpeedTestPanel;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Panel TestDonePanel;
        private System.Windows.Forms.Button TestDoneButton;
        private System.Windows.Forms.Label TestDoneLabel;
        private System.Windows.Forms.Label SpeedTestWrongAnswerLabel;
        private System.Windows.Forms.Label SpeedTestCorrectAnswerLabel;
        private System.Windows.Forms.Label TimeTakenLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeResultLabel;
        private System.Windows.Forms.Label WrongCorrectCountLabel;
        private System.Windows.Forms.Label AnswerCorrectCountLabel;
        private System.Windows.Forms.Label AnswerAccuracyLabel;
        private System.Windows.Forms.Label MistakeTrackerLabel;
    }
}