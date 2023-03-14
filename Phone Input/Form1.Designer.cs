namespace Phone_Input
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
            randomTextBox = new TextBox();
            randomButton = new Button();
            SuspendLayout();
            // 
            // randomTextBox
            // 
            randomTextBox.Location = new Point(12, 12);
            randomTextBox.Name = "randomTextBox";
            randomTextBox.Size = new Size(176, 23);
            randomTextBox.TabIndex = 0;
            // 
            // randomButton
            // 
            randomButton.Location = new Point(12, 41);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(176, 23);
            randomButton.TabIndex = 1;
            randomButton.Text = "Random";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(randomButton);
            Controls.Add(randomTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox randomTextBox;
        private Button randomButton;
    }
}