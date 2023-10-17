using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppLogic
{
    public class FriendsFilter : IEnumerable<FriendLogic>
    {
        private readonly List<FriendLogic> r_Friends = new List<FriendLogic>();

        public Func<FriendLogic, bool> FilterTest { get; set; }

        public FriendsFilter()
        {
            r_Friends = UserLogic.Instance.FriendsList;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<FriendLogic> GetEnumerator()
        {
            foreach (FriendLogic friend in r_Friends)
            {
                if (FilterTest.Invoke(friend))
                {
                    yield return friend;
                }
            }
        }
    }
}