using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchProjectTest
{
    class QueryGH
    {
        public Release LatestRelease(string owner, string repo)
        {
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
                var releases = client.Repository.Release.GetAll(owner, repo).Result;
                var latest = releases[0];

                return latest;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string CheckProps(string owner, string repo, int whichprop)
        {
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
                var releases = client.Repository.Release.GetAll(owner, repo).Result;
                var latest2 = releases[0];
                var latest = LatestRelease(owner, repo);
                string result = "";


                switch (whichprop)
                {
                    //Check Latest Releases
                    case 1:
                        foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(latest))
                        {
                            string name = descriptor.Name;
                            object value = descriptor.GetValue(latest);
                            result += ("Name: " + name + (Environment.NewLine) + "Value: " + value);
                            result += (Environment.NewLine) + (Environment.NewLine);
                        }
                        return result;
                    //Check Assets of latest
                    case 2:
                        var assets = client.Repository.Release.GetAllAssets(owner, repo, latest.Id).Result;
                        var assetnumber = assets.Count;
                        //tb_assetcount.Text = assetnumber.ToString();
                        int tempint = 0;

                        foreach (var item in assets)
                        {
                            var latestid = assets[tempint];
                            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(latestid))
                            {
                                string name = descriptor.Name;
                                object value = descriptor.GetValue(latestid);
                                result += ("Name: " + name + (Environment.NewLine) + "Value: " + value);
                                result += (Environment.NewLine) + (Environment.NewLine);
                            }
                            tempint++;
                        }
                        return result;
                }
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public string GetPatchnotes(string owner, string repo)
        {
            try
            {
                var latest = LatestRelease(owner, repo);

                string result = "";
                string mkline = "____________________";

                //fill releasebox
                result += (latest.Name + Environment.NewLine + latest.Body + Environment.NewLine + mkline + Environment.NewLine + Environment.NewLine);
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //GET RELEASE NAME - Name

        //ADD GET RELEASE VERSION - TagName

        //GET RELEASE DATE - PublishedAt

        //GET ASSET SIZE



        public string AssetsDownloadLink(string owner, string repo)
        {
            try
            {
                var latest = LatestRelease(owner, repo);

                string result = "";
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
