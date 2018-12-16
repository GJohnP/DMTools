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
            this.SaveText_b = new System.Windows.Forms.Button();
            this.LoadText_b = new System.Windows.Forms.Button();
            this.Text_rtb = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.File_cb = new System.Windows.Forms.ComboBox();
            this.Folder_cb = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage1.Controls.Add(this.SaveText_b);
            this.tabPage1.Controls.Add(this.LoadText_b);
            this.tabPage1.Controls.Add(this.Text_rtb);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.File_cb);
            this.tabPage1.Controls.Add(this.Folder_cb);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directory";
            // 
            // File_cb
            // 
            this.File_cb.FormattingEnabled = true;
            this.File_cb.Location = new System.Drawing.Point(73, 34);
            this.File_cb.Name = "File_cb";
            this.File_cb.Size = new System.Drawing.Size(231, 21);
            this.File_cb.TabIndex = 1;
            // 
            // Folder_cb
            // 
            this.Folder_cb.FormattingEnabled = true;
            this.Folder_cb.Location = new System.Drawing.Point(73, 6);
            this.Folder_cb.Name = "Folder_cb";
            this.Folder_cb.Size = new System.Drawing.Size(231, 21);
            this.Folder_cb.TabIndex = 0;
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
        private System.Windows.Forms.ComboBox Folder_cb;
        private System.Windows.Forms.ComboBox File_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Text_rtb;
        private System.Windows.Forms.Button SaveText_b;
        private System.Windows.Forms.Button LoadText_b;
    }
}

