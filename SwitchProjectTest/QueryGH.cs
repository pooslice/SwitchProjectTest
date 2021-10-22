using Octokit;
using System;
using System.IO;
using System.Reflection;

namespace SwitchProjectTest
{
    class QueryGH
    {
        public Release LatestRelease(string owner, string repo)
        {
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));

                // if token.txt file exist we will use the content as auth
                if (File.Exists(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\token.txt"))
                {
                    //Pass the file path and file name to the StreamReader constructor
                    StreamReader sr = new StreamReader(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\token.txt");
                    //Read the first line of text
                    string token = sr.ReadLine();

                    //MY TOKEN REMOVE LATER
                    var tokenAuth = new Credentials(token);
                    client.Credentials = tokenAuth;
                }

                var releases = client.Repository.Release.GetAll(owner, repo).Result;
                var latest = releases[0];

                return latest;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
