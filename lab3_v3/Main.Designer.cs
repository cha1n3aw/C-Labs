namespace Stalker
{
    partial class MetroMainForm
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
            this.EventLogs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.friends = new System.Windows.Forms.ComboBox();
            this.customuserid = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.loadlogs = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventLogs
            // 
            this.EventLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EventLogs.Location = new System.Drawing.Point(12, 52);
            this.EventLogs.Multiline = true;
            this.EventLogs.Name = "EventLogs";
            this.EventLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EventLogs.Size = new System.Drawing.Size(378, 435);
            this.EventLogs.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Friend\'s ID";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(287, 26);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(38, 21);
            this.start.TabIndex = 15;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.StartClicked);
            // 
            // friends
            // 
            this.friends.FormattingEnabled = true;
            this.friends.Location = new System.Drawing.Point(12, 25);
            this.friends.Name = "friends";
            this.friends.Size = new System.Drawing.Size(190, 21);
            this.friends.TabIndex = 17;
            this.friends.SelectedIndexChanged += new System.EventHandler(this.FriendIdSelected);
            // 
            // customuserid
            // 
            this.customuserid.Location = new System.Drawing.Point(208, 26);
            this.customuserid.Name = "customuserid";
            this.customuserid.Size = new System.Drawing.Size(73, 20);
            this.customuserid.TabIndex = 18;
            this.customuserid.Text = "193640924";
            this.customuserid.TextChanged += new System.EventHandler(this.CustomUserIdSelected);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(331, 26);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(38, 21);
            this.stop.TabIndex = 19;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.StopClicked);
            // 
            // loadlogs
            // 
            this.loadlogs.AutoSize = true;
            this.loadlogs.Checked = true;
            this.loadlogs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loadlogs.Location = new System.Drawing.Point(375, 32);
            this.loadlogs.Name = "loadlogs";
            this.loadlogs.Size = new System.Drawing.Size(15, 14);
            this.loadlogs.TabIndex = 20;
            this.loadlogs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loadlogs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(372, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Load\r\nLogs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(205, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Custom ID";
            // 
            // MetroMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadlogs);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.customuserid);
            this.Controls.Add(this.friends);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EventLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MetroMainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Stalker";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EventLogs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ComboBox friends;
        private System.Windows.Forms.TextBox customuserid;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.CheckBox loadlogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

