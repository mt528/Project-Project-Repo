
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
            this.PanelLoadErrorLabel = new System.Windows.Forms.Label();
            this.SpeedTestIntroPanel = new System.Windows.Forms.Panel();
            this.SpeedTestPanel = new System.Windows.Forms.Panel();
            this.TestDonePanel = new System.Windows.Forms.Panel();
            this.TestDoneButton = new System.Windows.Forms.Button();
            this.TestDoneLabel = new System.Windows.Forms.Label();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.ReadyButton = new System.Windows.Forms.Button();
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
            this.SpeedTestPanel.Controls.Add(this.QuestionLabel);
            this.SpeedTestPanel.Controls.Add(this.CheckButton);
            this.SpeedTestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeedTestPanel.Location = new System.Drawing.Point(0, 0);
            this.SpeedTestPanel.Name = "SpeedTestPanel";
            this.SpeedTestPanel.Size = new System.Drawing.Size(800, 450);
            this.SpeedTestPanel.TabIndex = 2;
            // 
            // TestDonePanel
            // 
            this.TestDonePanel.Controls.Add(this.TestDoneButton);
            this.TestDonePanel.Controls.Add(this.TestDoneLabel);
            this.TestDonePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestDonePanel.Location = new System.Drawing.Point(0, 0);
            this.TestDonePanel.Name = "TestDonePanel";
            this.TestDonePanel.Size = new System.Drawing.Size(800, 450);
            this.TestDonePanel.TabIndex = 3;
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
            this.TestDoneLabel.Location = new System.Drawing.Point(251, 158);
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
    }
}