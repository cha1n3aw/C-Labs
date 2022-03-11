using MetroFramework.Forms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Stalker
{
    public partial class MetroAuthForm : MetroForm
    {
        private string redirectUri = "https://oauth.vk.com/blank.html";
        private int APPid = 2685278;
        public string Token { get; private set; }
        public MetroAuthForm()
        {
            InitializeComponent();
        }
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            string uri = e.Url.ToString();
            if (!uri.StartsWith(redirectUri)) return;
            var parameters = (from param in uri.Split('#')[1].Split('&')
                              let parts = param.Split('=')
                              select new
                              {
                                  Name = parts[0],
                                  Value = parts[1]
                              }
                             ).ToDictionary(v => v.Name, v => v.Value);

            Token = parameters["access_token"];
            DialogResult = DialogResult.Yes;
        }

        private void auth_Shown(object sender, EventArgs e)
        {
            webBrowser1.Navigate(
                new Uri("https://oauth.vk.com/authorize?"
                        + $"client_id={APPid}&display=page&scope=‭notify,friends,photos,audio,video,stories,pages,status,notes,messages,wall,ads,offline,docs,groups,notifications,stats,email,market&redirect_uri={redirectUri}&"
                        + "revoke=1&response_type=token&v=5.103"));
        }
    }
}
