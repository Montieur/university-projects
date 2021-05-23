using System;
using System.IO;
using System.Windows.Forms;
using TagLib;

namespace Odtwieracz
{
    public partial class FilePicker : Form
    {
        MainForm appRef;

        public FilePicker(MainForm x)
        {
            InitializeComponent();
            appRef = x;
            ShowDialog();
        }

        private void dirInit(string currentDir)
        {
            string[] names;
            try
            {
                names = Directory.GetDirectories(currentDir);
                getDirs(names);
                names = Directory.GetFiles(currentDir);
                getWaves(names);
            }
            catch (Exception)
            {
                dirTextBox.Text = dirTextBox.Text.Substring(0, dirTextBox.Text.Length - 1);
                dirTextBox.Text = dirTextBox.Text.Substring(0, dirTextBox.Text.LastIndexOf('\\') + 1);
                MessageBox.Show("Nie masz dostępu do tego folderu.");
            }
        }

        private void addButtonActivate()
        {
            if (listFiles.SelectedIndex == -1)
                addFileButton.Enabled = false;
            else
                addFileButton.Enabled = true;
        }

        private void getDirs(string[] arr)
        {
            listDirs.Items.Clear();
            listDirs.Items.Add("\\..");

            foreach (string path in arr)
                listDirs.Items.Add(path.Remove(0, path.LastIndexOf('\\') + 1) + '\\');       
        }

        private void getWaves(string[] arr)
        {
            listFiles.Items.Clear();

            foreach (string path in arr)
                if (path.EndsWith(".wav") || path.EndsWith(".mp3") || path.EndsWith(".flac") || path.EndsWith(".aiff") || path.EndsWith(".wma"))
                    listFiles.Items.Add(path.Remove(0, path.LastIndexOf('\\') + 1));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dirTextBox.Text = Directory.GetDirectoryRoot(Application.ExecutablePath);
            dirInit(dirTextBox.Text);
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            string filePath = dirTextBox.Text + listFiles.SelectedItem.ToString();
            appRef.AddTrack(filePath);
            Close();
        }

        

        private void listDirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDirs.SelectedIndex != 0)
            {
                dirTextBox.Text += listDirs.SelectedItem.ToString();
                dirInit(dirTextBox.Text);
                addButtonActivate();
            }
            else
            {
                if (dirTextBox.Text != Directory.GetDirectoryRoot(Application.ExecutablePath))
                {
                    dirInit(dirTextBox.Text + "\\..");
                    dirTextBox.Text = dirTextBox.Text.Substring(0, dirTextBox.Text.Length - 1);
                    dirTextBox.Text = dirTextBox.Text.Substring(0, dirTextBox.Text.LastIndexOf('\\') + 1);
                    addButtonActivate();
                }
            }
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            addButtonActivate();
        }

        

        
    }
}
