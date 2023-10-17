using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppLogic
{
    public class FindMyMatchFacade
    {
        private readonly UserLogic r_LoggedInUser;
        private FindMyMatchLogic m_FindMyMatchLogic;

        public FindMyMatchFacade(int i_MinAge, int i_MaxAge)
        {
            r_LoggedInUser = UserLogic.Instance;
            m_FindMyMatchLogic = new FindMyMatchLogic(i_MinAge, i_MaxAge);
        }

        public IOrderedEnumerable<KeyValuePair<FriendLogic, int>> OpitionalMatchesSortedByTheHighestMatch
        {
            get
            {
                return m_FindMyMatchLogic.GetListOfOpitionalMatchesSortedByTheHighestMatch(
                                                                                           r_LoggedInUser.FriendsList, 
                                                                                           r_LoggedInUser.LikesPagesList, 
                                                                                           r_LoggedInUser.PostsList, 
                                                                                           r_LoggedInUser.GroupsList);
            }
        }

        public List<FriendLogic> OpitionalMatchesWithoutSorted
        {
            get
            {
                return m_FindMyMatchLogic.GetListOfOpitionalMatchesWithoutSorted(r_LoggedInUser.FriendsList);
            }
        }

        public int GetNumberOfLikesPagesThatCommonBetweenYouAndYourFriend(FriendLogic i_Friend)
        {
            return m_FindMyMatchLogic.GetNumberOfCommonLikesPages(i_Friend, r_LoggedInUser.LikesPagesList);
        }

        public int GetNumberOfLikesThatYourFriendGaveYouOnYourPosts(FriendLogic i_Friend)
        {
            return m_FindMyMatchLogic.GetNumberOfLikesThatYourFriendGaveYou(i_Friend, r_LoggedInUser.PostsList);
        }

        public int GetNumberOfGroupsThatCommonBetweenYouAndYourFriend(FriendLogic i_Friend)
        {
            return m_FindMyMatchLogic.GetNumberOfCommonGroup(i_Friend, r_LoggedInUser.GroupsList);
        }

        public void FilterByGender(User.eGender i_Gender)
        {
            m_FindMyMatchLogic.matchStrategyList.Add(new FilterByGenderStrategy(i_Gender));
        }

        public void FilterByCities(List<string> i_Cities)
        {
            m_FindMyMatchLogic.matchStrategyList.Add(new FilterByCitiesStrategy(i_Cities));
        }
    }
}