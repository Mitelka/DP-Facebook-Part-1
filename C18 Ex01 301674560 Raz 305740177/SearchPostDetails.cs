using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace PostsFilter
{
    public class SearchPostDetails
    {
        public User ChosenFriend { get; set; }
        private User m_ChosenFriend;
        public int Year { get; set; }
        private int m_Year;
        public bool HasPic { get; set; }
        private Boolean m_WithPic;
        private SelectedDate m_DateChosen;

        public SearchPostDetails()
        {
            m_DateChosen = new SelectedDate();
        }

        public User GetChosenFriend()
        {
            return ChosenFriend;
        }

        public int GetChosenDay()
        {
            return m_DateChosen.Day;
        }

        public int GetChosenMonth()
        {
            return m_DateChosen.Month;
        }

        public void SetSelectedDate(int i_Day, int i_Month)
        {
            m_DateChosen = new SelectedDate();
            m_DateChosen.Day = i_Day;
            m_DateChosen.Month = i_Month;

            //m_DateChosen.SetDay(i_Day);
            //m_DateChosen.SetMonth(i_Month);
        }

        public void SetChosenFriend(User i_Friend)
        {
            ChosenFriend = i_Friend;
        }
    }
}
