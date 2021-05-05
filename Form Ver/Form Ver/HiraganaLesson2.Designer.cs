
namespace Form_Ver
{
    partial class HiraganaLesson2
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel1BackButton = new System.Windows.Forms.Button();
            this.Panel1NextButton = new System.Windows.Forms.Button();
            this.Panel1Label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Panel1Label1);
            this.Panel1.Controls.Add(this.Panel1NextButton);
            this.Panel1.Controls.Add(this.Panel1BackButton);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(800, 450);
            this.Panel1.TabIndex = 0;
            // 
            // Panel1BackButton
            // 
            this.Panel1BackButton.Location = new System.Drawing.Point(12, 392);
            this.Panel1BackButton.Name = "Panel1BackButton";
            this.Panel1BackButton.Size = new System.Drawing.Size(92, 32);
            this.Panel1BackButton.TabIndex = 0;
            this.Panel1BackButton.Text = "Back";
            this.Panel1BackButton.UseVisualStyleBackColor = true;
            // 
            // Panel1NextButton
            // 
            this.Panel1NextButton.Location = new System.Drawing.Point(687, 392);
            this.Panel1NextButton.Name = "Panel1NextButton";
            this.Panel1NextButton.Size = new System.Drawing.Size(92, 32);
            this.Panel1NextButton.TabIndex = 1;
            this.Panel1NextButton.Text = "Next";
            this.Panel1NextButton.UseVisualStyleBackColor = true;
            // 
            // Panel1Label1
            // 
            this.Panel1Label1.AutoSize = true;
            this.Panel1Label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Panel1Label1.Location = new System.Drawing.Point(195, 36);
            this.Panel1Label1.Name = "Panel1Label1";
            this.Panel1Label1.Size = new System.Drawing.Size(419, 64);
            this.Panel1Label1.TabIndex = 2;
            this.Panel1Label1.Text = "We are going to learn the 5 K sounds \r\nand the S\'s Sounds";
            // 
            // HiraganaLesson2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel1);
            this.Name = "HiraganaLesson2";
            this.Text = "HiraganaLesson2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HiraganaLesson2_FormClosed);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label Panel1Label1;
        private System.Windows.Forms.Button Panel1NextButton;
        private System.Windows.Forms.Button Panel1BackButton;
    }
}