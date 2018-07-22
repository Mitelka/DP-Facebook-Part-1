using System;

namespace C18_Ex01_301674560_Raz_305740177
{
    public partial class FackebookApp
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
            this.buttonlogin = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.Buttonpost = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.linkFriends = new System.Windows.Forms.LinkLabel();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.labelEvents = new System.Windows.Forms.LinkLabel();
            this.linkPages = new System.Windows.Forms.LinkLabel();
            this.buttonFindMyLove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(25, 22);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(109, 26);
            this.buttonlogin.TabIndex = 0;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click_1);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(446, 59);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(352, 82);
            this.listBoxPosts.TabIndex = 1;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Buttonpost
            // 
            this.Buttonpost.AutoSize = true;
            this.Buttonpost.Location = new System.Drawing.Point(355, 22);
            this.Buttonpost.Name = "Buttonpost";
            this.Buttonpost.Size = new System.Drawing.Size(28, 13);
            this.Buttonpost.TabIndex = 2;
            this.Buttonpost.Text = "Post";
            // 
            // userPictureBox
            // 
            this.userPictureBox.Location = new System.Drawing.Point(162, 18);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(187, 88);
            this.userPictureBox.TabIndex = 3;
            this.userPictureBox.TabStop = false;
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Location = new System.Drawing.Point(632, 18);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(98, 24);
            this.buttonSetStatus.TabIndex = 4;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(388, 22);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(228, 20);
            this.textBoxStatus.TabIndex = 5;
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(25, 204);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(188, 82);
            this.listBoxPages.TabIndex = 6;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(25, 112);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(139, 69);
            this.listBoxFriends.TabIndex = 8;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(446, 154);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(246, 56);
            this.listBoxEvents.TabIndex = 9;
            // 
            // linkFriends
            // 
            this.linkFriends.AutoSize = true;
            this.linkFriends.Location = new System.Drawing.Point(170, 112);
            this.linkFriends.Name = "linkFriends";
            this.linkFriends.Size = new System.Drawing.Size(246, 13);
            this.linkFriends.TabIndex = 10;
            this.linkFriends.TabStop = true;
            this.linkFriends.Text = "Fetch Friends (Only friends who also use this app..)";
            this.linkFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFriends_LinkClicked);
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.Location = new System.Drawing.Point(805, 59);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(63, 13);
            this.linkPosts.TabIndex = 11;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch Posts";
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Location = new System.Drawing.Point(699, 154);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(73, 13);
            this.labelEvents.TabIndex = 12;
            this.labelEvents.TabStop = true;
            this.labelEvents.Text = "Fetch Events ";
            this.labelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelEvents_LinkClicked);
            // 
            // linkPages
            // 
            this.linkPages.AutoSize = true;
            this.linkPages.Location = new System.Drawing.Point(219, 204);
            this.linkPages.Name = "linkPages";
            this.linkPages.Size = new System.Drawing.Size(99, 13);
            this.linkPages.TabIndex = 13;
            this.linkPages.TabStop = true;
            this.linkPages.Text = "Fetch Liked Pages ";
            this.linkPages.Click += new System.EventHandler(this.linkPages_LinkClicked);
            // 
            // buttonFindMyLove
            // 
            this.buttonFindMyLove.Font = new System.Drawing.Font("Miriam", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFindMyLove.ForeColor = System.Drawing.Color.Red;
            this.buttonFindMyLove.Location = new System.Drawing.Point(448, 229);
            this.buttonFindMyLove.Name = "buttonFindMyLove";
            this.buttonFindMyLove.Size = new System.Drawing.Size(243, 42);
            this.buttonFindMyLove.TabIndex = 14;
            this.buttonFindMyLove.Text = "FindMyLove!";
            this.buttonFindMyLove.UseVisualStyleBackColor = true;
            this.buttonFindMyLove.Click += new System.EventHandler(this.buttonFindMyLove_Click);
            // 
            // FackebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 325);
            this.Controls.Add(this.buttonFindMyLove);
            this.Controls.Add(this.linkPages);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.linkPosts);
            this.Controls.Add(this.linkFriends);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.Buttonpost);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonlogin);
            this.Name = "FackebookApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FackebookApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label Buttonpost;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.LinkLabel linkFriends;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.LinkLabel labelEvents;
        private System.Windows.Forms.LinkLabel linkPages;
        private System.Windows.Forms.Button buttonFindMyLove;
    }
}
