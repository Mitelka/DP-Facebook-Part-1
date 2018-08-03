using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;
namespace PostsFilter
{
    public partial class ResultPostForm : Form
    {
        private User m_LoggedInUser;
        private SearchPostDetails m_SerchDetails;
        private List<ICheck> m_Checkers;
        private List<Post> m_Posts;

        public ResultPostForm(User i_User, SearchPostDetails i_Res)
        {
            m_LoggedInUser = i_User;
            m_SerchDetails = i_Res;
            m_Checkers = new List<ICheck>();
            m_Posts = new List<Post>();

            setCheckers();
            InitializeComponent();
            setUserPosts();
            printUserPosts();
        }

        private void printUserPosts()
        {
            postListBox.Items.Clear();
            postListBox.DisplayMember = "Message";

            foreach (Post post in m_Posts)
            {
                postListBox.Items.Add(post);
            }

            if (m_Posts.Count == 0)
            {
                MessageBox.Show("No Posts Found!");
            }
        }

        private void setCheckers()
        {
            if (m_SerchDetails.Year != 0)
            {
                m_Checkers.Add(new YearChecker());
            }

            if (m_SerchDetails.GetChosenDay() != 0)
            {
                m_Checkers.Add(new DateChecker());
            }

            if (m_SerchDetails.HasPic)
            {
                m_Checkers.Add(new PicChecker());
            }

            if (m_SerchDetails.GetChosenFriend() != null)
            {
                m_Checkers.Add(new FriendChecker());
            }
        }

        private void setUserPosts()
        {
            FacebookObjectCollection<Post> allPosts = m_LoggedInUser.Posts;
            bool isFoundPost = true;

            foreach (Post post in allPosts)
            {
                foreach (ICheck checker in m_Checkers)
                {
                    if (!checker.Check(post, m_SerchDetails))
                    {
                        isFoundPost = false;
                        break;
                    }
                }

                if (isFoundPost)
                {
                    m_Posts.Add(post);
                }

                isFoundPost = true;
            }
        }

        private void postListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selectedPost;

            if (postListBox.SelectedItems.Count == 1)
            {
                selectedPost = postListBox.SelectedItem as Post;

                if (selectedPost.PictureURL == null)
                {
                    postPic.ImageLocation = "http://wfpl.org/wp-content/plugins/lightbox/images/No-image-found.jpg";
                }
                else
                {
                    postPic.ImageLocation = selectedPost.PictureURL;
                }

                postPic.SizeMode = PictureBoxSizeMode.StretchImage;
                postPic.Load();
            }
        }
    }
}
