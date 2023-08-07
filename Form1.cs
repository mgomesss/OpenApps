using System.Diagnostics;

namespace OpenApps
{
    public partial class Form1 : Form
    {
        string filePath = "savedFiles.txt";

        public Form1()
        {
            InitializeComponent();
            LoadSavedFiles();
        }

        private void LoadSavedFiles()
        {
            if (File.Exists(filePath))
            {
                string[] savedFiles = File.ReadAllLines(filePath);
                foreach (string file in savedFiles)
                {
                    string fileName = Path.GetFileName(file);
                    var item = new ListViewItem(new[] { fileName, file });
                    listViewFiles.Items.Add(item);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    string fileName = Path.GetFileName(file);
                    var item = new ListViewItem(new[] { fileName, file });
                    listViewFiles.Items.Add(item);
                    File.AppendAllText(filePath, file + Environment.NewLine);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count > 0)
            {
                string selectedItemPath = listViewFiles.SelectedItems[0].SubItems[1].Text;
                listViewFiles.Items.Remove(listViewFiles.SelectedItems[0]);
                string[] currentLines = File.ReadAllLines(filePath);
                File.WriteAllLines(filePath, Array.FindAll(currentLines, line => line != selectedItemPath));
            }
        }

        private void btnOpenAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewFiles.Items)
            {
                try
                {
                    string filePath = item.SubItems[1].Text;
                    Process.Start(new ProcessStartInfo()
                    {
                        FileName = "cmd",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        Arguments = "/c start \"\" \"" + filePath + "\""
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao abrir o arquivo: " + ex.Message);
                }
            }
        }

    }
}
