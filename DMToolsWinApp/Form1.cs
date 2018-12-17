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
using System.Configuration;

using Logic;
using System.Data.SqlClient;

/*
 * Need to change the Folder and File combo boxes to be something more like Campaign and Note ID
 */

namespace DMToolsWinApp
{
    public partial class Form1 : Form
    {
        Logic.TextFileManager TxtFileMan;
        string FullFilePath;
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        List<DMNote> GlobalNotes = new List<DMNote>();

        public Form1()
        {
            List<string> output = new List<string>();
            InitializeComponent();
            List<string> campIDs = new List<string>();

            string campQuery = "SELECT * FROM dbo.Campaign";
            string noteQuery = "SELECT * FROM dbo.Note WHERE CampaignID = 1";
            using (var conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(campQuery, conn);
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        campIDs.Add(reader["ID"].ToString());
                    }
                }
                finally
                {
                    reader.Close();
                }

                command = new SqlCommand(noteQuery, conn);
                reader = command.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        output.Add(reader["Id"] + "\t" + reader["Text"]);
                        GlobalNotes.Add(new DMNote(Convert.ToInt32(reader["ID"].ToString()), Convert.ToInt32(reader["CampaignID"]), reader["Text"].ToString(), reader["Title"].ToString()));
                    }
                }
                finally
                {
                    reader.Close();
                }
            }



            //init folderlist
            //var temp = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Campaign_cb.DataSource = campIDs;
            Note_cb.DataSource = GlobalNotes.Select(n => n.ID.ToString() + "\t" + n.Title).ToList();

            //UpdateFolderList(temp);
            //UpdateFileList();
        }

        private void UpdateFullFilePath()
        {
            FullFilePath = Campaign_cb.Text + @"\" + Note_cb.Text;
        }

        private bool IsTextEditorDifferent()
        {
            string fileText = TxtFileMan.ReadFromFile();
            string editorText = Text_rtb.Text;
            return fileText != editorText;
        }

        private void UpdateNoteCB()
        {
            GlobalNotes = new List<DMNote>();

            int campID = Convert.ToInt32(Campaign_cb.SelectedValue);

            string noteQuery = string.Format("SELECT * FROM dbo.Note WHERE CampaignID = {0}", campID);
            using (var conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(noteQuery, conn);
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        GlobalNotes.Add(new DMNote(Convert.ToInt32(reader["ID"].ToString()), Convert.ToInt32(reader["CampaignID"]), reader["Text"].ToString(), reader["Title"].ToString()));
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            Note_cb.DataSource = GlobalNotes.Select(n => n.ID.ToString() + "\t" + n.Title).ToList();
        }

        private void LoadText_b_Click(object sender, EventArgs e)
        {
            //UpdateFullFilePath();
            //TxtFileMan = new TextFileManager(FullFilePath);
            //string tempText = TxtFileMan.ReadFromFile();
            //Text_rtb.Text = tempText;

            string tempText = GlobalNotes.Where(n => n.ID == Convert.ToInt32(Campaign_cb.SelectedValue)).FirstOrDefault()?.Text;
            Text_rtb.Text = tempText;
        }

        private void SaveText_b_Click(object sender, EventArgs e)
        {
            //UpdateFullFilePath();
            //TxtFileMan = new TextFileManager(FullFilePath);
            //string tempText = Text_rtb.Text;

            ////Are there actually changes to save?
            //if (IsTextEditorDifferent())
            //{
            //    TxtFileMan.WriteToFile(tempText);
            //}
        }

        private void Campaign_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if there are changes in the file editor and prompt to save
            //checking here so that we can preemptively change the fullfilepath
            //instead of reactively

            //update the note combobox
            UpdateNoteCB();
        }

        private void Note_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //auto load the doc or no?
        }

        private void BrowseFolder_b_Click(object sender, EventArgs e)
        {
            //if (FolderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string tempPath = FolderBrowser.SelectedPath;
            //    //update folder list
            //    UpdateFolderList(tempPath);
            //}
        }
    }
}
