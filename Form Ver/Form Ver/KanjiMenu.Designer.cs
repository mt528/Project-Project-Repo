
namespace Form_Ver
{
    partial class KanjiMenu
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
            this.KanjiMenuLabel1 = new System.Windows.Forms.Label();
            this.KanjiMenuLesson1Button = new System.Windows.Forms.Button();
            this.KanjiMenuLesson1 = new System.Windows.Forms.Label();
            this.KanjiMenuLesson2 = new System.Windows.Forms.Label();
            this.KanjiMenuLesson2Button = new System.Windows.Forms.Button();
            this.KanjiMenuGoBackButton = new System.Windows.Forms.Button();
            this.KanjiMenuTestLabel = new System.Windows.Forms.Label();
            this.KanjiMenuTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KanjiMenuLabel1
            // 
            this.KanjiMenuLabel1.AutoSize = true;
            this.KanjiMenuLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiMenuLabel1.Location = new System.Drawing.Point(190, 22);
            this.KanjiMenuLabel1.Name = "KanjiMenuLabel1";
            this.KanjiMenuLabel1.Size = new System.Drawing.Size(449, 64);
            this.KanjiMenuLabel1.TabIndex = 0;
            this.KanjiMenuLabel1.Text = "Here are the lessons to learn some Kanji,\r\npick one!";
            this.KanjiMenuLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KanjiMenuLesson1Button
            // 
            this.KanjiMenuLesson1Button.Location = new System.Drawing.Point(124, 193);
            this.KanjiMenuLesson1Button.Name = "KanjiMenuLesson1Button";
            this.KanjiMenuLesson1Button.Size = new System.Drawing.Size(93, 32);
            this.KanjiMenuLesson1Button.TabIndex = 1;
            this.KanjiMenuLesson1Button.Text = "Start";
            this.KanjiMenuLesson1Button.UseVisualStyleBackColor = true;
            this.KanjiMenuLesson1Button.Click += new System.EventHandler(this.KanjiMenuLesson1Button_Click);
            // 
            // KanjiMenuLesson1
            // 
            this.KanjiMenuLesson1.AutoSize = true;
            this.KanjiMenuLesson1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiMenuLesson1.Location = new System.Drawing.Point(12, 188);
            this.KanjiMenuLesson1.Name = "KanjiMenuLesson1";
            this.KanjiMenuLesson1.Size = new System.Drawing.Size(106, 32);
            this.KanjiMenuLesson1.TabIndex = 2;
            this.KanjiMenuLesson1.Text = "Lesson 1";
            // 
            // KanjiMenuLesson2
            // 
            this.KanjiMenuLesson2.AutoSize = true;
            this.KanjiMenuLesson2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiMenuLesson2.Location = new System.Drawing.Point(12, 247);
            this.KanjiMenuLesson2.Name = "KanjiMenuLesson2";
            this.KanjiMenuLesson2.Size = new System.Drawing.Size(106, 32);
            this.KanjiMenuLesson2.TabIndex = 4;
            this.KanjiMenuLesson2.Text = "Lesson 2";
            // 
            // KanjiMenuLesson2Button
            // 
            this.KanjiMenuLesson2Button.Location = new System.Drawing.Point(124, 252);
            this.KanjiMenuLesson2Button.Name = "KanjiMenuLesson2Button";
            this.KanjiMenuLesson2Button.Size = new System.Drawing.Size(93, 32);
            this.KanjiMenuLesson2Button.TabIndex = 3;
            this.KanjiMenuLesson2Button.Text = "Not Finished";
            this.KanjiMenuLesson2Button.UseVisualStyleBackColor = true;
            this.KanjiMenuLesson2Button.Click += new System.EventHandler(this.KanjiMenuLesson2Button_Click);
            // 
            // KanjiMenuGoBackButton
            // 
            this.KanjiMenuGoBackButton.Location = new System.Drawing.Point(25, 391);
            this.KanjiMenuGoBackButton.Name = "KanjiMenuGoBackButton";
            this.KanjiMenuGoBackButton.Size = new System.Drawing.Size(93, 32);
            this.KanjiMenuGoBackButton.TabIndex = 5;
            this.KanjiMenuGoBackButton.Text = "Go Back";
            this.KanjiMenuGoBackButton.UseVisualStyleBackColor = true;
            this.KanjiMenuGoBackButton.Click += new System.EventHandler(this.KanjiMenuGoBackButton_Click);
            // 
            // KanjiMenuTestLabel
            // 
            this.KanjiMenuTestLabel.AutoSize = true;
            this.KanjiMenuTestLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KanjiMenuTestLabel.Location = new System.Drawing.Point(332, 346);
            this.KanjiMenuTestLabel.Name = "KanjiMenuTestLabel";
            this.KanjiMenuTestLabel.Size = new System.Drawing.Size(124, 32);
            this.KanjiMenuTestLabel.TabIndex = 7;
            this.KanjiMenuTestLabel.Text = "Recall Test";
            // 
            // KanjiMenuTestButton
            // 
            this.KanjiMenuTestButton.Location = new System.Drawing.Point(347, 391);
            this.KanjiMenuTestButton.Name = "KanjiMenuTestButton";
            this.KanjiMenuTestButton.Size = new System.Drawing.Size(93, 32);
            this.KanjiMenuTestButton.TabIndex = 6;
            this.KanjiMenuTestButton.Text = "Start";
            this.KanjiMenuTestButton.UseVisualStyleBackColor = true;
            this.KanjiMenuTestButton.Click += new System.EventHandler(this.KanjiMenuTestButton_Click);
            // 
            // KanjiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KanjiMenuTestLabel);
            this.Controls.Add(this.KanjiMenuTestButton);
            this.Controls.Add(this.KanjiMenuGoBackButton);
            this.Controls.Add(this.KanjiMenuLesson2);
            this.Controls.Add(this.KanjiMenuLesson2Button);
            this.Controls.Add(this.KanjiMenuLesson1);
            this.Controls.Add(this.KanjiMenuLesson1Button);
            this.Controls.Add(this.KanjiMenuLabel1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "KanjiMenu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KanjiMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KanjiMenuLabel1;
        private System.Windows.Forms.Button KanjiMenuLesson1Button;
        private System.Windows.Forms.Label KanjiMenuLesson1;
        private System.Windows.Forms.Label KanjiMenuLesson2;
        private System.Windows.Forms.Button KanjiMenuLesson2Button;
        private System.Windows.Forms.Button KanjiMenuGoBackButton;
        private System.Windows.Forms.Label KanjiMenuTestLabel;
        private System.Windows.Forms.Button KanjiMenuTestButton;
    }
}