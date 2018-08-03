using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostsFilter
{
    public partial class PostsFilterMenu : Form
    {
        private User m_LoggedUser;
        private SearchPostDetails m_SearchPostDetails;
        private bool m_IsDate;
        private bool m_IsYear;
        private User m_ChoosenUserPopPic;

        public PostsFilterMenu(User i_User)
        {
            m_LoggedUser = i_User;
            m_SearchPostDetails = new SearchPostDetails();
            InitializeComponent();
            setProfilePic();
            setUsersBox();
        }

        private void setUsersBox()
        {
            FacebookObjectCollection<User> friendList = m_LoggedUser.Friends;

            usersListBox.DisplayMember = "Name";
            usersListBox.Items.Add(m_LoggedUser);
            foreach (User friend in friendList)
            {
                usersListBox.Items.Add(friend);
            }
        }


        private void setProfilePic()
        {
            this.profilePic.ImageLocation = this.m_LoggedUser.PictureNormalURL;
            this.profilePic.Load();
        }

        private void onShowPosts_Clicked(object sender, EventArgs e)
        {
            m_SearchPostDetails.HasPic = onlyWithPictures.Checked;
            new ResultPostForm(m_LoggedUser, m_SearchPostDetails).ShowDialog();
            setForNewSearch();
        }

        private void setForNewSearch()
        {
            m_IsDate = false;
            m_IsYear = false;
            year.Checked = false;
            date.Checked = false;
            withFriendsButton.Checked = false;
            onlyWithPictures.Checked = false;
            setUserInputDate(false);
            setUserInputYear(false);
        }

        private void setUserInputDate(bool i_IsVisible)
        {
            dayTextBox.Visible = i_IsVisible;
            dayTextBox.Text = "";
            monthTextBox.Visible = i_IsVisible;
            monthTextBox.Text = "";
            dayLabel.Visible = i_IsVisible;
            monthLabel.Visible = i_IsVisible;
            submitDate.Visible = i_IsVisible;
        }

        private void setUserInputYear(bool i_IsVisible)
        {
            Year2TextBox.Visible = i_IsVisible;
            Year2TextBox.Text = "";
            submitYear.Visible = i_IsVisible;
        }

        private void submitDate_Click(object sender, EventArgs e)
        {
            if (takeUserInputDate())
            {
                m_IsDate = true;
            }
            else
            {
                date.Checked = false;
            }

            setUserInputDate(false);
        }

        private bool takeUserInputDate()
        {
            bool res = false;

            if (takeUserInputDay() && takeUserInputMonth())
            {
                m_SearchPostDetails.SetSelectedDate(Int32.Parse(dayTextBox.Text)
                    , Int32.Parse(monthTextBox.Text));
                res = true;
            }

            return res;
        }

        private bool takeUserInputDay()
        {
            int day;
            bool res = false;

            if (Int32.TryParse(dayTextBox.Text, out day))
            {
                if (day > 0 && day <= 31)
                {
                    res = true;
                }
                else
                {
                    MessageBox.Show("Please enter legal day!");
                }
            }
            else
            {
                MessageBox.Show("Please enter numbers!");
            }

            return res;
        }

        private bool takeUserInputMonth()
        {
            int month;
            bool res = false;

            if (Int32.TryParse(monthTextBox.Text, out month))
            {
                if (month > 0 && month <= 12)
                {
                    res = true;
                }
                else
                {
                    MessageBox.Show("Please enter legal month!");
                }
            }
            else
            {
                MessageBox.Show("Please enter numbers!");
            }

            return res;
        }

        private bool takeUserInputYear()
        {
            int year;
            bool res = false;

            if (Int32.TryParse(Year2TextBox.Text, out year))
            {
                if (year > 0 && year <= 2018)
                {
                    m_SearchPostDetails.Year = year;
                    res = true;
                }
                else
                {
                    MessageBox.Show("Please enter legal year!");
                }
            }
            else
            {
                MessageBox.Show("Please enter numbers!");
            }

            return res;
        }

        private void submitYear_Click(object sender, EventArgs e)
        {
            if (takeUserInputYear())
            {
                m_IsYear = true;
            }
            else
            {
                year.Checked = false;
            }

            setUserInputYear(false);
        }

        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostPopPic.Enabled = true;
            m_ChoosenUserPopPic = usersListBox.SelectedItem as User;
        }

        private Photo setPopPic(User selected)
        {
            int mostPop = 0;
            Photo popPhoto = null;
            int picLikes;

            foreach (Album album in selected.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    picLikes = photo.LikedBy.Count;

                    if (mostPop < picLikes)
                    {
                        mostPop = picLikes;
                        popPhoto = photo;
                    }
                }
            }

            return popPhoto;
        }

        private void date_CheckedChanged(object sender, EventArgs e)
        {
            checkFillUserTextToggleYear();
            if (date.Checked)
            {
                setUserInputDate(true);
            }
            else
            {
                setUserInputDate(false);
            }
        }

        private void withFriendsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (withFriendsButton.Checked)
            {
                checkFillUserTextToggleDate();
                checkFillUserTextToggleYear();
                ChooseFriendForm choosenFriendForm = new ChooseFriendForm(m_LoggedUser);
                choosenFriendForm.ShowDialog();
                if (choosenFriendForm.IsFriendChosen())
                {
                    m_SearchPostDetails.SetChosenFriend(choosenFriendForm.GetChoosenFriend());
                }
                else
                {
                    withFriendsButton.Checked = false;
                }
            }
        }

        private void checkFillUserTextToggleDate()
        {
            if (!m_IsDate)
            {
                date.Checked = false;
            }
        }

        private void checkFillUserTextToggleYear()
        {
            if (!m_IsYear)
            {
                year.Checked = false;
            }
        }

        private void year_CheckedChanged(object sender, EventArgs e)
        {
            checkFillUserTextToggleDate();
            if (year.Checked)
            {
                setUserInputYear(true);
            }
            else
            {
                setUserInputYear(false);
            }
        }

        private void onlyWithPictures_CheckedChanged(object sender, EventArgs e)
        {
            checkFillUserTextToggleDate();
            checkFillUserTextToggleYear();
        }

        private void mostPopPic_Click(object sender, EventArgs e)
        {
            Photo mostPop = setPopPic(m_ChoosenUserPopPic);

            if (mostPop == null)
            {
                MessageBox.Show("no likes in selected person photos.");
            }
            else
            {
                popPic.ImageLocation = mostPop.PictureNormalURL;
                popPic.SizeMode = PictureBoxSizeMode.StretchImage;
                popPic.Load();
            }
        }
        
    }
}
