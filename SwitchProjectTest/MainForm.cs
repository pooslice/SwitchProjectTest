using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace SwitchProjectTest
{
    public partial class MainForm : Form
    {
        //declare vars

        //working directory. (where to save dl etc)
        string workdirvar;

        //download counter
        int dlCounter = 0;
        int dlCounterTot;

        QueryGH qgh = new QueryGH();
        AppzList appzList = new AppzList();

        //will import the applist later into this array so we can populate from it
        static string[,] homebrew;

        //create a list with Releases from the Github API octokit
        List<Release> rlsList = new List<Release>();

        public MainForm()
        {
            InitializeComponent();

            //set the alignment for our text
            rtb_releasebdy.SelectionAlignment = HorizontalAlignment.Center;

            //lets grab our application list
            homebrew = appzList.GetAppzList();

            //And fill our checkbox with the applications from the list
            BuildTreeView(homebrew);

            rtb_console.Text += "Program started!" + Environment.NewLine;

        }

        private void btn_workfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                workdirvar = folderDlg.SelectedPath;
                tb_workfolder.Text = workdirvar;

                rtb_console.Text += "Working directory set to: " + workdirvar + Environment.NewLine;

                btn_download.Enabled = true;
            }
        }

        // Method to populate checkboxlist
        private void BuildTreeView(string[,] appz)
        {
            try
            {
                for (int i = 0; i < appz.Length / 3; i++)
                {
                    clb_appz.Items.Add(appz[i, 0] + "/" + appz[i, 1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(GetExecutingMethodName(ex) + Environment.NewLine + ex.Message, "Error!");
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

                if (clb_appz.CheckedItems.Count == 1)
                {
                    btn_checkbox.Enabled = false;
                }
                listBox_appz.Items.Remove(clb_appz.Items[e.Index]);

            }
            else
            {
                listBox_appz.Items.Add(clb_appz.Items[e.Index]);
                btn_checkbox.Enabled = true;

            }

        }


        private void btn_checkbox_Click(object sender, EventArgs e)
        {
            //disable further manipulation of the appzlist(clickbox)
            clb_appz.Enabled = false;
            btn_checkbox.Enabled = false;

            foreach (object item in listBox_appz.Items)
            {
                //store the index item into a string so we can split it
                string input = item.ToString();
                //splitting the string and putting it into an array
                string[] gitrepo = input.Split('/');

                //Add to list, query github, from our split string
                rlsList.Add(qgh.LatestRelease(gitrepo[0], gitrepo[1]));

                rtb_console.Text += gitrepo[0] + " -> " + gitrepo[1] + " Github release has been stored in the list." + Environment.NewLine;
            }

            // Enable the appzlist so the user can review
            listBox_appz.Enabled = true;

            rtb_console.Text += "All releases from Github has been set!" + Environment.NewLine;
        }

        private void listBox_appz_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check index of selected item and display what is found in the rlslist.
            rtb_releasebdy.Text = rlsList[listBox_appz.SelectedIndex].Body;
            rtb_description.Text = rlsList[listBox_appz.SelectedIndex].Name;
            rtb_releasedate.Text = rlsList[listBox_appz.SelectedIndex].PublishedAt.ToString();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            dlCounterTot = CountReleaseList(rlsList);

            rtb_console.Text += "Downloading " + dlCounterTot + " files." + Environment.NewLine;

            foreach (var Release in rlsList)
            {
                //Send the Release Assets to correctFile method to find a zip or nro file
                string fileTodl = correctFile(Release.Assets);

                string[] fileNameSplit = fileTodl.Split('/');
                string fileName = "";
                foreach (string words in fileNameSplit)
                {
                    fileName = words;
                }

                //Formats filename to remove URL characters
                fileName = Uri.UnescapeDataString(fileName);

                string downloadTo = workdirvar + "\\" + fileName;

                //Since atmosphere doesnt contain fusee lets make something to download it here if atmo is selected
                if (fileTodl.Contains("atmosphere"))
                {
                    dlCounterTot++;
                    downloadFile(getFusee(Release.Assets), workdirvar + "\\fusee.bin");
                }

                    downloadFile(fileTodl, downloadTo);
            }

        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        
        //Will check when download is complete and then apply fileHandler() on it
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //Find the name of the file that was just downloaded
            string fileIdentifier = ((System.Net.WebClient)(sender)).QueryString["file"];

            rtb_console.Text += "Download complete: " + fileIdentifier + Environment.NewLine;

            fileHandler(fileIdentifier);

            dlCounter++;

            if(dlCounter == dlCounterTot)
            {
                rtb_console.Text += "All files have been downloaded!" + Environment.NewLine;
            }
        }

        // Will download a file to a specific location
        private void downloadFile(string fileTodl, string downloadTo)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);

            //Add this file so we can find it when download is completed. To notify the user.
            client.QueryString.Add("file", downloadTo); // add downloadTo variable so we can find it later

            //Check if file exist, else download...
            if (File.Exists(fileTodl))
            {
                rtb_console.Text += "File " + fileTodl + " already exist! Skipping..." + Environment.NewLine;
            }
            else
            {
                // Starts the download
                client.DownloadFileAsync(new Uri(fileTodl), downloadTo);

                rtb_console.Text += "Downloading " + fileTodl + Environment.NewLine;

                btn_download.Text = "Downloading...";
                btn_download.Enabled = false;
            }
        }

        // Will count how many Github Releases in the list
        private int CountReleaseList(List<Release> listToCount)
        {
            int counter = 0;

            foreach(var Release in listToCount)
            {
                counter++;
            }

            return counter;
        }

        // Will look for zip or nro file and return when found
        private string correctFile(IReadOnlyList<ReleaseAsset> assetList)
        {
            string nroFind = "nro";
            string zipFind = "zip";

            foreach(var ReleaseAsset in assetList)
            {
                if (ReleaseAsset.BrowserDownloadUrl.Contains(nroFind) || ReleaseAsset.BrowserDownloadUrl.Contains(zipFind))
                {
                    rtb_console.Text += "Found: " + ReleaseAsset.BrowserDownloadUrl + Environment.NewLine;

                    return ReleaseAsset.BrowserDownloadUrl;
                } 
            }

            rtb_console.Text += "No valid files found!" + Environment.NewLine;
            return zipFind;
        }

        // Will look for fusee.bin in Asset of the Release
        private string getFusee(IReadOnlyList<ReleaseAsset> assetList)
        {
            string returnString = "Not found";
            foreach (var ReleaseAsset in assetList)
            {
                if (ReleaseAsset.BrowserDownloadUrl.Contains("fusee.bin"))
                {
                    rtb_console.Text += "Found: " + ReleaseAsset.BrowserDownloadUrl + Environment.NewLine;

                    returnString = ReleaseAsset.BrowserDownloadUrl;
                }
            }
            return returnString;
        }

        // Handles the file dependent on what it is
        private void fileHandler(string fileToHandle)
        {
            string[] fileNameSplit = fileToHandle.Split('\\');
            string fileName = "";
            foreach (string words in fileNameSplit)
            {
                fileName = words;
            }

            string today = DateTime.Today.ToString("yyyy/MM/dd");
            string folder = workdirvar + "\\" + today;
            string nroDestination = folder + "\\switch\\" + fileName;

            Directory.CreateDirectory(folder);
            Directory.CreateDirectory(folder + "\\switch");

            if (fileToHandle.Contains(".zip") && !fileToHandle.Contains("NX-Update-Checker"))
            {
                ZipFile.ExtractToDirectory(fileToHandle, folder);

                //Delete file after extraction
                try
                {
                    File.Delete(fileToHandle);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    rtb_console.Text += "Error: " + e.Message + Environment.NewLine;
                    return;
                }

            }

            if (fileToHandle.Contains(".zip") && fileToHandle.Contains("NX-Update-Checker"))
            {
                Directory.CreateDirectory(folder + "\\switch\\NX-Update-Checker");
                ZipFile.ExtractToDirectory(fileToHandle, folder + "\\switch\\NX-Update-Checker");

                //Delete file after extraction
                try
                {
                    File.Delete(fileToHandle);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    rtb_console.Text += "Error: " + e.Message + Environment.NewLine;
                    return;
                }
            }

            if (fileToHandle.Contains(".nro"))
            {
                File.Move(fileToHandle, nroDestination);
            }

            if (fileToHandle.Contains("fusee.bin"))
            {
                Directory.CreateDirectory(folder + "\\atmosphere");
                File.Move(fileToHandle, folder + "\\atmosphere\\fusee.bin");
            }


                rtb_console.Text += "File moved." + Environment.NewLine;

        }

        //Will make sure the last text in the console is readable.
        private void rtb_console_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            rtb_console.SelectionStart = rtb_console.Text.Length;
            // scroll it automatically
            rtb_console.ScrollToCaret();
        }
    }
}
