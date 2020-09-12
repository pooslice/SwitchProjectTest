using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace SwitchProjectTest
{
    public partial class Form1 : Form
    {

        //declare var
        string workdirvar;
        //all github appz in a 2d array
        public string[,] homebrew = new string[4, 3] {
                                 // copy this     { "owner", "reponame", "tagname", "PublishedAt", "", "" },
                                                  { "Atmosphere-NX", "Atmosphere", "Extra"},
                                                  { "CTCaer", "hekate", "Extra", },
                                                  { "octokit", "octokit.net", "Extra"},
                                                  { "Later", "Later", "Extra" }
            };

        QueryGH qgh = new QueryGH();

        static Release rls_atmosphere;
        static Release rls_hekate;

        public Form1()
        {
            InitializeComponent();


            BuildTreeView(homebrew);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            GetReleases(0);
            btn_atmo.Enabled = false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            GetReleases(1);
            //disable button to avoid spam
            btnGetRe.Enabled = false;
        }
        private void btn_check_Click(object sender, EventArgs e)
        {
            CheckReleases(0);
            btn_check.Enabled = false;
        }

        private void GetReleases(int i)
        {
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
                var releases = client.Repository.Release.GetAll(homebrew[i, 0], homebrew[i, 1]).Result;
                var latest = releases[0];

                string mkline = new String('_', rtb_releasebdy.Size.Width/10);

                //fill releasebox
                rtb_releasebdy.SelectionAlignment = HorizontalAlignment.Center;
                rtb_releasebdy.Text += (latest.Name + Environment.NewLine + latest.Body + Environment.NewLine + mkline + Environment.NewLine + Environment.NewLine);

                //loops through all releases and prints out each release name
                foreach (var item in releases.Take(5))
                {
                    //fill parent node [0] with children
                    treeView1.Nodes[i].Nodes.Add(item.TagName + " - " + item.Name);

                    //fill richtext
                    richTextBox1.Text += (item.TagName + " - " + item.Name + Environment.NewLine);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(GetExecutingMethodName(ex) + Environment.NewLine + ex.Message, "Error!");
            }
        }

        
        // Method to populare Tree with parents from an 2d array arg appz
        private void BuildTreeView(string[,] appz)
        {
            try
            {
                for (int i = 0; i < appz.Length / 3; i++)
                {
                    TreeNode treeNode = new TreeNode(appz[i, 0] + "/" + appz[i, 1]);
                    treeView1.Nodes.Add(treeNode);

                    richTextBox1.Text += (treeNode.Name + Environment.NewLine);
                    Console.WriteLine(treeNode.Name);

                    clb_appz.Items.Add(appz[i, 0] + "/" + appz[i, 1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(GetExecutingMethodName(ex) + Environment.NewLine + ex.Message, "Error!");
            }
        }

        private void CheckReleases(int i)
        {
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
                var releases = client.Repository.Release.GetAll(homebrew[i, 0], homebrew[i, 1]).Result;
                var latest = releases[0];



                //richTextBox1.Text += latest.;
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(latest))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(latest);
                    //Console.WriteLine("{0}={1}", name, value);
                    richTextBox1.Text += ("Name: " + name + (Environment.NewLine) + "Value: " + value);
                    richTextBox1.Text += (Environment.NewLine) + (Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(GetExecutingMethodName(ex) + Environment.NewLine + ex.Message, "Error!");
            }
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox1 box = new AboutBox1())
            {
                box.ShowDialog(this);
            }
        }

        private string GetExecutingMethodName(Exception exception)
        {
            var trace = new StackTrace(exception);
            var frame = trace.GetFrame(0);
            var method = frame.GetMethod();

            return string.Concat(method.DeclaringType.FullName, ".", method.Name);
        }

        //Activate checkbox-button if an item is checked
        private void clb_appz_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {

                if (clb_appz.CheckedItems.Count >= 1)
                {
                    listBox_appz.Items.Remove(clb_appz.Items[e.Index]);
                    btn_checkbox.Enabled = false;
                }
            }
            else
            {
                listBox_appz.Items.Add(clb_appz.Items[e.Index]);
                btn_checkbox.Enabled = true;
            }
        }

        private void btn_checkbox_Click(object sender, EventArgs e)
        {
            string checkeditems = "";
            foreach(string items in clb_appz.CheckedItems)
            {
                listBox_appz.Items.Add(items);
                //clb_appz.Items.Add(appz[i, 0] + "/" + appz[i, 1]);
            }
            richTextBox1.Text += checkeditems;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_workfolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_workfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_workfolder.Text = folderDlg.SelectedPath;
                workdirvar = folderDlg.SelectedPath;
                //Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void btn_checkreleases_Click(object sender, EventArgs e)
        {
            //CheckProps(0, 1);
            QueryGH queryGH = new QueryGH();
            string vajas = queryGH.CheckProps(homebrew[0, 0], homebrew[0, 1], 1);
            richTextBox1.Clear();
            richTextBox1.Text += vajas;

            btn_checkreleases.Enabled = false;
        }

        private void btn_CheckAssets_Click(object sender, EventArgs e)
        {
            //0 1 for latest release, 0 2 for assets
            CheckProps(0, 2);
            btn_CheckAssets.Enabled = false;

        }

        private void CheckProps(int i, int whichprop)
        {
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
                var releases = client.Repository.Release.GetAll(homebrew[i, 0], homebrew[i, 1]).Result;
                var latest = releases[0];
                richTextBox1.Clear();


                switch (whichprop)
                {
                    //Check Latest Releases
                    case 1:
                        foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(latest))
                        {
                            string name = descriptor.Name;
                            object value = descriptor.GetValue(latest);
                            richTextBox1.Text += ("Name: " + name + (Environment.NewLine) + "Value: " + value);
                            richTextBox1.Text += (Environment.NewLine) + (Environment.NewLine);
                        }
                        break;
                        //Check Assets of latest
                    case 2:
                        var assets = client.Repository.Release.GetAllAssets(homebrew[i, 0], homebrew[i, 1], latest.Id).Result;
                        var assetnumber = assets.Count;
                        tb_assetcount.Text = assetnumber.ToString();
                        int tempint = 0;

                        foreach (var item in assets)
                        {
                            var latestid = assets[tempint];
                            rtb_releasebdy.Text += latestid.BrowserDownloadUrl + Environment.NewLine;

                            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(latestid))
                            {
                                string name = descriptor.Name;
                                object value = descriptor.GetValue(latestid);
                                richTextBox1.Text += ("Name: " + name + (Environment.NewLine) + "Value: " + value);
                                richTextBox1.Text += (Environment.NewLine) + (Environment.NewLine);
                            }
                            tempint++;
                        }
                        break;
                    default:
                        MessageBox.Show(whichprop + " is not a valid property. Wrong property value sent!", "Error!");
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(GetExecutingMethodName(ex) + Environment.NewLine + ex.Message, "Error!");
            }
        }

        private void btn_looparray_Click(object sender, EventArgs e)
        {

            string txt = "";
            for (int i = 0; i <= homebrew.GetUpperBound(0); i++)
            {
                string line = "";
                for (int j = 0; j <= homebrew.GetUpperBound(1); j++)
                {
                    line += " " + homebrew[i, j];
                }
                if (line.Length > 0) line = line.Substring(1);
                txt += Environment.NewLine + line;
            }
            if (txt.Length > 0) txt = txt.Substring(Environment.NewLine.Length);
            richTextBox1.Text = txt;
            richTextBox1.Select(0, 0);

        }

        private void btn_testlatest_Click(object sender, EventArgs e)
        {

            rls_atmosphere = qgh.LatestRelease(homebrew[0, 0], homebrew[0, 1]);

            var bajs = qgh.LatestRelease(homebrew[0, 0], homebrew[0, 1]);

            string result = "";

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(bajs))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(bajs);
                result += ("Name: " + name + (Environment.NewLine) + "Value: " + value);
                result += (Environment.NewLine) + (Environment.NewLine);
            }
            richTextBox1.Clear();
            richTextBox1.Text += result;

        }

        private void btn_printlatestrls_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(rls_atmosphere))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(rls_atmosphere);
                result += ("Name: " + name + (Environment.NewLine) + "Value: " + value);
                result += (Environment.NewLine) + (Environment.NewLine);
            }
            rtb_releasebdy.Clear();
            rtb_releasebdy.Text += result;
        }
    }
}
