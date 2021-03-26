
namespace Form_Ver
{
    partial class IntroductionForm
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
            this.IntroductionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IntroductionButton
            // 
            this.IntroductionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntroductionButton.Location = new System.Drawing.Point(290, 328);
            this.IntroductionButton.Name = "IntroductionButton";
            this.IntroductionButton.Size = new System.Drawing.Size(200, 57);
            this.IntroductionButton.TabIndex = 0;
            this.IntroductionButton.Text = "Continue";
            this.IntroductionButton.UseVisualStyleBackColor = true;
            this.IntroductionButton.Click += new System.EventHandler(this.IntroductionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hi there! \r\nThis is a game that will help you learn a language!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IntroductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IntroductionButton);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "IntroductionForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IntroductionForm_FormClosed);
            this.Load += new System.EventHandler(this.IntroductionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IntroductionButton;
        private System.Windows.Forms.Label label1;
    }
}

