using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace PostsFilter
{
    public partial class ChooseFriendForm : Form
    {
        private User m_User;
        private User m_ChoosenFriend;
        private bool m_IsChoose;

        public ChooseFriendForm(User i_User)
        {
            m_User = i_User;
            InitializeComponent();
            showFriendsUsers();
        }

        public bool IsFriendChosen()
        {
            return m_IsChoose;
        }

        public User GetChoosenFriend()
        {
            return m_ChoosenFriend;
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            m_IsChoose = true;
            this.Close();
        }

        private void displaySelectedFriend()
        {
            User selectedFriend;

            if (friendBox.SelectedItems.Count == 1)
            {
                selectedFriend = friendBox.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    friendSelected.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    friendSelected.Image = friendSelected.ErrorImage;
                }
            }
        }

        private void showFriendsUsers()
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            friendBox.Items.Clear();
            friendBox.DisplayMember = "Name";
            foreach (User friend in m_User.Friends)
            {
                friendBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_User.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void friendBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseButton.Enabled = true;
            displaySelectedFriend();
        }
    }


}

