
namespace Form_Ver
{
    partial class KanjiTestForm
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
            this.KanjiTestIntroLabel = new System.Windows.Forms.Label();
            this.KanjiTestIntroButton = new System.Windows.Forms.Button();
            this.KanjiTestQuestionPanel = new System.Windows.Forms.Panel();
            this.KanjiTestAnswerPanel = new System.Windows.Forms.Panel();
            this.KanjiTestDonePanel = new System.Windows.Forms.Panel();
            this.KanjiTestDonePanelLabel = new System.Windows.Forms.Label();
            this.KanjiTestDonePanelButton = new System.Windows.Forms.Button();
            this.KanjiTestAnswerPanelLabel1 = new System.Windows.Forms.Label();
            this.KanjiTestPanel2CorrectButton = new System.Windows.Forms.Button();
            this.KanjiTestPanel2WrongButton = new System.Windows.Forms.Button();
            this.KanjiTestPanel2MeaningLabel = new System.Windows.Forms.Label();
            this.KanjiTestPanel2OnYomiLabel = new System.Windows.Forms.Label();
            this.KanjiTestPanel2KunYomiLabel = new System.Windows.Forms.Label();
            this.KanjiTestPanel2AnswerLabel = new System.Windows.Forms.Label();
            this.KanjiTestPanelCheckButton = new System.Windows.Forms.Button();
            this.KanjiMeaningLabel = new System.Windows.Forms.Label();
            this.KanjiTestPanel1OnYomiLabel = new System.Windows.Forms.Label();
            this.KanjiTestPanel1KunYomiLabel = new System.Windows.Forms.Label();
            this.KanjiTestPanel1QuestionLabel = new System.Windows.Forms.Label();
            this.KanjiTestQuestionPanelLabel1 = new System.Windows.Forms.Label();
            this.KanjiTestQuestionPanel.SuspendLayout();
            this.KanjiTestAnswerPanel.SuspendLayout();
            this.KanjiTestDonePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // KanjiTestIntroLabel
            // 
            this.KanjiTestIntroLabel.AutoSize = true;
            this.KanjiTestIntroLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiTestIntroLabel.Location = new System.Drawing.Point(257, 54);
            this.KanjiTestIntroLabel.Name = "KanjiTestIntroLabel";
            this.KanjiTestIntroLabel.Size = new System.Drawing.Size(284, 30);
            this.KanjiTestIntroLabel.TabIndex = 0;
            this.KanjiTestIntroLabel.Text = "Click \"Begin\" to start the test!";
            // 
            // KanjiTestIntroButton
            // 
            this.KanjiTestIntroButton.Location = new System.Drawing.Point(323, 321);
            this.KanjiTestIntroButton.Name = "KanjiTestIntroButton";
            this.KanjiTestIntroButton.Size = new System.Drawing.Size(128, 46);
            this.KanjiTestIntroButton.TabIndex = 1;
            this.KanjiTestIntroButton.Text = "Begin";
            this.KanjiTestIntroButton.UseVisualStyleBackColor = true;
            this.KanjiTestIntroButton.Click += new System.EventHandler(this.KanjiTestIntroButton_Click);
            // 
            // KanjiTestQuestionPanel
            // 
            this.KanjiTestQuestionPanel.Controls.Add(this.KanjiTestAnswerPanel);
            this.KanjiTestQuestionPanel.Controls.Add(this.KanjiTestPanelCheckButton);
            this.KanjiTestQuestionPanel.Controls.Add(this.KanjiMeaningLabel);
            this.KanjiTestQuestionPanel.Controls.Add(this.KanjiTestPanel1OnYomiLabel);
            this.KanjiTestQuestionPanel.Controls.Add(this.KanjiTestPanel1KunYomiLabel);
            this.KanjiTestQuestionPanel.Controls.Add(this.KanjiTestPanel1QuestionLabel);
            this.KanjiTestQuestionPanel.Controls.Add(this.KanjiTestQuestionPanelLabel1);
            this.KanjiTestQuestionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KanjiTestQuestionPanel.Location = new System.Drawing.Point(0, 0);
            this.KanjiTestQuestionPanel.Name = "KanjiTestQuestionPanel";
            this.KanjiTestQuestionPanel.Size = new System.Drawing.Size(800, 450);
            this.KanjiTestQuestionPanel.TabIndex = 2;
            // 
            // KanjiTestAnswerPanel
            // 
            this.KanjiTestAnswerPanel.Controls.Add(this.KanjiTestDonePanel);
            this.KanjiTestAnswerPanel.Controls.Add(this.KanjiTestAnswerPanelLabel1);
            this.KanjiTestAnswerPanel.Controls.Add(this.KanjiTestPanel2CorrectButton);
            this.KanjiTestAnswerPanel.Controls.Add(this.KanjiTestPanel2WrongButton);
            this.KanjiTestAnswerPanel.Controls.Add(this.KanjiTestPanel2MeaningLabel);
            this.KanjiTestAnswerPanel.Controls.Add(this.KanjiTestPanel2OnYomiLabel);
            this.KanjiTestAnswerPanel.Controls.Add(this.KanjiTestPanel2KunYomiLabel);
            this.KanjiTestAnswerPanel.Controls.Add(this.KanjiTestPanel2AnswerLabel);
            this.KanjiTestAnswerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KanjiTestAnswerPanel.Location = new System.Drawing.Point(0, 0);
            this.KanjiTestAnswerPanel.Name = "KanjiTestAnswerPanel";
            this.KanjiTestAnswerPanel.Size = new System.Drawing.Size(800, 450);
            this.KanjiTestAnswerPanel.TabIndex = 5;
            // 
            // KanjiTestDonePanel
            // 
            this.KanjiTestDonePanel.Controls.Add(this.KanjiTestDonePanelLabel);
            this.KanjiTestDonePanel.Controls.Add(this.KanjiTestDonePanelButton);
            this.KanjiTestDonePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KanjiTestDonePanel.Location = new System.Drawing.Point(0, 0);
            this.KanjiTestDonePanel.Name = "KanjiTestDonePanel";
            this.KanjiTestDonePanel.Size = new System.Drawing.Size(800, 450);
            this.KanjiTestDonePanel.TabIndex = 7;
            // 
            // KanjiTestDonePanelLabel
            // 
            this.KanjiTestDonePanelLabel.AutoSize = true;
            this.KanjiTestDonePanelLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiTestDonePanelLabel.Location = new System.Drawing.Point(328, 54);
            this.KanjiTestDonePanelLabel.Name = "KanjiTestDonePanelLabel";
            this.KanjiTestDonePanelLabel.Size = new System.Drawing.Size(129, 32);
            this.KanjiTestDonePanelLabel.TabIndex = 6;
            this.KanjiTestDonePanelLabel.Text = "Well done!";
            // 
            // KanjiTestDonePanelButton
            // 
            this.KanjiTestDonePanelButton.Location = new System.Drawing.Point(323, 352);
            this.KanjiTestDonePanelButton.Name = "KanjiTestDonePanelButton";
            this.KanjiTestDonePanelButton.Size = new System.Drawing.Size(115, 37);
            this.KanjiTestDonePanelButton.TabIndex = 5;
            this.KanjiTestDonePanelButton.Text = "Continue";
            this.KanjiTestDonePanelButton.UseVisualStyleBackColor = true;
            this.KanjiTestDonePanelButton.Click += new System.EventHandler(this.KanjiTestDonePanelButton_Click);
            // 
            // KanjiTestAnswerPanelLabel1
            // 
            this.KanjiTestAnswerPanelLabel1.AutoSize = true;
            this.KanjiTestAnswerPanelLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiTestAnswerPanelLabel1.Location = new System.Drawing.Point(12, 9);
            this.KanjiTestAnswerPanelLabel1.Name = "KanjiTestAnswerPanelLabel1";
            this.KanjiTestAnswerPanelLabel1.Size = new System.Drawing.Size(81, 30);
            this.KanjiTestAnswerPanelLabel1.TabIndex = 6;
            this.KanjiTestAnswerPanelLabel1.Text = "Answer";
            // 
            // KanjiTestPanel2CorrectButton
            // 
            this.KanjiTestPanel2CorrectButton.Location = new System.Drawing.Point(401, 364);
            this.KanjiTestPanel2CorrectButton.Name = "KanjiTestPanel2CorrectButton";
            this.KanjiTestPanel2CorrectButton.Size = new System.Drawing.Size(115, 37);
            this.KanjiTestPanel2CorrectButton.TabIndex = 5;
            this.KanjiTestPanel2CorrectButton.Text = "Correct";
            this.KanjiTestPanel2CorrectButton.UseVisualStyleBackColor = true;
            this.KanjiTestPanel2CorrectButton.Click += new System.EventHandler(this.KanjiTestPanel2CorrectButton_Click);
            // 
            // KanjiTestPanel2WrongButton
            // 
            this.KanjiTestPanel2WrongButton.Location = new System.Drawing.Point(230, 364);
            this.KanjiTestPanel2WrongButton.Name = "KanjiTestPanel2WrongButton";
            this.KanjiTestPanel2WrongButton.Size = new System.Drawing.Size(115, 37);
            this.KanjiTestPanel2WrongButton.TabIndex = 4;
            this.KanjiTestPanel2WrongButton.Text = "Wrong";
            this.KanjiTestPanel2WrongButton.UseVisualStyleBackColor = true;
            this.KanjiTestPanel2WrongButton.Click += new System.EventHandler(this.KanjiTestPanel2WrongButton_Click);
            // 
            // KanjiTestPanel2MeaningLabel
            // 
            this.KanjiTestPanel2MeaningLabel.AutoSize = true;
            this.KanjiTestPanel2MeaningLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiTestPanel2MeaningLabel.Location = new System.Drawing.Point(328, 217);
            this.KanjiTestPanel2MeaningLabel.Name = "KanjiTestPanel2MeaningLabel";
            this.KanjiTestPanel2MeaningLabel.Size = new System.Drawing.Size(100, 30);
            this.KanjiTestPanel2MeaningLabel.TabIndex = 3;
            this.KanjiTestPanel2MeaningLabel.Text = "Meaning:";
            this.KanjiTestPanel2MeaningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KanjiTestPanel2OnYomiLabel
            // 
            this.KanjiTestPanel2OnYomiLabel.AutoSize = true;
            this.KanjiTestPanel2OnYomiLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiTestPanel2OnYomiLabel.Location = new System.Drawing.Point(553, 151);
            this.KanjiTestPanel2OnYomiLabel.Name = "KanjiTestPanel2OnYomiLabel";
            this.KanjiTestPanel2OnYomiLabel.Size = new System.Drawing.Size(189, 30);
            this.KanjiTestPanel2OnYomiLabel.TabIndex = 2;
            this.KanjiTestPanel2OnYomiLabel.Text = "On-Yomi Readings:";
            this.KanjiTestPanel2OnYomiLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KanjiTestPanel2KunYomiLabel
            // 
            this.KanjiTestPanel2KunYomiLabel.AutoSize = true;
            this.KanjiTestPanel2KunYomiLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiTestPanel2KunYomiLabel.Location = new System.Drawing.Point(12, 151);
            this.KanjiTestPanel2KunYomiLabel.Name = "KanjiTestPanel2KunYomiLabel";
            this.KanjiTestPanel2KunYomiLabel.Size = new System.Drawing.Size(197, 30);
            this.KanjiTestPanel2KunYomiLabel.TabIndex = 1;
            this.KanjiTestPanel2KunYomiLabel.Text = "Kun-Yomi Readings:";
            this.KanjiTestPanel2KunYomiLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KanjiTestPanel2AnswerLabel
            // 
            this.KanjiTestPanel2AnswerLabel.AutoSize = true;
            this.KanjiTestPanel2AnswerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiTestPanel2AnswerLabel.Location = new System.Drawing.Point(257, 38);
            this.KanjiTestPanel2AnswerLabel.Name = "KanjiTestPanel2AnswerLabel";
            this.KanjiTestPanel2AnswerLabel.Size = new System.Drawing.Size(247, 30);
            this.KanjiTestPanel2AnswerLabel.TabIndex = 0;
            this.KanjiTestPanel2AnswerLabel.Text = "What are the reading for:";
            this.KanjiTestPanel2AnswerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KanjiTestPanelCheckButton
            // 
            this.KanjiTestPanelCheckButton.Location = new System.Drawing.Point(323, 364);
            this.KanjiTestPanelCheckButton.Name = "KanjiTestPanelCheckButton";
            this.KanjiTestPanelCheckButton.Size = new System.Drawing.Size(115, 37);
            this.KanjiTestPanelCheckButton.TabIndex = 4;
            this.KanjiTestPanelCheckButton.Text = "Check";
            this.KanjiTestPanelCheckButton.UseVisualStyleBackColor = true;
            this.KanjiTestPanelCheckButton.Click += new System.EventHandler(this.KanjiTestPanelCheckButton_Click);
            // 
            // KanjiMeaningLabel
            // 
            this.KanjiMeaningLabel.AutoSize = true;
            this.KanjiMeaningLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiMeaningLabel.Location = new System.Drawing.Point(328, 217);
            this.KanjiMeaningLabel.Name = "KanjiMeaningLabel";
            this.KanjiMeaningLabel.Size = new System.Drawing.Size(100, 30);
            this.KanjiMeaningLabel.TabIndex = 3;
            this.KanjiMeaningLabel.Text = "Meaning:";
            this.KanjiMeaningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KanjiMeaningLabel.Click += new System.EventHandler(this.KanjiMeaningLabel_Click);
            // 
            // KanjiTestPanel1OnYomiLabel
            // 
            this.KanjiTestPanel1OnYomiLabel.AutoSize = true;
            this.KanjiTestPanel1OnYomiLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiTestPanel1OnYomiLabel.Location = new System.Drawing.Point(553, 151);
            this.KanjiTestPanel1OnYomiLabel.Name = "KanjiTestPanel1OnYomiLabel";
            this.KanjiTestPanel1OnYomiLabel.Size = new System.Drawing.Size(189, 30);
            this.KanjiTestPanel1OnYomiLabel.TabIndex = 2;
            this.KanjiTestPanel1OnYomiLabel.Text = "On-Yomi Readings:";
            this.KanjiTestPanel1OnYomiLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KanjiTestPanel1OnYomiLabel.Click += new System.EventHandler(this.KanjiTestPanel1OnYomiLabel_Click);
            // 
            // KanjiTestPanel1KunYomiLabel
            // 
            this.KanjiTestPanel1KunYomiLabel.AutoSize = true;
            this.KanjiTestPanel1KunYomiLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiTestPanel1KunYomiLabel.Location = new System.Drawing.Point(12, 151);
            this.KanjiTestPanel1KunYomiLabel.Name = "KanjiTestPanel1KunYomiLabel";
            this.KanjiTestPanel1KunYomiLabel.Size = new System.Drawing.Size(197, 30);
            this.KanjiTestPanel1KunYomiLabel.TabIndex = 1;
            this.KanjiTestPanel1KunYomiLabel.Text = "Kun-Yomi Readings:";
            this.KanjiTestPanel1KunYomiLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KanjiTestPanel1KunYomiLabel.Click += new System.EventHandler(this.KanjiTestPanel1KunYomiLabel_Click);
            // 
            // KanjiTestPanel1QuestionLabel
            // 
            this.KanjiTestPanel1QuestionLabel.AutoSize = true;
            this.KanjiTestPanel1QuestionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiTestPanel1QuestionLabel.Location = new System.Drawing.Point(257, 38);
            this.KanjiTestPanel1QuestionLabel.Name = "KanjiTestPanel1QuestionLabel";
            this.KanjiTestPanel1QuestionLabel.Size = new System.Drawing.Size(247, 30);
            this.KanjiTestPanel1QuestionLabel.TabIndex = 0;
            this.KanjiTestPanel1QuestionLabel.Text = "What are the reading for:";
            this.KanjiTestPanel1QuestionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KanjiTestPanel1QuestionLabel.Click += new System.EventHandler(this.KanjiTestPanel1QuestionLabel_Click);
            // 
            // KanjiTestQuestionPanelLabel1
            // 
            this.KanjiTestQuestionPanelLabel1.AutoSize = true;
            this.KanjiTestQuestionPanelLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiTestQuestionPanelLabel1.Location = new System.Drawing.Point(12, 9);
            this.KanjiTestQuestionPanelLabel1.Name = "KanjiTestQuestionPanelLabel1";
            this.KanjiTestQuestionPanelLabel1.Size = new System.Drawing.Size(97, 30);
            this.KanjiTestQuestionPanelLabel1.TabIndex = 7;
            this.KanjiTestQuestionPanelLabel1.Text = "Question";
            // 
            // KanjiTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KanjiTestQuestionPanel);
            this.Controls.Add(this.KanjiTestIntroButton);
            this.Controls.Add(this.KanjiTestIntroLabel);
            this.Name = "KanjiTestForm";
            this.Text = "KanjiTestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KanjiTestForm_FormClosed);
            this.KanjiTestQuestionPanel.ResumeLayout(false);
            this.KanjiTestQuestionPanel.PerformLayout();
            this.KanjiTestAnswerPanel.ResumeLayout(false);
            this.KanjiTestAnswerPanel.PerformLayout();
            this.KanjiTestDonePanel.ResumeLayout(false);
            this.KanjiTestDonePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KanjiTestIntroLabel;
        private System.Windows.Forms.Button KanjiTestIntroButton;
        private System.Windows.Forms.Panel KanjiTestQuestionPanel;
        private System.Windows.Forms.Label KanjiTestPanel1OnYomiLabel;
        private System.Windows.Forms.Label KanjiTestPanel1KunYomiLabel;
        private System.Windows.Forms.Label KanjiTestPanel1QuestionLabel;
        private System.Windows.Forms.Label KanjiMeaningLabel;
        private System.Windows.Forms.Button KanjiTestPanelCheckButton;
        private System.Windows.Forms.Panel KanjiTestAnswerPanel;
        private System.Windows.Forms.Button KanjiTestPanel2CorrectButton;
        private System.Windows.Forms.Button KanjiTestPanel2WrongButton;
        private System.Windows.Forms.Label KanjiTestPanel2MeaningLabel;
        private System.Windows.Forms.Label KanjiTestPanel2OnYomiLabel;
        private System.Windows.Forms.Label KanjiTestPanel2KunYomiLabel;
        private System.Windows.Forms.Label KanjiTestPanel2AnswerLabel;
        private System.Windows.Forms.Label KanjiTestQuestionPanelLabel1;
        private System.Windows.Forms.Label KanjiTestAnswerPanelLabel1;
        private System.Windows.Forms.Panel KanjiTestDonePanel;
        private System.Windows.Forms.Label KanjiTestDonePanelLabel;
        private System.Windows.Forms.Button KanjiTestDonePanelButton;
    }
}