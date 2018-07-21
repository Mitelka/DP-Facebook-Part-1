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
    public partial class FindMyLove : Form
    {
        private User m_LoggedInUser;
        public FindMyLove(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            showProfilePic();
        }

        private void showProfilePic()
        {
            profilePic.ImageLocation = m_LoggedInUser.PictureNormalURL;
            profilePic.Load();
        }
    }
}
