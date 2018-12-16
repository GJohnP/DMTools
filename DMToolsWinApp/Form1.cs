using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Logic;

namespace DMToolsWinApp
{
    public partial class Form1 : Form
    {
        Logic.TextFileManager TxtFileMan;
        string FullFilePath;

        public Form1()
        {

            InitializeComponent();
            //init folderlist
            var temp = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            UpdateFolderList(temp);
            UpdateFileList();
        }

        private void UpdateFullFilePath()
        {
            FullFilePath = Folder_cb.Text + @"\" + File_cb.Text;
        }

        private bool IsTextEditorDifferent()
        {
            string fileText = TxtFileMan.ReadFromFile();
            string editorText = Text_rtb.Text;
            return fileText != editorText;
        }
        
        private void UpdateFolderList(string input)
        {
            List<string> folders = new List<string> { input };
            folders.AddRange(Directory.GetDirectories(input).ToList());
            Folder_cb.DataSource = folders;
            if (folders.Count() != 0)
            {
                Folder_cb.SelectedIndex = 0;
            }
        }

        private void UpdateFileList()
        {
            string folder = Folder_cb.Text;
            string[] txtfiles = Directory.GetFiles(folder, "*.txt").Select(fi => Path.GetFileName(fi)).ToArray();
            File_cb.DataSource = txtfiles;
            if (txtfiles.Length != 0)
            {
                File_cb.SelectedIndex = 0;
            }
        }

        private void LoadText_b_Click(object sender, EventArgs e)
        {
            UpdateFullFilePath();
            TxtFileMan = new TextFileManager(FullFilePath);
            string tempText = TxtFileMan.ReadFromFile();
            Text_rtb.Text = tempText;
        }

        private void SaveText_b_Click(object sender, EventArgs e)
        {
            UpdateFullFilePath();
            TxtFileMan = new TextFileManager(FullFilePath);
            string tempText = Text_rtb.Text;

            //Are there actually changes to save?
            if (IsTextEditorDifferent())
            {
                TxtFileMan.WriteToFile(tempText);
            }
        }

        private void Folder_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if there are changes in the file editor and prompt to save
            //checking here so that we can preemptively change the fullfilepath
            //instead of reactively

            //update the file combobox
            UpdateFileList();
        }

        private void File_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //auto load the doc or no?
        }

        private void BrowseFolder_b_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string tempPath = FolderBrowser.SelectedPath;
                //update folder list
                UpdateFolderList(tempPath);
            }
        }
    }
}
