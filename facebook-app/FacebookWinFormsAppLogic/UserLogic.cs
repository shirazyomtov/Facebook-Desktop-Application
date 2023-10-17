using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppLogic
{
    public sealed class UserLogic
    {
        private static readonly object sr_CreationalLockContext = new object();
        private static UserLogic s_Instance = null;

        private UserLogic()
        {
        }

        public static UserLogic Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_CreationalLockContext)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new UserLogic();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public User LoggedInUser { get; set; }

        public string FirstName
        {
            get
            {
                return LoggedInUser.FirstName;
            }
        }

        public string LastName
        {
            get
            {
                return LoggedInUser.LastName;
            }
        }

        public string ProfilePictureURL
        { 
            get
            {
                return LoggedInUser.PictureNormalURL;
            }
        }

        public User.eRelationshipStatus? RelationshipStatus 
        {
            get
            {
                return LoggedInUser.RelationshipStatus;
            }
        }

        public int Age
        {
            get
            {
                return FacebookWinFormsAppLogic.Age.GetAge(LoggedInUser.Birthday);
            }
        }

        public FacebookObjectCollection<Post> PostsList
        {
            get
            {
                return getPostList();
            }
        }

        public FacebookObjectCollection<Album> AlbumsList
        {
            get
            {
                return getAlbumsList();
            }
        }

        public FacebookObjectCollection<Group> GroupsList
        {
            get
            {
                return getGroupsList();
            }
        }

        public FacebookObjectCollection<Page> LikesPagesList
        {
            get
            {
                return getLikePagesList();
            }
        }

        public List<FriendLogic> FriendsList
        {
            get
            {
                return getFriendsList();
            }
        }

        private List<FriendLogic> getFriendsList()
        {
            List<FriendLogic> friendsList = new List<FriendLogic>();

            if (LoggedInUser != null)
            {
                try
                {
                    foreach (User friend in LoggedInUser.Friends)
                    {
                        friendsList.Add(new FriendLogic(friend));
                    }
                }
                catch (Exception)
                {
                    throw new Exception("You do not have permissions to get posts of the user");
                }
            }

            return friendsList;
        }

        private FacebookObjectCollection<Post> getPostList()
        {
            FacebookObjectCollection<Post> posts = null;

            if (LoggedInUser != null)
            {
                try
                {
                    posts = LoggedInUser.Posts;
                }
                catch (Exception)
                {
                    throw new Exception("You do not have permissions to get posts of the user");
                }
            }

            return posts;
        }

        private FacebookObjectCollection<Group> getGroupsList()
        {
            FacebookObjectCollection<Group> groups = null;

            if (LoggedInUser != null)
            {
                try
                {
                    groups = LoggedInUser.Groups;
                }
                catch (Exception)
                {
                    throw new Exception("You do not have permissions to get list of the groups");
                }
            }

            return groups;
        }

        private FacebookObjectCollection<Album> getAlbumsList()
        {
            FacebookObjectCollection<Album> albums = null;

            if (LoggedInUser != null)
            {
                try
                {
                    albums = LoggedInUser.Albums;
                }
                catch (Exception)
                {
                    throw new Exception("You do not have permissions to get list of the albums");
                }
            }

            return albums;
        }

       private FacebookObjectCollection<Page> getLikePagesList()
        {
            FacebookObjectCollection<Page> likesPages = null;

            if (LoggedInUser != null)
            {
                try
                {
                    likesPages = LoggedInUser.LikedPages;
                }
                catch (Exception)
                {
                    throw new Exception("You do not have permissions to get list of the like pages");
                }
            }

            return likesPages;
        }
    }
}