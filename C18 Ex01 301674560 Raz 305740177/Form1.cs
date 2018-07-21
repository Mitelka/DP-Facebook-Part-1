using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C18_Ex01_301674560_Raz_305740177
{
    public partial class FackebookApp : Form
    {
        User m_LoggedInUser;
        AppId appId;

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
            LoginResult result = FacebookService.Login(appId.Value, "email");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            userPictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            if (m_LoggedInUser.Posts.Count > 0)
            {
                textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
            }
        }

        private void FackebookApp_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click_1(object sender, EventArgs e)
        {
            loginAndInit();
        }
    }
}
