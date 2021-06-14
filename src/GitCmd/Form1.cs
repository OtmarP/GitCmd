using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitCmd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.toolStripStatusLabel1.Text = "";

            //------------------------------
            // So.13.06.2021 18:25:47 -op- nach GitHub
            // So.13.06.2021 14:36:29 -op- mit checkedListBoxGitDir
            // So.13.06.2021 14:14:09 -op- mit Sample RunCmd.cs ExecuteCurl()
            // Fr.04.06.2021 18:17:00 -op- Cr. FW 4.7.2
            //------------------------------
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = 50;

            this.Text = "GitCmd";

            this.textBoxGitDir.Text = @"C:\Dev\Git";
            this.textBoxGitCmd.Text = "git.exe";
            this.textBoxGitPara.Text = "status -s";
            //this.textBoxGitPara.Text = "count-objects -vH";

#if DEBUG
            this.Text += "   ***DEBUG***";
#endif

            this.comboBoxPara.Items.Clear();
            this.comboBoxPara.Items.Add("status");
            this.comboBoxPara.Items.Add("status -s");
            this.comboBoxPara.Items.Add("count-objects");
            this.comboBoxPara.Items.Add("count-objects -vH");
            this.comboBoxPara.Items.Add("");
            this.comboBoxPara.Text = this.textBoxGitPara.Text;

            this.InitListBox();

            this.panel2.Dock = DockStyle.Fill;
            this.textBoxResult.Dock = DockStyle.Fill;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Exit
            this.Close();
        }

        private void buttonGit_Click(object sender, EventArgs e)
        {
            this.RunGitCmd();
        }

        private void comboBoxPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxGitPara.Text = this.comboBoxPara.Text;
        }

        // ##############################
        // Functions
        // ##############################

        public void InitListBox()
        {
            // Read Config-File
            // 1="C:\Dev\Op\Git\Samples"
            // 2="C:\Dev\Projects\otmarp"

            string[] fileContent = new string[0];

            string computerName = Environment.MachineName;

            // GitListe.txt
            // GitListeOPMEDION14B.txt
            // GitListeOPTOSHIBA12B.txt
            List<string> files = new List<string>();
            files.Add("GitListe" + computerName + ".txt");
            files.Add("GitListe.txt");

            string contentOK = "";
            var exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            for (int i = 0; i < files.Count; i++)
            {
                var fullFileName = Path.Combine(exeDir, files[i]);
                if (this.CheckFile(fullFileName))
                {
                    try
                    {
                        fileContent = System.IO.File.ReadAllLines(fullFileName);
                        contentOK = fullFileName;
                        break;  //==========>
                    }
                    catch (Exception ex)
                    {
                        // this.toolStripStatusLabel1.Text = "Error: No File: " + fullFileName;
                    }
                }
            }

            if (contentOK != "")
            {
                this.toolStripStatusLabel1.Text = "File OK: " + contentOK;
            }
            else {
                this.toolStripStatusLabel1.Text = "no File: GitListe<COMPUTER>.txt, GitListe.txt";
            }

            checkedListBoxGitDir.Items.Clear();
            for (int i = 0; i < fileContent.Length; i++)
            {
                string line = fileContent[i];
                var split = line.Split('=');
                if (split.Length >= 2)
                {
                    var path = split[1];
                    path = path.Replace("\"", "");
                    if (path != "")
                    {
                        checkedListBoxGitDir.Items.Add(path);
                    }
                }
            }
            for (int i = 0; i < checkedListBoxGitDir.Items.Count; i++)
            {
                checkedListBoxGitDir.SetItemChecked(i, true);
            }
        }

        public bool CheckFile(string fileName)
        {
            bool ret = false;

            ret = System.IO.File.Exists(fileName);

            return ret;
        }

        public void RunGitCmd()
        {
            // Git
            // Change Dir
            // Command: git status -

            string resultAll = "";

            for (int i = 0; i < checkedListBoxGitDir.Items.Count; i++)
            {
                if (checkedListBoxGitDir.GetItemCheckState(i) == CheckState.Checked)
                {
                    string header1 = "";
                    string result1 = "";
                    string result2 = "";
                    string error1 = "";

                    string path = checkedListBoxGitDir.Items[i].ToString();
                    this.textBoxGitDir.Text = path;
                    Application.DoEvents();

                    if (System.IO.Directory.Exists(this.textBoxGitDir.Text))
                    {
                        header1 = (i + 1).ToString() + "/" + checkedListBoxGitDir.Items.Count.ToString() + ".) " + this.textBoxGitDir.Text;
                        try
                        {
                            //System.IO.Directory.SetCurrentDirectory(this.textBoxGitDir.Text);

                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                            // startInfo.WindowStyle
                            startInfo.FileName = "cmd.exe";
                            startInfo.Arguments = "/c " + this.textBoxGitCmd.Text + " " + this.textBoxGitPara.Text;
                            // The following commands are needed to redirect the standard output. 
                            //This means that it will be redirected to the Process.StandardOutput StreamReader.
                            startInfo.RedirectStandardOutput = true;
                            startInfo.RedirectStandardError = true;
                            // Do not create the black window.
                            startInfo.CreateNoWindow = true;
                            startInfo.UseShellExecute = false;
                            //startInfo.WorkingDirectory = Environment.SystemDirectory;
                            startInfo.WorkingDirectory = this.textBoxGitDir.Text;

                            // Now we create a process, assign its ProcessStartInfo and start it
                            process.StartInfo = startInfo;
                            process.Start();

                            //process.WaitForExit();

                            // Get the output into a string
                            result1 = process.StandardOutput.ReadToEnd();
                            error1 = process.StandardError.ReadToEnd();

                            // \n -> \r\n
                            result1 = result1.Replace("\n", "\r\n");
                            error1 = error1.Replace("\n", "\r\n");
                        }
                        catch (Exception ex)
                        {
                            error1 = "Error: " + ex;
                        }

                        if (result1 != "")
                        {
                            if (result2 != "") { result2 = result2 + "\r\n"; }
                            result2 = result2 + result1;
                        }
                        if (error1 != "")
                        {
                            if (result2 != "") { result2 = result2 + "\r\n"; }
                            result2 = result2 + error1;
                        }

                        if (result2 != "")
                        {
                            result2 = header1 + "\r\n" + result2;
                        }
                        else
                        {
                            if (!this.checkBoxOnlyChanges.Checked)
                            {
                                result2 = header1;
                            }
                        }
                    }

                    if (result2 != "")
                    {
                        if (resultAll != "")
                        {
                            resultAll = resultAll + "\r\n";
                        }
                        resultAll = resultAll + result2;
                    }
                }
            }

            // Display the command output.
            this.textBoxResult.Text = resultAll;
        }
    }
}
