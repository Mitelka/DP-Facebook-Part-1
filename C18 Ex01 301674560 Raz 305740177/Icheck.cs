using FacebookWrapper.ObjectModel;

namespace PostsFilter
{
    public interface ICheck
    {
        bool Check(Post i_Post, SearchPostDetails i_Details);
    }

    public class DateChecker : ICheck
    {
        public bool Check(Post i_Post, SearchPostDetails i_Details)
        {
            bool isDay;
            bool isMonth;
            var date = i_Post.CreatedTime.Value;

            isDay = date.Day.CompareTo(i_Details.GetChosenDay()) == 0;
            isMonth = date.Month.CompareTo(i_Details.GetChosenMonth()) == 0;

            return isDay && isMonth;
        }
    }

    public class YearChecker : ICheck
    {
        public bool Check(Post i_Post, SearchPostDetails i_Details)
        {
            var date = i_Post.CreatedTime.Value;

            return date.Year.CompareTo(i_Details.Year) == 0;
        }
    }

    public class FriendChecker : ICheck
    {
        public bool Check(Post i_Post, SearchPostDetails i_Details)
        {
            var res = false;
            var postUsers = i_Post.TaggedUsers;

            foreach (var user in postUsers)
            {
                if (user.Equals(i_Details.GetChosenFriend()))
                {
                    res = true;
                    break;
                }
            }

            return res;
        }
    }

    public class PicChecker : ICheck
    {
        public bool Check(Post i_Post, SearchPostDetails i_Details)
        {
            var res = false;
            var picUrl = i_Post.PictureURL;

            if (picUrl != null)
            {
                res = true;
            }

            return res;
        }
    }
}