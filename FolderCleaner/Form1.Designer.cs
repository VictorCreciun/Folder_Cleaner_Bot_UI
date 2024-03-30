namespace FolderCleaner
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            startButton = new Button();
            cancelButton = new Button();
            pathBox = new TextBox();
            browseButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 37);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Insert Path:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 136);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 1;
            label2.Text = "Select Date and Time:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 23);
            textBox1.TabIndex = 2;
            // 
            // startButton
            // 
            startButton.Location = new Point(688, 406);
            startButton.Name = "startButton";
            startButton.Size = new Size(83, 21);
            startButton.TabIndex = 3;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(589, 406);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(83, 21);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // pathBox
            // 
            pathBox.Location = new Point(227, 34);
            pathBox.Name = "pathBox";
            pathBox.Size = new Size(235, 23);
            pathBox.TabIndex = 5;
            // 
            // browseButton
            // 
            browseButton.AccessibleRole = AccessibleRole.Dialog;
            browseButton.BackColor = Color.Transparent;
            browseButton.Location = new Point(227, 63);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(102, 24);
            browseButton.TabIndex = 6;
            browseButton.Text = "Browse Folder";
            browseButton.UseVisualStyleBackColor = false;
            browseButton.Click += browseButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(browseButton);
            Controls.Add(pathBox);
            Controls.Add(cancelButton);
            Controls.Add(startButton);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Vitek -_-";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button startButton;
        private Button cancelButton;
        private TextBox pathBox;
        private Button browseButton;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
