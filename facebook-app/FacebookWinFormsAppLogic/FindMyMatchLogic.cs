using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppLogic
{
    public class FindMyMatchLogic
    {
        private readonly int r_MinAge;
        private readonly int r_MaxAge;
        private Dictionary<FriendLogic, int> m_DictOfOpitionalMatches = new Dictionary<FriendLogic, int>();

        public FindMyMatchLogic(int i_MinAge, int i_MaxAge)
        {
            matchStrategyList = new List<IMatchStrategy>();
            r_MinAge = i_MinAge;
            r_MaxAge = i_MaxAge;
        }

        public List<IMatchStrategy> matchStrategyList { get; set; }

        public IOrderedEnumerable<KeyValuePair<FriendLogic, int>> GetListOfOpitionalMatchesSortedByTheHighestMatch(
                                                                                                                    List<FriendLogic> i_FriendsList, 
                                                                                                                    FacebookObjectCollection<Page> i_LikesPagesList, 
                                                                                                                    FacebookObjectCollection<Post> i_PostsList, 
                                                                                                                    FacebookObjectCollection<Group> i_GroupsList)
        {
            List<FriendLogic> listOfOpitionalMatchesWithoutSorted = GetListOfOpitionalMatchesWithoutSorted(i_FriendsList);
            int numberOfGroupsThatCommon = 0;
            int numberOfLikesThatYourFriendGaveYou = 0;
            int numberOfLikesPagesThatCommon = 0;
            int totalNumberOfThingsInCommon = 0;

            foreach (FriendLogic friend in listOfOpitionalMatchesWithoutSorted)
            {
                numberOfGroupsThatCommon = GetNumberOfCommonGroup(friend, i_GroupsList);
                numberOfLikesThatYourFriendGaveYou = GetNumberOfLikesThatYourFriendGaveYou(friend, i_PostsList);
                numberOfLikesPagesThatCommon = GetNumberOfCommonLikesPages(friend, i_LikesPagesList);
                totalNumberOfThingsInCommon = numberOfGroupsThatCommon + numberOfLikesThatYourFriendGaveYou + numberOfLikesPagesThatCommon;
                m_DictOfOpitionalMatches.Add(friend, totalNumberOfThingsInCommon);
            }

            var opitionalMatchesSortedByTheHighestMatch = from entry in m_DictOfOpitionalMatches orderby entry.Value descending select entry;

            return opitionalMatchesSortedByTheHighestMatch;
        }

        public int GetNumberOfCommonLikesPages(FriendLogic i_Friend, FacebookObjectCollection<Page> i_LikesPagesList)
        {
            int numberOfLikesPagesThatCommon = 0;

            foreach (Page pageFriend in i_Friend.UserFriend.LikedPages)
            {
                foreach (Page myPage in i_LikesPagesList)
                {
                    if (pageFriend.Id == myPage.Id)
                    {
                        numberOfLikesPagesThatCommon++;
                    }
                }
            }

            return numberOfLikesPagesThatCommon;
        }

        public int GetNumberOfLikesThatYourFriendGaveYou(FriendLogic i_Friend, FacebookObjectCollection<Post> i_PostsList)
        {
            int numberOfLikesThatYourFriendGaveYou = 0;

            foreach (Post post in i_PostsList)
            {
                foreach (User friend in post.LikedBy)
                {
                   if (friend.Id == i_Friend.UserFriend.Id)
                   {
                        numberOfLikesThatYourFriendGaveYou++;
                   }
                }
            }

            return numberOfLikesThatYourFriendGaveYou;
        }

        public int GetNumberOfCommonGroup(FriendLogic i_Friend, FacebookObjectCollection<Group> i_GroupsList)
        {
            int numberOfGroupsThatCommon = 0;

            foreach (Group groupFriend in i_Friend.UserFriend.Groups)
            {
                foreach (Group myGroup in i_GroupsList)
                {
                    if (groupFriend.Id == myGroup.Id)
                    {
                        numberOfGroupsThatCommon++;
                    }
                }
            }

            return numberOfGroupsThatCommon;
        }

        public List<FriendLogic> GetListOfOpitionalMatchesWithoutSorted(List<FriendLogic> i_FriendsList)
        {
            List<FriendLogic> userFriends = new List<FriendLogic>();
            bool isCouldBeMatch = true;
            
            foreach (FriendLogic friend in i_FriendsList)
            {
                foreach (IMatchStrategy matchStrategy in matchStrategyList)
                {
                    if (!matchStrategy.CouldBeMatch(friend))
                    {
                        isCouldBeMatch = false;
                        break;
                    }
                }

                if (isCouldBeMatch || matchStrategyList.Count == 0)
                {
                    if ((friend.Age >= r_MinAge && friend.Age <= r_MaxAge) && checkIfTheFriendNotInRelationship(friend))
                    {
                        userFriends.Add(friend);
                    }
                }

                isCouldBeMatch = true;
            }

            return userFriends;
        }

        private bool checkIfTheFriendNotInRelationship(FriendLogic i_Friend)
        {
            bool notInRelationship = false;

            if (i_Friend.UserFriend.RelationshipStatus != User.eRelationshipStatus.InARelationship &&
                i_Friend.UserFriend.RelationshipStatus != User.eRelationshipStatus.Married &&
                i_Friend.UserFriend.RelationshipStatus != User.eRelationshipStatus.Enagaged)
            {
                notInRelationship = true;
            }

            return notInRelationship;
        }
    }
}