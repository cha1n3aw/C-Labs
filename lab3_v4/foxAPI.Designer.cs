﻿namespace foxclient
{
    partial class fox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fox));
            this.Tray_Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.apirequestkey = new MetroFramework.Controls.MetroTextBox();
            this.authbutton = new MetroFramework.Controls.MetroButton();
            this.apirequestbutton = new MetroFramework.Controls.MetroButton();
            this.apirequest = new MetroFramework.Controls.MetroTextBox();
            this.apirequestvalue = new MetroFramework.Controls.MetroTextBox();
            this.addparams = new MetroFramework.Controls.MetroButton();
            this.apilink = new MetroFramework.Controls.MetroLabel();
            this.im_log = new MetroFramework.Controls.MetroTextBox();
            this.message = new MetroFramework.Controls.MetroTextBox();
            this.sendmessage = new MetroFramework.Controls.MetroButton();
            this.friendslist = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // Tray_Icon
            // 
            this.Tray_Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray_Icon.Icon")));
            this.Tray_Icon.Text = "fox";
            this.Tray_Icon.Visible = true;
            this.Tray_Icon.BalloonTipClicked += new System.EventHandler(this.Tray_Icon_BalloonTipClicked);
            this.Tray_Icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_Icon_MouseDoubleClick);
            // 
            // apirequestkey
            // 
            // 
            // 
            // 
            this.apirequestkey.CustomButton.Image = null;
            this.apirequestkey.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.apirequestkey.CustomButton.Name = "";
            this.apirequestkey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.apirequestkey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.apirequestkey.CustomButton.TabIndex = 1;
            this.apirequestkey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.apirequestkey.CustomButton.UseSelectable = true;
            this.apirequestkey.CustomButton.Visible = false;
            this.apirequestkey.Lines = new string[0];
            this.apirequestkey.Location = new System.Drawing.Point(476, 404);
            this.apirequestkey.MaxLength = 32767;
            this.apirequestkey.Name = "apirequestkey";
            this.apirequestkey.PasswordChar = '\0';
            this.apirequestkey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apirequestkey.SelectedText = "";
            this.apirequestkey.SelectionLength = 0;
            this.apirequestkey.SelectionStart = 0;
            this.apirequestkey.ShortcutsEnabled = true;
            this.apirequestkey.Size = new System.Drawing.Size(75, 23);
            this.apirequestkey.Style = MetroFramework.MetroColorStyle.Black;
            this.apirequestkey.TabIndex = 0;
            this.apirequestkey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.apirequestkey.UseSelectable = true;
            this.apirequestkey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.apirequestkey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // authbutton
            // 
            this.authbutton.Location = new System.Drawing.Point(372, 364);
            this.authbutton.Name = "authbutton";
            this.authbutton.Size = new System.Drawing.Size(67, 23);
            this.authbutton.TabIndex = 1;
            this.authbutton.Text = "Log In";
            this.authbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.authbutton.UseSelectable = true;
            this.authbutton.Click += new System.EventHandler(this.Auth_Click);
            // 
            // apirequestbutton
            // 
            this.apirequestbutton.Location = new System.Drawing.Point(557, 375);
            this.apirequestbutton.Name = "apirequestbutton";
            this.apirequestbutton.Size = new System.Drawing.Size(75, 23);
            this.apirequestbutton.TabIndex = 2;
            this.apirequestbutton.Text = "Reqest!";
            this.apirequestbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.apirequestbutton.UseSelectable = true;
            this.apirequestbutton.Click += new System.EventHandler(this.APIRequest_Click);
            // 
            // apirequest
            // 
            // 
            // 
            // 
            this.apirequest.CustomButton.Image = null;
            this.apirequest.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.apirequest.CustomButton.Name = "";
            this.apirequest.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.apirequest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.apirequest.CustomButton.TabIndex = 1;
            this.apirequest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.apirequest.CustomButton.UseSelectable = true;
            this.apirequest.CustomButton.Visible = false;
            this.apirequest.Lines = new string[0];
            this.apirequest.Location = new System.Drawing.Point(476, 375);
            this.apirequest.MaxLength = 32767;
            this.apirequest.Name = "apirequest";
            this.apirequest.PasswordChar = '\0';
            this.apirequest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apirequest.SelectedText = "";
            this.apirequest.SelectionLength = 0;
            this.apirequest.SelectionStart = 0;
            this.apirequest.ShortcutsEnabled = true;
            this.apirequest.Size = new System.Drawing.Size(75, 23);
            this.apirequest.Style = MetroFramework.MetroColorStyle.Black;
            this.apirequest.TabIndex = 3;
            this.apirequest.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.apirequest.UseSelectable = true;
            this.apirequest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.apirequest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // apirequestvalue
            // 
            // 
            // 
            // 
            this.apirequestvalue.CustomButton.Image = null;
            this.apirequestvalue.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.apirequestvalue.CustomButton.Name = "";
            this.apirequestvalue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.apirequestvalue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.apirequestvalue.CustomButton.TabIndex = 1;
            this.apirequestvalue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.apirequestvalue.CustomButton.UseSelectable = true;
            this.apirequestvalue.CustomButton.Visible = false;
            this.apirequestvalue.Lines = new string[0];
            this.apirequestvalue.Location = new System.Drawing.Point(476, 433);
            this.apirequestvalue.MaxLength = 32767;
            this.apirequestvalue.Name = "apirequestvalue";
            this.apirequestvalue.PasswordChar = '\0';
            this.apirequestvalue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apirequestvalue.SelectedText = "";
            this.apirequestvalue.SelectionLength = 0;
            this.apirequestvalue.SelectionStart = 0;
            this.apirequestvalue.ShortcutsEnabled = true;
            this.apirequestvalue.Size = new System.Drawing.Size(75, 23);
            this.apirequestvalue.Style = MetroFramework.MetroColorStyle.Black;
            this.apirequestvalue.TabIndex = 6;
            this.apirequestvalue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.apirequestvalue.UseSelectable = true;
            this.apirequestvalue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.apirequestvalue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addparams
            // 
            this.addparams.Location = new System.Drawing.Point(557, 404);
            this.addparams.Name = "addparams";
            this.addparams.Size = new System.Drawing.Size(75, 52);
            this.addparams.TabIndex = 7;
            this.addparams.Text = "Add";
            this.addparams.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addparams.UseSelectable = true;
            this.addparams.Click += new System.EventHandler(this.AddParams_Click);
            // 
            // apilink
            // 
            this.apilink.AutoSize = true;
            this.apilink.Location = new System.Drawing.Point(24, 405);
            this.apilink.Name = "apilink";
            this.apilink.Size = new System.Drawing.Size(0, 0);
            this.apilink.TabIndex = 8;
            // 
            // im_log
            // 
            // 
            // 
            // 
            this.im_log.CustomButton.Image = null;
            this.im_log.CustomButton.Location = new System.Drawing.Point(35, 1);
            this.im_log.CustomButton.Name = "";
            this.im_log.CustomButton.Size = new System.Drawing.Size(307, 307);
            this.im_log.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.im_log.CustomButton.TabIndex = 1;
            this.im_log.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.im_log.CustomButton.UseSelectable = true;
            this.im_log.CustomButton.Visible = false;
            this.im_log.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.im_log.Lines = new string[0];
            this.im_log.Location = new System.Drawing.Point(23, 107);
            this.im_log.MaxLength = 32767;
            this.im_log.Multiline = true;
            this.im_log.Name = "im_log";
            this.im_log.PasswordChar = '\0';
            this.im_log.ReadOnly = true;
            this.im_log.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.im_log.SelectedText = "";
            this.im_log.SelectionLength = 0;
            this.im_log.SelectionStart = 0;
            this.im_log.ShortcutsEnabled = true;
            this.im_log.Size = new System.Drawing.Size(343, 309);
            this.im_log.TabIndex = 10;
            this.im_log.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.im_log.UseSelectable = true;
            this.im_log.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.im_log.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // message
            // 
            // 
            // 
            // 
            this.message.CustomButton.Image = null;
            this.message.CustomButton.Location = new System.Drawing.Point(311, 2);
            this.message.CustomButton.Name = "";
            this.message.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.message.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.message.CustomButton.TabIndex = 1;
            this.message.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.message.CustomButton.UseSelectable = true;
            this.message.CustomButton.Visible = false;
            this.message.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.message.Lines = new string[0];
            this.message.Location = new System.Drawing.Point(23, 422);
            this.message.MaxLength = 32767;
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.PasswordChar = '\0';
            this.message.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.message.SelectedText = "";
            this.message.SelectionLength = 0;
            this.message.SelectionStart = 0;
            this.message.ShortcutsEnabled = true;
            this.message.Size = new System.Drawing.Size(343, 34);
            this.message.Style = MetroFramework.MetroColorStyle.Black;
            this.message.TabIndex = 11;
            this.message.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.message.UseSelectable = true;
            this.message.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.message.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Message_KeyDown);
            // 
            // sendmessage
            // 
            this.sendmessage.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.sendmessage.Location = new System.Drawing.Point(372, 422);
            this.sendmessage.Name = "sendmessage";
            this.sendmessage.Size = new System.Drawing.Size(67, 34);
            this.sendmessage.Style = MetroFramework.MetroColorStyle.Black;
            this.sendmessage.TabIndex = 12;
            this.sendmessage.Text = ">";
            this.sendmessage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.sendmessage.UseSelectable = true;
            this.sendmessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // friendslist
            // 
            this.friendslist.FormattingEnabled = true;
            this.friendslist.ItemHeight = 23;
            this.friendslist.Location = new System.Drawing.Point(24, 72);
            this.friendslist.Name = "friendslist";
            this.friendslist.Size = new System.Drawing.Size(342, 29);
            this.friendslist.Style = MetroFramework.MetroColorStyle.Black;
            this.friendslist.TabIndex = 15;
            this.friendslist.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.friendslist.UseSelectable = true;
            this.friendslist.SelectedIndexChanged += new System.EventHandler(this.Friendslist_SelectedIndexChanged);
            // 
            // fox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 482);
            this.Controls.Add(this.friendslist);
            this.Controls.Add(this.sendmessage);
            this.Controls.Add(this.message);
            this.Controls.Add(this.im_log);
            this.Controls.Add(this.apilink);
            this.Controls.Add(this.addparams);
            this.Controls.Add(this.apirequestvalue);
            this.Controls.Add(this.apirequest);
            this.Controls.Add(this.apirequestbutton);
            this.Controls.Add(this.authbutton);
            this.Controls.Add(this.apirequestkey);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fox";
            this.Padding = new System.Windows.Forms.Padding(20, 69, 20, 23);
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "fox";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Tray_Icon;
        private MetroFramework.Controls.MetroTextBox apirequestkey;
        private MetroFramework.Controls.MetroButton authbutton;
        private MetroFramework.Controls.MetroButton apirequestbutton;
        private MetroFramework.Controls.MetroTextBox apirequest;
        private MetroFramework.Controls.MetroTextBox apirequestvalue;
        private MetroFramework.Controls.MetroButton addparams;
        private MetroFramework.Controls.MetroLabel apilink;
        private MetroFramework.Controls.MetroTextBox im_log;
        private MetroFramework.Controls.MetroTextBox message;
        private MetroFramework.Controls.MetroButton sendmessage;
        private MetroFramework.Controls.MetroComboBox friendslist;
    }
}

