using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppLogic
{
    public class FilterByCitiesStrategy : IMatchStrategy
    {
        private readonly List<string> r_Cities;

        public FilterByCitiesStrategy(List<string> i_Cities)
        {
            r_Cities = i_Cities;
        }

        public bool CouldBeMatch(FriendLogic i_Friend)
        {
            bool isExistsInCitiesList = false;

            foreach (string nameCity in r_Cities)
            {
                if (nameCity.Equals(i_Friend.UserFriend.Location.Name))
                {
                    isExistsInCitiesList = true;
                    break;
                }
            }

            return isExistsInCitiesList;
        }
    }
}
