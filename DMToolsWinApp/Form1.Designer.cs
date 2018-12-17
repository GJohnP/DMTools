namespace DMToolsWinApp
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BrowseFolder_b = new System.Windows.Forms.Button();
            this.SaveText_b = new System.Windows.Forms.Button();
            this.LoadText_b = new System.Windows.Forms.Button();
            this.Text_rtb = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Note_cb = new System.Windows.Forms.ComboBox();
            this.Campaign_cb = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(913, 506);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(913, 506);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BrowseFolder_b);
            this.tabPage1.Controls.Add(this.SaveText_b);
            this.tabPage1.Controls.Add(this.LoadText_b);
            this.tabPage1.Controls.Add(this.Text_rtb);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Note_cb);
            this.tabPage1.Controls.Add(this.Campaign_cb);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BrowseFolder_b
            // 
            this.BrowseFolder_b.Location = new System.Drawing.Point(311, 7);
            this.BrowseFolder_b.Name = "BrowseFolder_b";
            this.BrowseFolder_b.Size = new System.Drawing.Size(75, 23);
            this.BrowseFolder_b.TabIndex = 7;
            this.BrowseFolder_b.Text = "Browse";
            this.BrowseFolder_b.UseVisualStyleBackColor = true;
            this.BrowseFolder_b.Click += new System.EventHandler(this.BrowseFolder_b_Click);
            // 
            // SaveText_b
            // 
            this.SaveText_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveText_b.Location = new System.Drawing.Point(824, 32);
            this.SaveText_b.Name = "SaveText_b";
            this.SaveText_b.Size = new System.Drawing.Size(75, 23);
            this.SaveText_b.TabIndex = 6;
            this.SaveText_b.Text = "Save";
            this.SaveText_b.UseVisualStyleBackColor = true;
            this.SaveText_b.Click += new System.EventHandler(this.SaveText_b_Click);
            // 
            // LoadText_b
            // 
            this.LoadText_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadText_b.Location = new System.Drawing.Point(824, 4);
            this.LoadText_b.Name = "LoadText_b";
            this.LoadText_b.Size = new System.Drawing.Size(75, 23);
            this.LoadText_b.TabIndex = 5;
            this.LoadText_b.Text = "Load";
            this.LoadText_b.UseVisualStyleBackColor = true;
            this.LoadText_b.Click += new System.EventHandler(this.LoadText_b_Click);
            // 
            // Text_rtb
            // 
            this.Text_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_rtb.Location = new System.Drawing.Point(7, 61);
            this.Text_rtb.Name = "Text_rtb";
            this.Text_rtb.Size = new System.Drawing.Size(892, 411);
            this.Text_rtb.TabIndex = 4;
            this.Text_rtb.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Campaign";
            // 
            // Note_cb
            // 
            this.Note_cb.FormattingEnabled = true;
            this.Note_cb.Location = new System.Drawing.Point(73, 34);
            this.Note_cb.Name = "Note_cb";
            this.Note_cb.Size = new System.Drawing.Size(231, 21);
            this.Note_cb.TabIndex = 1;
            this.Note_cb.SelectedIndexChanged += new System.EventHandler(this.Note_cb_SelectedIndexChanged);
            // 
            // Campaign_cb
            // 
            this.Campaign_cb.FormattingEnabled = true;
            this.Campaign_cb.Location = new System.Drawing.Point(73, 6);
            this.Campaign_cb.Name = "Campaign_cb";
            this.Campaign_cb.Size = new System.Drawing.Size(231, 21);
            this.Campaign_cb.TabIndex = 0;
            this.Campaign_cb.SelectedIndexChanged += new System.EventHandler(this.Campaign_cb_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 506);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Campaign_cb;
        private System.Windows.Forms.ComboBox Note_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Text_rtb;
        private System.Windows.Forms.Button SaveText_b;
        private System.Windows.Forms.Button LoadText_b;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Button BrowseFolder_b;
    }
}

