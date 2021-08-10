namespace GitCmd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGit = new System.Windows.Forms.Button();
            this.textBoxGitPara = new System.Windows.Forms.TextBox();
            this.textBoxGitDir = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxOnlyChanges = new System.Windows.Forms.CheckBox();
            this.textBoxGitCmd = new System.Windows.Forms.TextBox();
            this.comboBoxPara = new System.Windows.Forms.ComboBox();
            this.checkedListBoxGitDir = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStripCheckedListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(3, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonGit
            // 
            this.buttonGit.Location = new System.Drawing.Point(84, 3);
            this.buttonGit.Name = "buttonGit";
            this.buttonGit.Size = new System.Drawing.Size(75, 23);
            this.buttonGit.TabIndex = 1;
            this.buttonGit.Text = "Git";
            this.buttonGit.UseVisualStyleBackColor = true;
            this.buttonGit.Click += new System.EventHandler(this.buttonGit_Click);
            // 
            // textBoxGitPara
            // 
            this.textBoxGitPara.Location = new System.Drawing.Point(534, 5);
            this.textBoxGitPara.Name = "textBoxGitPara";
            this.textBoxGitPara.Size = new System.Drawing.Size(133, 20);
            this.textBoxGitPara.TabIndex = 2;
            // 
            // textBoxGitDir
            // 
            this.textBoxGitDir.Location = new System.Drawing.Point(165, 5);
            this.textBoxGitDir.Name = "textBoxGitDir";
            this.textBoxGitDir.Size = new System.Drawing.Size(261, 20);
            this.textBoxGitDir.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(14, 12);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(441, 56);
            this.textBoxResult.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxOnlyChanges);
            this.panel1.Controls.Add(this.textBoxGitCmd);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonGit);
            this.panel1.Controls.Add(this.textBoxGitDir);
            this.panel1.Controls.Add(this.textBoxGitPara);
            this.panel1.Controls.Add(this.comboBoxPara);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 30);
            this.panel1.TabIndex = 5;
            // 
            // checkBoxOnlyChanges
            // 
            this.checkBoxOnlyChanges.AutoSize = true;
            this.checkBoxOnlyChanges.Location = new System.Drawing.Point(689, 7);
            this.checkBoxOnlyChanges.Name = "checkBoxOnlyChanges";
            this.checkBoxOnlyChanges.Size = new System.Drawing.Size(102, 17);
            this.checkBoxOnlyChanges.TabIndex = 6;
            this.checkBoxOnlyChanges.Text = "nur Änderungen";
            this.checkBoxOnlyChanges.UseVisualStyleBackColor = true;
            // 
            // textBoxGitCmd
            // 
            this.textBoxGitCmd.Location = new System.Drawing.Point(432, 5);
            this.textBoxGitCmd.Name = "textBoxGitCmd";
            this.textBoxGitCmd.Size = new System.Drawing.Size(96, 20);
            this.textBoxGitCmd.TabIndex = 4;
            // 
            // comboBoxPara
            // 
            this.comboBoxPara.FormattingEnabled = true;
            this.comboBoxPara.Location = new System.Drawing.Point(534, 5);
            this.comboBoxPara.Name = "comboBoxPara";
            this.comboBoxPara.Size = new System.Drawing.Size(149, 21);
            this.comboBoxPara.TabIndex = 7;
            this.comboBoxPara.SelectedIndexChanged += new System.EventHandler(this.comboBoxPara_SelectedIndexChanged);
            // 
            // checkedListBoxGitDir
            // 
            this.checkedListBoxGitDir.ContextMenuStrip = this.contextMenuStripCheckedListBox;
            this.checkedListBoxGitDir.FormattingEnabled = true;
            this.checkedListBoxGitDir.IntegralHeight = false;
            this.checkedListBoxGitDir.Location = new System.Drawing.Point(14, 15);
            this.checkedListBoxGitDir.Name = "checkedListBoxGitDir";
            this.checkedListBoxGitDir.Size = new System.Drawing.Size(441, 79);
            this.checkedListBoxGitDir.TabIndex = 5;
            // 
            // contextMenuStripCheckedListBox
            // 
            this.contextMenuStripCheckedListBox.Name = "contextMenuStripCheckedListBox";
            this.contextMenuStripCheckedListBox.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripCheckedListBox.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuStripCheckedListBox_Closing);
            this.contextMenuStripCheckedListBox.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripCheckedListBox_Opening);
            this.contextMenuStripCheckedListBox.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripCheckedListBox_ItemClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(798, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Location = new System.Drawing.Point(12, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 325);
            this.panel2.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(17, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBoxGitDir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxResult);
            this.splitContainer1.Size = new System.Drawing.Size(473, 295);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "GitCmd";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseMove);
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripNotifyIcon.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripNotifyIcon_Opening);
            this.contextMenuStripNotifyIcon.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripNotifyIcon_ItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 394);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GitCmd";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonGit;
        private System.Windows.Forms.TextBox textBoxGitPara;
        private System.Windows.Forms.TextBox textBoxGitDir;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxGitCmd;
        private System.Windows.Forms.CheckedListBox checkedListBoxGitDir;
        private System.Windows.Forms.CheckBox checkBoxOnlyChanges;
        private System.Windows.Forms.ComboBox comboBoxPara;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCheckedListBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
    }
}

