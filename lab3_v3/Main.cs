using System;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace Stalker
{
    public partial class MetroMainForm : MetroForm
    {
        private const string apirequest = "https://api.vk.com/method/";
        private static string authtoken = String.Empty;
        private static string server_response = String.Empty;
        private List<string[]> FriendsList = new List<string[]>();
        int user_id = 193640924;
        Thread polling;
        private void Get(string uri) { server_response = new WebClient { Encoding = Encoding.UTF8 }.DownloadString(uri); }
        private void FetchFriends()
        {
            Get($"{apirequest}friends.get?order=name&count=5000&fields=domain&access_token={authtoken}&v=5.103");
            dynamic friendslist = JObject.Parse(server_response);
            var friendsl = friendslist.response;
            for (int i = 0; i < Convert.ToInt32(friendsl.count); i++)
            {
                FriendsList[i][0] = friendsl.items[i].id;
                FriendsList[i][1] = friendsl.items[i].first_name;
                FriendsList[i][2] = friendsl.items[i].last_name;
            }
            foreach (string[] str in FriendsList) friends.Items.Add($"{str[1]} {str[2]}");
        }
        private void LogInVK() { using (MetroAuthForm authForm = new MetroAuthForm()) { if (authForm.ShowDialog() == DialogResult.Yes) authtoken = authForm.Token; } FetchFriends(); }
        private void StartClicked(object sender, EventArgs e) 
        {
            if (loadlogs.Checked) EventLogs.Invoke((MethodInvoker)delegate { EventLogs.Text = File.ReadAllText(Application.StartupPath + $"\\{user_id}.txt"); });
            polling = new Thread(Poll) { IsBackground = true, Priority = ThreadPriority.Highest };
            polling.Start();
            start.Enabled = friends.Enabled = customuserid.Enabled = loadlogs.Enabled = false;
            stop.Enabled = true;
        }
        private void Poll ()
        {
            Counters counters = new Counters();
            bool continuous = false;
            WriteToFile($"Process started, object is id{ user_id }{ Environment.NewLine }");
            while (true)
            {
                try
                {
                    Get($"{apirequest}users.get?user_ids={user_id}&fields=online,counters,last_seen,activity&access_token={authtoken}&v=5.126");
                    dynamic decodedresponse = JObject.Parse(server_response);
                    var decoded = decodedresponse.response[0];
                    DateTime pDate = new DateTime(1970, 1, 1, 5, 0, 0, 0).AddSeconds((double)decoded.last_seen.time);
                    if (counters.albums != (int)decoded.counters.albums)
                    {
                        if (continuous) WriteToFile($"Update in albums: { counters.albums }  to { (int)decoded.counters.albums }{ Environment.NewLine }");
                        counters.albums = (int)decoded.counters.albums;
                    }
                    if (counters.audios != (int)decoded.counters.audios)
                    {
                        if (continuous) WriteToFile($"Update in audios: { counters.audios }  to { (int)decoded.counters.audios }{ Environment.NewLine }");
                        counters.audios = (int)decoded.counters.audios;
                    }
                    if (counters.followers != (int)decoded.counters.followers)
                    {
                        if (continuous) WriteToFile($"Update in followers: { counters.followers }  to { (int)decoded.counters.followers }{ Environment.NewLine }");
                        counters.followers = (int)decoded.counters.followers;
                    }
                    if (counters.friends != (int)decoded.counters.friends)
                    {
                        if (continuous) WriteToFile($"Update in friends: { counters.friends }  to { (int)decoded.counters.friends }{ Environment.NewLine }");
                        counters.friends = (int)decoded.counters.friends;
                    }
                    if (counters.gifts != (int)decoded.counters.gifts)
                    {
                        if (continuous) WriteToFile($"Update in gifts: { counters.gifts }  to { (int)decoded.counters.gifts }{ Environment.NewLine }");
                        counters.gifts = (int)decoded.counters.gifts;
                    }
                    if (counters.pages != (int)decoded.counters.pages)
                    {
                        if (continuous) WriteToFile($"Update in pages: { counters.pages }  to { (int)decoded.counters.pages }{ Environment.NewLine }");
                        counters.pages = (int)decoded.counters.pages;
                    }
                    if (counters.photos != (int)decoded.counters.photos)
                    {
                        if (continuous) WriteToFile($"Update in photos: { counters.photos }  to { (int)decoded.counters.photos }{ Environment.NewLine }");
                        counters.photos = (int)decoded.counters.photos;
                    }
                    if (counters.subscriptions != (int)decoded.counters.subscriptions)
                    {
                        if (continuous) WriteToFile($"Update in subscpritions: { counters.subscriptions }  to { (int)decoded.counters.subscriptions }{ Environment.NewLine }");
                        counters.subscriptions = (int)decoded.counters.subscriptions;
                    }
                    if (counters.videos != (int)decoded.counters.videos)
                    {
                        if (continuous) WriteToFile($"Update in videos: { counters.videos }  to { (int)decoded.counters.videos }{ Environment.NewLine }");
                        counters.videos = (int)decoded.counters.videos;
                    }
                    if (counters.clips_followers != (int)decoded.counters.clips_followers)
                    {
                        if (continuous) WriteToFile($"Update in clips followers: { counters.clips_followers }  to { (int)decoded.counters.clips_followers }{ Environment.NewLine }");
                        counters.clips_followers = (int)decoded.counters.clips_followers;
                    }
                    if (counters.online != (bool)decoded.online)
                    {
                        if (!counters.online && (bool)decoded.online) WriteToFile($"Online: { pDate }");
                        else WriteToFile($"  —  { pDate } { Environment.NewLine }");
                        counters.online = (bool)decoded.online;
                    }
                    continuous = true;
                }
                catch (Exception) { }
                Thread.Sleep(500);
            }
        }
        private void WriteToFile(string text)
        {
            EventLogs.Invoke((MethodInvoker)delegate { EventLogs.Text += text; });
            File.AppendAllText(Application.StartupPath + $"\\{user_id}.txt", text);
        }
        private void FriendIdSelected(object sender, EventArgs e)
        {
            StopClicked(new object(), new EventArgs());
            if (user_id != Convert.ToInt32(FriendsList[friends.SelectedIndex][0])) { EventLogs.Text = ""; user_id = Convert.ToInt32(FriendsList[friends.SelectedIndex][0]); }
        }
        private void CustomUserIdSelected(object sender, EventArgs e)
        {
            StopClicked(new object(), new EventArgs());
            if (user_id != Convert.ToInt32(customuserid.Text)) { EventLogs.Text = ""; user_id = Convert.ToInt32(customuserid.Text); }
        }
        private void StopClicked(object sender, EventArgs e)
        {
            if (polling != null) 
            { 
                polling.Abort(); 
                while (!(polling.ThreadState == ThreadState.Aborted)); 
                WriteToFile("Process stopped\n"); 
            }
            start.Enabled = friends.Enabled = customuserid.Enabled = loadlogs.Enabled = true;
            stop.Enabled = false;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopClicked(new object(), new EventArgs());
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
        }
        public MetroMainForm()
        {
            InitializeComponent();
            LogInVK();
        }
    }
    public class Counters
    {
        public int albums = 0;
        public int audios = 0;
        public int followers = 0;
        public int friends = 0;
        public int gifts = 0;
        public int pages = 0;
        public int photos = 0;
        public int subscriptions = 0;
        public int videos = 0;
        public int clips_followers = 0;
        public bool online = false;
    }
}
/*
Get($"{apirequest}messages.getLastActivity?user_id={user_id}&access_token={authtoken}&v=5.103");
dynamic decodedresponse = JObject.Parse(server_response);
var decoded = decodedresponse.response;
DateTime pDate = new DateTime(1970, 1, 1, 5, 0, 0, 0).AddSeconds((double)decoded.time);
if (!prevonline && (bool)decoded.online)
{
    profileinfo.Invoke((MethodInvoker)delegate { profileinfo.Text += $"Online: { pDate }"; });
    WriteToFile($"Online: { pDate } - ");
    prevonline = true;
}
else if (prevonline && !(bool)decoded.online)
{
    profileinfo.Invoke((MethodInvoker)delegate { profileinfo.Text += $"  —  { pDate } { Environment.NewLine }"; });
    WriteToFile($"{ pDate }\n");
    prevonline = false;
}
*/