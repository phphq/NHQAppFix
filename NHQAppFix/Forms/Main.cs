using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

using NHQAppFix.Classes;
using NHQAppFix.Properties;
// ReSharper disable EmptyGeneralCatchClause

namespace NHQAppFix.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        void Main_Load(object sender, EventArgs e)
        {

            Text = Config.ProgramName + " v" + Config.ProgramVersion;

            pbNovaHQ.Image = Resources.NovaHQ;
            new ToolTip().SetToolTip(pbNovaHQ, "Visit NovaHQ!");

            btnInstall.Enabled = false;

            if (!Config.ProgramDebug)
                Config.AppFixDict.Remove("test.sdb");

            cbAppFixList.DataSource = new BindingSource(Config.AppFixDict, null);
            cbAppFixList.DisplayMember = "Value";
            cbAppFixList.ValueMember = "Key";

        }

        void pbNovaHQ_Click(object sender, EventArgs e)
        {
            Common.GoToNovaHq();
        }

        void btnInstall_Click(object sender, EventArgs e)
        {

            var tempPath = Path.GetTempPath();
            var selectedFix = ((KeyValuePair<string, string>) cbAppFixList.SelectedItem).Key;

            if (string.IsNullOrEmpty(selectedFix) || !Config.AppFixDict.ContainsKey(selectedFix))
            {
                MessageBox.Show("Could not find database for selected item!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                cbAppFixList.SelectedIndex = 0;

                return;
            }


            switch (selectedFix)
            {
                case "df1.sdb":
                    File.WriteAllBytes(Path.Combine(tempPath, selectedFix), Resources.df1);
                    break;
                case "lw.sdb":
                    File.WriteAllBytes(Path.Combine(tempPath, selectedFix), Resources.lw);
                    break;
                case "tfd.sdb":
                    File.WriteAllBytes(Path.Combine(tempPath, selectedFix), Resources.tfd);
                    break;
                case "med.sdb":
                    File.WriteAllBytes(Path.Combine(tempPath, selectedFix), Resources.med);
                    break;
                case "test.sdb":
                    File.WriteAllBytes(Path.Combine(tempPath, selectedFix), Resources.test);
                    break;
            }

            if (!File.Exists(Path.Combine(tempPath, selectedFix)))
            {
                MessageBox.Show("Could not load database for selected item!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                cbAppFixList.SelectedIndex = 0;
                return;
            }

            var p = new Process
            {
                StartInfo =
                {
                    FileName = "sdbinst.exe",
                    WorkingDirectory = tempPath,
                    Arguments = " -q " + selectedFix,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }

            };

            p.Start();
            var output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            //TODO: Other languages besides english?

            if (output.IndexOf("complete", StringComparison.InvariantCultureIgnoreCase) > -1)
            {

                MessageBox.Show(
                    output + Environment.NewLine +
                    "To uninstall this database, use the Add / Remove Programs control panel item in Windows.",
                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (output.IndexOf("error", StringComparison.InvariantCultureIgnoreCase) > -1)
            {

                MessageBox.Show(output + Environment.NewLine + "Please help by reporting this message to NovaHQ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(output, "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                File.Delete(Path.Combine(tempPath, selectedFix));
            }
            catch { }

            cbAppFixList.SelectedIndex = 0;

        }

        void cbAppFixList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFix = ((KeyValuePair<string, string>)cbAppFixList.SelectedItem).Key;

            if (selectedFix == "extract")
            {
                btnInstall.Enabled = false;
                ExtractFiles();
                cbAppFixList.SelectedIndex = 0;
                return;
            }
 
            btnInstall.Enabled = !string.IsNullOrEmpty(selectedFix);

        }

        void ExtractFiles()
        {
            var confirmExtract = MessageBox.Show(
                "This will extract the *.sdb files from this app so you can run them manually. " + Environment.NewLine + Environment.NewLine + "https://docs.microsoft.com/en-us/windows/deployment/planning/using-the-sdbinstexe-command-line-tool" + Environment.NewLine + Environment.NewLine + "Do you want to extract the files?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmExtract == DialogResult.No)
                return;

            using (var folderSelect = new FolderBrowserDialog())
            {
                var result = folderSelect.ShowDialog();

                if (result != DialogResult.OK || string.IsNullOrWhiteSpace(folderSelect.SelectedPath))
                    return;

                foreach (var sdbFixDict in Config.AppFixDict)
                {
                    if (string.IsNullOrEmpty(sdbFixDict.Key) || sdbFixDict.Key.Contains("test"))
                        continue;

                    switch (sdbFixDict.Key)
                    {
                        case "df1.sdb":
                            File.WriteAllBytes(Path.Combine(folderSelect.SelectedPath, sdbFixDict.Key), Resources.df1);
                            break;

                        case "lw.sdb":
                            File.WriteAllBytes(Path.Combine(folderSelect.SelectedPath, sdbFixDict.Key), Resources.lw);
                            break;

                        case "tfd.sdb":
                            File.WriteAllBytes(Path.Combine(folderSelect.SelectedPath, sdbFixDict.Key), Resources.tfd);
                            break;

                        case "med.sdb":
                            File.WriteAllBytes(Path.Combine(folderSelect.SelectedPath, sdbFixDict.Key), Resources.med);
                            break;

                    }
                    
                }

                MessageBox.Show("The files were extract to: " + folderSelect.SelectedPath, "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void lblMedList_Click(object sender, EventArgs e)
        {
            Form f = new MedCompat();
            f.ShowDialog();
        }

    }

}