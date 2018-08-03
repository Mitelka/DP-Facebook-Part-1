using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C18_Ex01_301674560_Raz_305740177
{
    public partial class PickYourLoveForm : Form
    {
        private readonly List<User> m_Matches;

        public PickYourLoveForm(List<User> i_Matches)
        {
            InitializeComponent();
            m_Matches = i_Matches;
            showMatches();
        }

        private void PickYourLoveForm_Load(object sender, EventArgs e)
        {
        }

        private void showMatches()
        {
            matchesListbox.Items.Clear();
            matchesListbox.DisplayMember = "Name";
            foreach (var match in m_Matches)
            {
                matchesListbox.Items.Add(match);
            }
        }

        private void matchesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matchesListbox.SelectedItem != null)
            {
                var selcetedUser = matchesListbox.SelectedItem as User;
                profilePic.ImageLocation = selcetedUser.PictureNormalURL;
                profilePic.Load();
            }
        }
    }
}