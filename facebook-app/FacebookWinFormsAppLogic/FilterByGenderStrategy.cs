using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppLogic
{
    public class FilterByGenderStrategy : IMatchStrategy
    {
        private readonly User.eGender r_Gender;

        public FilterByGenderStrategy(User.eGender i_Gender)
        {
            r_Gender = i_Gender;
        }

        public bool CouldBeMatch(FriendLogic i_Friend)
        {
           return (int)i_Friend.UserFriend.Gender == (int)r_Gender;
        }
    }
}
