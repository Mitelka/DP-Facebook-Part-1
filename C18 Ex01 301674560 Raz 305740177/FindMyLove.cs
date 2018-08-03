using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using static FacebookWrapper.ObjectModel.User;

namespace C18_Ex01_301674560_Raz_305740177
{
    public partial class FindMyLove : Form
    {
        private eGender m_Gender;

        public FindMyLove(User i_LoggedInUser)
        {
            InitializeComponent();
            LoggedInUser = i_LoggedInUser;
            showProfilePic();
            fromTrack.Minimum = 18;
            fromTrack.Maximum = 99;
            ToTrackBar.Minimum = 18;
            ToTrackBar.Maximum = 99;
        }

        public User LoggedInUser { get; set; }

        private void showProfilePic()
        {
            profilePic.ImageLocation = LoggedInUser.PictureNormalURL;
            profilePic.Load();
        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            m_Gender = eGender.female;
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            m_Gender = eGender.male;
        }

        private void fromTrack_Scroll(object sender, EventArgs e)
        {
            fromRangeChosen.Text = fromTrack.Value.ToString();
        }

        private void ToTrackBar_Scroll(object sender, EventArgs e)
        {
            maxRangeChosen.Text = ToTrackBar.Value.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var isAgeValid = checkAgeValidation();
            var matches = new List<User>();
            if (!isAgeValid)
            {
                MessageBox.Show("Please choose a valid range age!");
            }
            else
            {
                foreach (var friend in LoggedInUser.Friends)
                {
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    if (checkIfMatch(friend))
                    {
                        matches.Add(friend);
                    }
                }

                if (matches.Count > 0)
                {
                    new PickYourLoveForm(matches).Show();
                }
                else
                {
                    MessageBox.Show("You don't have any matches... Sorry :(");
                }
            }
        }

        private bool checkIfMatch(User i_User)
        {
            var isMatch = true;
            if (i_User.Gender != m_Gender)
            {
                isMatch = false;
            }

            if (isMatch)
            {
                var today = DateTime.Today;
                var cultureDateTime = new CultureInfo("en-US");
                var birthdayUser = Convert.ToDateTime(i_User.Birthday, cultureDateTime);
                var age = today.Year - birthdayUser.Year;
                today.AddYears(-age);
                if (DateTime.Compare(birthdayUser, today) > 0)
                {
                    age--;
                }

                if (age < fromTrack.Value || age > ToTrackBar.Value)
                {
                    isMatch = false;
                }
            }

            return isMatch;
        }

        private bool checkAgeValidation()
        {
            var isValid = false;
            if (fromTrack.Value <= ToTrackBar.Value)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}