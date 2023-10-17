using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppLogic
{
    public class FriendLogic
    {
        public FriendLogic(User i_Friend)
        {
            UserFriend = i_Friend;
        }

        public User UserFriend { get; }

        public int Age
        {
            get
            {
                return FacebookWinFormsAppLogic.Age.GetAge(UserFriend.Birthday);
            }
        }

        public List<Photo> AllUserPictures
        {
            get
            {
                return getAllFriendPictures();
            }
        }

        private List<Photo> getAllFriendPictures()
        {
            List<Photo> photoList = new List<Photo>();

            if (UserFriend != null)
            {
                try
                {
                    foreach (Album album in UserFriend.Albums)
                    {
                        foreach (Photo photo in album.Photos)
                        {
                            photoList.Add(photo);
                        }
                    }
                }
                catch
                {
                    throw new Exception("You do not have permissions to get list of the photos of the user");
                }
            }

            return photoList;
        }
    }
}