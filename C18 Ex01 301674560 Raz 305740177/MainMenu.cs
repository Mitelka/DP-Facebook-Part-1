using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using PostsFilter;

namespace C18_Ex01_301674560_Raz_305740177
{
    public partial class MainMenu : Form
    {
        public enum LoggedInfo
        {
            Login,
            Logout
        }

        private AppId appId;

        public MainMenu()
        {
            InitializeComponent();
        }

        public User LoggedInUser { get; set; }

        private void CrateAppID()
        {
            const string appIdValue = "1914992165220174";
            appId = new AppId(appIdValue);
        }

        private void loginAndInit()
        {
            CrateAppID();
            var result = FacebookService.Login(appId.Value, "email", "user_likes", "user_photos", "user_posts",
                "user_birthday", "user_events", "user_friends", "public_profile");


            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                buttonlogin.Text = LoggedInfo.Logout.ToString();
                LoggedInUser = result.LoggedInUser;
                try
                {
                    updateProfilePic();
                }
                catch (Exception e)
                {
                    MessageBox.Show("There was some error loading the profile Picture!");
                }
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void updateProfilePic()
        {
            userPictureBox.LoadAsync(LoggedInUser.PictureNormalURL);
            userName.Text = "Welcome " + LoggedInUser.FirstName;
            userName.Visible = true;
           
            
        }

        private void logOut()
        {
            FacebookService.Logout(() => { MessageBox.Show("You have succesfully logged out!"); });
            buttonlogin.Text = LoggedInfo.Login.ToString();
            LoggedInUser = null;
            userPictureBox.ImageLocation = null;
            userName.Text = "";
            userName.Visible = false;
        }


        private void FackebookApp_Load(object sender, EventArgs e)
        {
        }

        private void buttonlogin_Click_1(object sender, EventArgs e)
        {
            switch (buttonlogin.Text)
            {
                case "Login":
                    loginAndInit();
                    break;
                case "Logout":
                    logOut();
                    break;
            }
        }


        private void buttonFindMyLove_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
                new FindMyLove(LoggedInUser).Show();
            else
                MessageBox.Show("You have to login first!");
        }

        private void postsFilterbtn_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
                new PostsFilterMenu(LoggedInUser).Show();
            else
                MessageBox.Show("You have to login first!");
        }

        private void userName_Click(object sender, EventArgs e)
        {

        }
    }
}