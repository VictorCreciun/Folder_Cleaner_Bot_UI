using System;
using System.IO;

namespace FolderCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pathBox.Text))
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*", SearchOption.AllDirectories);
                DateTime currentTime = DateTime.Now;
                Console.WriteLine(currentTime);

                foreach (var file in files)
                {
                    var fileInfo = new FileInfo(file);
                    Console.WriteLine($"{file} : {fileInfo.LastAccessTime}");

                    if (fileInfo.LastAccessTime < currentTime.AddMinutes(-1))
                    {
                        Console.WriteLine($"Deleting file {file}");
                        File.Delete(file);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, insert a path or use the browse button to select a directory path.", "Path Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
