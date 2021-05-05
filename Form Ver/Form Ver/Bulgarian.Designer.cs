
namespace Form_Ver
{
    partial class Bulgarian
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
            this.BulgarianInputTextBox = new System.Windows.Forms.RichTextBox();
            this.BulgarianTextBox = new System.Windows.Forms.RichTextBox();
            this.BulgarianBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BulgarianInputTextBox
            // 
            this.BulgarianInputTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.BulgarianInputTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BulgarianInputTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.BulgarianInputTextBox.Location = new System.Drawing.Point(431, 393);
            this.BulgarianInputTextBox.Name = "BulgarianInputTextBox";
            this.BulgarianInputTextBox.Size = new System.Drawing.Size(357, 43);
            this.BulgarianInputTextBox.TabIndex = 12;
            this.BulgarianInputTextBox.Text = "";
            this.BulgarianInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BulgarianInputTextBox_KeyDown);
            // 
            // BulgarianTextBox
            // 
            this.BulgarianTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.BulgarianTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BulgarianTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.BulgarianTextBox.Location = new System.Drawing.Point(0, 6);
            this.BulgarianTextBox.Name = "BulgarianTextBox";
            this.BulgarianTextBox.ReadOnly = true;
            this.BulgarianTextBox.Size = new System.Drawing.Size(800, 304);
            this.BulgarianTextBox.TabIndex = 14;
            this.BulgarianTextBox.Text = "";
            // 
            // BulgarianBackButton
            // 
            this.BulgarianBackButton.Location = new System.Drawing.Point(24, 402);
            this.BulgarianBackButton.Name = "BulgarianBackButton";
            this.BulgarianBackButton.Size = new System.Drawing.Size(131, 42);
            this.BulgarianBackButton.TabIndex = 13;
            this.BulgarianBackButton.Text = "Go Back";
            this.BulgarianBackButton.UseVisualStyleBackColor = true;
            this.BulgarianBackButton.Click += new System.EventHandler(this.BulgarianBackButton_Click);
            // 
            // Bulgarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BulgarianInputTextBox);
            this.Controls.Add(this.BulgarianTextBox);
            this.Controls.Add(this.BulgarianBackButton);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "Bulgarian";
            this.Text = "Bulgarian";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bulgarian_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox BulgarianInputTextBox;
        private System.Windows.Forms.RichTextBox BulgarianTextBox;
        private System.Windows.Forms.Button BulgarianBackButton;
    }
}