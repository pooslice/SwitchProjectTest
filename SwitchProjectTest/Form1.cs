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

        //all github appz in a 2d array
        string[,] homebrew = new string[4, 2] {
                                 // copy this     { "", "" },
                                                  { "Atmosphere-NX", "Atmosphere" },
                                                  { "CTCaer", "hekate"},
                                                  { "octokit", "octokit.net" },
                                                  { "Later", "Later" }
            };
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
            CheckReleases(10);
            btn_check.Enabled = false;
        }

        private void GetReleases(int i)
        {
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
                //var releases = await client.Repository.Release.GetAll(homebrew[i, 0], homebrew[0, i]);
                var releases = client.Repository.Release.GetAll(homebrew[i, 0], homebrew[i, 1]).Result;
                var latest = releases[0];

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
                for (int i = 0; i < appz.Length / 2; i++)
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
                    richTextBox1.Text += ("Name: " + name + (Environment.NewLine) + "Value: "+ value);
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
    }
}
