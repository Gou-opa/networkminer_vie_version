﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace NetworkMiner {
    public partial class UpdateCheck : Form {

        public static string CachedLocalVersionCode = null;
        public static Action CachedDownloadButtonAction = null;
        public static string HelpText { get; set; }

        public static void ShowNewVersionFormIfAvailableAsync(Form parentForm, Version localVersion, bool showMessageBoxIfNoUpdate = false) {
            byte[] extra = null;
            if (PacketParser.Utils.SystemHelper.IsRunningOnMono())
                extra = Encoding.ASCII.GetBytes("Mono");
            //public Version(int major, int minor, int build, int revision)
            if (CachedLocalVersionCode == null)
                ShowNewVersionFormIfAvailableAsync(parentForm, localVersion, "1" + localVersion.Major + localVersion.Minor + localVersion.Build, extra);
            else {
                ShowNewVersionFormIfAvailableAsync(parentForm, localVersion, CachedLocalVersionCode, extra, showMessageBoxIfNoUpdate);
            }
        }

        public Action DownloadButtonAction { get; set; }
        

        public static void ShowNewVersionFormIfAvailableAsync(Form parentForm, Version localVersion, string localVersionCode, byte[] extra = null, bool showMessageBoxIfNoUpdate = false) {
            if (CachedLocalVersionCode == null)
                CachedLocalVersionCode = localVersionCode;

            System.Threading.Tasks.Task.Factory.StartNew(() => {

                try {
#if DEBUG
                    //string requestURL = "http://localhost:57978/updatecheck.ashx?l=" + System.Web.HttpUtility.UrlEncode(localVersionCode);
                    string requestURL = "https://www.netresec.com/updatecheck.ashx?l=" + System.Web.HttpUtility.UrlEncode(localVersionCode);
#else
                    string requestURL = "https://www.netresec.com/updatecheck.ashx?l=" + System.Web.HttpUtility.UrlEncode(localVersionCode);
#endif
                    if (extra != null && extra.Length > 0)
                        requestURL += "&e=" + System.Web.HttpUtility.UrlEncode(Convert.ToBase64String(extra));
                    PacketParser.Utils.Logger.Log("Checking for updates", System.Diagnostics.EventLogEntryType.Information);
                    //System.IO.Stream resultStream = client.GetStreamAsync(requestURL).Result;
                    HttpWebRequest request = WebRequest.Create(requestURL) as HttpWebRequest;
                    
                    string versionString, releasePost, downloadUrl;
                    //using (System.IO.TextReader reader = new System.IO.StreamReader(resultStream)) {
                    
                    using (WebResponse response = request.GetResponse()) {
                        using (System.IO.Stream stream = response.GetResponseStream()) {
                            using (System.IO.TextReader reader = new System.IO.StreamReader(stream)) {

                                versionString = reader.ReadLine();
                                releasePost = reader.ReadLine();
                                downloadUrl = reader.ReadLine();
                            }
                        }
                    }
                    Version latestVersion = Version.Parse(versionString);
                    if (latestVersion > localVersion) {
                        PacketParser.Utils.Logger.Log("Newer version available: " + versionString, System.Diagnostics.EventLogEntryType.Information);
                        parentForm.Invoke(new Action(() => {
                            UpdateCheck form = new UpdateCheck(versionString, releasePost, downloadUrl);
                            form.ShowDialog();
                        }));//end of invoke
                    }
                    else if(showMessageBoxIfNoUpdate) {
                        PacketParser.Utils.Logger.Log("This is the latest version", System.Diagnostics.EventLogEntryType.Information);
                        parentForm.Invoke(new Action(() => {
                            MessageBox.Show("You are running the latest version of NetworkMiner (" + localVersion.ToString() + ")", "No update required");
                        }));
                    }

                }
                catch (Exception e) {
                    PacketParser.Utils.Logger.Log("Error checking for updates: " + e.GetType().ToString() + " : " + e.Message, System.Diagnostics.EventLogEntryType.Error);
                }
            });//end of task
        }

        public UpdateCheck(string newVersion, string releasePost, string downloadUrl) {
            InitializeComponent();
            this.Text = "Version " + newVersion + " available";

            this.newVersionTextBox.Text = "There is a newer version of NetworkMiner available. Please update to version " + newVersion + ".";
            if(!String.IsNullOrEmpty(HelpText)) {
                this.newVersionTextBox.Text += Environment.NewLine + HelpText;
            }


            if (string.IsNullOrEmpty(releasePost))
                this.releaseNoteLinkLabel.Visible = false;
            else {
                this.releaseNoteLinkLabel.Visible = true;
                this.releaseNoteLinkLabel.Links.Add(0, this.releaseNoteLinkLabel.Text.Length, releasePost);
            }
            if (string.IsNullOrEmpty(downloadUrl)) {
                this.downloadButton.Enabled = false;
            }
            else {
                if (CachedDownloadButtonAction != null)
                    this.DownloadButtonAction = new Action(() => {
                        try {
                            CachedDownloadButtonAction.Invoke();
                            this.Close();
                        }
                        catch(Exception e) {
                            PacketParser.Utils.Logger.Log("Error invoking CachedDownloadButtonAction: " + e.Message, System.Diagnostics.EventLogEntryType.Error);
                            System.Diagnostics.Process.Start(downloadUrl);
                        }
                    });
                else
                    this.DownloadButtonAction = new Action(() => { System.Diagnostics.Process.Start(downloadUrl); });
                this.downloadButton.Enabled = true;
            }
        }

        private void linkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void downloadButton_Click(object sender, EventArgs e) {
            //System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            this.DownloadButtonAction?.Invoke();
        }

    }
}
