
namespace Form_Ver
{
    partial class MainMenuForm
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
            this.MainMenuText = new System.Windows.Forms.Label();
            this.MoreComingLabel = new System.Windows.Forms.Label();
            this.JapaneseLabel = new System.Windows.Forms.Label();
            this.JapaneseButton = new System.Windows.Forms.Button();
            this.JapanesePanel = new System.Windows.Forms.Panel();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.KanjiButton = new System.Windows.Forms.Button();
            this.KanjiLabel = new System.Windows.Forms.Label();
            this.ComingSoonLabel1 = new System.Windows.Forms.Label();
            this.KatakanaLabel = new System.Windows.Forms.Label();
            this.HiraganaButton = new System.Windows.Forms.Button();
            this.HiraganaLabel = new System.Windows.Forms.Label();
            this.JapaneseLabel2 = new System.Windows.Forms.Label();
            this.JapaneseLabel1 = new System.Windows.Forms.Label();
            this.BulgarianButton = new System.Windows.Forms.Button();
            this.JapanesePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuText
            // 
            this.MainMenuText.AutoSize = true;
            this.MainMenuText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuText.Location = new System.Drawing.Point(164, 82);
            this.MainMenuText.Name = "MainMenuText";
            this.MainMenuText.Size = new System.Drawing.Size(475, 40);
            this.MainMenuText.TabIndex = 0;
            this.MainMenuText.Text = "Now you need to select a language!";
            // 
            // MoreComingLabel
            // 
            this.MoreComingLabel.AutoSize = true;
            this.MoreComingLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoreComingLabel.Location = new System.Drawing.Point(487, 259);
            this.MoreComingLabel.Name = "MoreComingLabel";
            this.MoreComingLabel.Size = new System.Drawing.Size(114, 32);
            this.MoreComingLabel.TabIndex = 1;
            this.MoreComingLabel.Text = "Bulgarian";
            // 
            // JapaneseLabel
            // 
            this.JapaneseLabel.AutoSize = true;
            this.JapaneseLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JapaneseLabel.Location = new System.Drawing.Point(162, 259);
            this.JapaneseLabel.Name = "JapaneseLabel";
            this.JapaneseLabel.Size = new System.Drawing.Size(111, 32);
            this.JapaneseLabel.TabIndex = 2;
            this.JapaneseLabel.Text = "Japanese";
            // 
            // JapaneseButton
            // 
            this.JapaneseButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JapaneseButton.Location = new System.Drawing.Point(138, 310);
            this.JapaneseButton.Name = "JapaneseButton";
            this.JapaneseButton.Size = new System.Drawing.Size(158, 52);
            this.JapaneseButton.TabIndex = 3;
            this.JapaneseButton.Text = "Start Learning!";
            this.JapaneseButton.UseVisualStyleBackColor = true;
            this.JapaneseButton.Click += new System.EventHandler(this.JapaneseButton_Click);
            // 
            // JapanesePanel
            // 
            this.JapanesePanel.Controls.Add(this.GoBackButton);
            this.JapanesePanel.Controls.Add(this.KanjiButton);
            this.JapanesePanel.Controls.Add(this.KanjiLabel);
            this.JapanesePanel.Controls.Add(this.ComingSoonLabel1);
            this.JapanesePanel.Controls.Add(this.KatakanaLabel);
            this.JapanesePanel.Controls.Add(this.HiraganaButton);
            this.JapanesePanel.Controls.Add(this.HiraganaLabel);
            this.JapanesePanel.Controls.Add(this.JapaneseLabel2);
            this.JapanesePanel.Controls.Add(this.JapaneseLabel1);
            this.JapanesePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JapanesePanel.Location = new System.Drawing.Point(0, 0);
            this.JapanesePanel.MaximumSize = new System.Drawing.Size(816, 489);
            this.JapanesePanel.MinimumSize = new System.Drawing.Size(816, 489);
            this.JapanesePanel.Name = "JapanesePanel";
            this.JapanesePanel.Size = new System.Drawing.Size(816, 489);
            this.JapanesePanel.TabIndex = 4;
            this.JapanesePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.JapanesePanel_Paint);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(24, 397);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(131, 42);
            this.GoBackButton.TabIndex = 9;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // KanjiButton
            // 
            this.KanjiButton.Location = new System.Drawing.Point(597, 278);
            this.KanjiButton.Name = "KanjiButton";
            this.KanjiButton.Size = new System.Drawing.Size(131, 42);
            this.KanjiButton.TabIndex = 8;
            this.KanjiButton.Text = "Start Learning";
            this.KanjiButton.UseVisualStyleBackColor = true;
            this.KanjiButton.Click += new System.EventHandler(this.KanjiButton_Click);
            // 
            // KanjiLabel
            // 
            this.KanjiLabel.AutoSize = true;
            this.KanjiLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiLabel.Location = new System.Drawing.Point(628, 222);
            this.KanjiLabel.Name = "KanjiLabel";
            this.KanjiLabel.Size = new System.Drawing.Size(76, 37);
            this.KanjiLabel.TabIndex = 6;
            this.KanjiLabel.Text = "Kanji";
            // 
            // ComingSoonLabel1
            // 
            this.ComingSoonLabel1.AutoSize = true;
            this.ComingSoonLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComingSoonLabel1.Location = new System.Drawing.Point(346, 265);
            this.ComingSoonLabel1.Name = "ComingSoonLabel1";
            this.ComingSoonLabel1.Size = new System.Drawing.Size(144, 30);
            this.ComingSoonLabel1.TabIndex = 5;
            this.ComingSoonLabel1.Text = "Coming Soon!";
            // 
            // KatakanaLabel
            // 
            this.KatakanaLabel.AutoSize = true;
            this.KatakanaLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KatakanaLabel.Location = new System.Drawing.Point(346, 222);
            this.KatakanaLabel.Name = "KatakanaLabel";
            this.KatakanaLabel.Size = new System.Drawing.Size(126, 37);
            this.KatakanaLabel.TabIndex = 4;
            this.KatakanaLabel.Text = "Katakana";
            // 
            // HiraganaButton
            // 
            this.HiraganaButton.Location = new System.Drawing.Point(66, 278);
            this.HiraganaButton.Name = "HiraganaButton";
            this.HiraganaButton.Size = new System.Drawing.Size(131, 42);
            this.HiraganaButton.TabIndex = 3;
            this.HiraganaButton.Text = "Start Learning";
            this.HiraganaButton.UseVisualStyleBackColor = true;
            this.HiraganaButton.Click += new System.EventHandler(this.HiraganaButton_Click);
            // 
            // HiraganaLabel
            // 
            this.HiraganaLabel.AutoSize = true;
            this.HiraganaLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HiraganaLabel.Location = new System.Drawing.Point(66, 222);
            this.HiraganaLabel.Name = "HiraganaLabel";
            this.HiraganaLabel.Size = new System.Drawing.Size(125, 37);
            this.HiraganaLabel.TabIndex = 2;
            this.HiraganaLabel.Text = "Hiragana";
            // 
            // JapaneseLabel2
            // 
            this.JapaneseLabel2.AutoSize = true;
            this.JapaneseLabel2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JapaneseLabel2.Location = new System.Drawing.Point(199, 83);
            this.JapaneseLabel2.Name = "JapaneseLabel2";
            this.JapaneseLabel2.Size = new System.Drawing.Size(407, 40);
            this.JapaneseLabel2.TabIndex = 1;
            this.JapaneseLabel2.Text = "We recommend Hiragana first!";
            // 
            // JapaneseLabel1
            // 
            this.JapaneseLabel1.AutoSize = true;
            this.JapaneseLabel1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JapaneseLabel1.Location = new System.Drawing.Point(100, 21);
            this.JapaneseLabel1.Name = "JapaneseLabel1";
            this.JapaneseLabel1.Size = new System.Drawing.Size(658, 40);
            this.JapaneseLabel1.TabIndex = 0;
            this.JapaneseLabel1.Text = "With Japanese there are different writting systems.";
            // 
            // BulgarianButton
            // 
            this.BulgarianButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BulgarianButton.Location = new System.Drawing.Point(472, 310);
            this.BulgarianButton.Name = "BulgarianButton";
            this.BulgarianButton.Size = new System.Drawing.Size(158, 52);
            this.BulgarianButton.TabIndex = 5;
            this.BulgarianButton.Text = "Start Learning!";
            this.BulgarianButton.UseVisualStyleBackColor = true;
            this.BulgarianButton.Click += new System.EventHandler(this.BulgarianButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JapanesePanel);
            this.Controls.Add(this.JapaneseButton);
            this.Controls.Add(this.JapaneseLabel);
            this.Controls.Add(this.MoreComingLabel);
            this.Controls.Add(this.MainMenuText);
            this.Controls.Add(this.BulgarianButton);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.JapanesePanel.ResumeLayout(false);
            this.JapanesePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenuText;
        private System.Windows.Forms.Label MoreComingLabel;
        private System.Windows.Forms.Label JapaneseLabel;
        private System.Windows.Forms.Button JapaneseButton;
        private System.Windows.Forms.Panel JapanesePanel;
        private System.Windows.Forms.Label KanjiLabel;
        private System.Windows.Forms.Label ComingSoonLabel1;
        private System.Windows.Forms.Label KatakanaLabel;
        private System.Windows.Forms.Button HiraganaButton;
        private System.Windows.Forms.Label HiraganaLabel;
        private System.Windows.Forms.Label JapaneseLabel2;
        private System.Windows.Forms.Label JapaneseLabel1;
        private System.Windows.Forms.Button KanjiButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button BulgarianButton;
    }
}