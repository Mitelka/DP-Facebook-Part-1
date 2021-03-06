﻿using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C18_Ex01_301674560_Raz_305740177
{
    public partial class FackebookApp : Form
    {
        private User m_LoggedInUser;
        private AppId appId;

        public User LoggedInUser { get => m_LoggedInUser; set => m_LoggedInUser = value; }

        public FackebookApp()
        {
            InitializeComponent();          
        }

        private void CrateAppID()
        {
            const string appIdValue = "1914992165220174";
            appId = new AppId(appIdValue);
        }

        private void loginAndInit()
        {
            CrateAppID();
            LoginResult result = FacebookService.Login(appId.Value, "email", "user_likes", "user_photos", "user_posts", "user_birthday", "user_events", "user_friends", "public_profile");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            userPictureBox.LoadAsync(LoggedInUser.PictureNormalURL);
            if (LoggedInUser.Posts.Count > 0)
            {
                textBoxStatus.Text = LoggedInUser.Posts[0].Message;
            }
        }

        private void FackebookApp_Load(object sender, EventArgs e)
        {
        }

        private void buttonlogin_Click_1(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = LoggedInUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch
            {
                MessageBox.Show("Facebook change the permission requirements for posting to pages...Not my fault");
            }
        }

        private void fetchPages()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";
            try
            {
                foreach (Page page in LoggedInUser.LikedPages)
                {
                    listBoxPages.Items.Add(page);
                }

                if (LoggedInUser.LikedPages.Count == 0)
                {
                    MessageBox.Show("No liked pages to retrieve :(");
                }
            }
            catch
            {
                MessageBox.Show("FaceBook Authorisation Issue");
            }
        }

        private void linkPages_LinkClicked(object sender, EventArgs e)
        {
            fetchPages();
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxPages.SelectedItem as Page;
            }
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Name));
                }
            }

            if (LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            foreach (User friend in LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void buttonFindMyLove_Click(object sender, EventArgs e)
        {
            new FindMyLove(LoggedInUser).Show();
        }
    }
}
