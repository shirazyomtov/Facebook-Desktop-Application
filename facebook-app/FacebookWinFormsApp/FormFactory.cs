using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookWinFormsAppLogic;

namespace BasicFacebookFeatures
{
    public static class FormFactory
    {
        public enum eFormType
        {
            LoginForm = 0,
            MainForm = 1,
            FindMyMatchForm = 2,
            MyOptionalMatchesForm = 3,
            SelectedMatchForm = 4,
            LikesPagesForm = 5,
            PostsForm = 6,
            GroupsForm = 7,
            FriendsFilterForm = 8,
            FriendsForm = 9,
            AlbumsForm = 10,
            AlbumStatisticsByYearOrMonthForm = 11
        }

        public static Form CreateForm(
                                      eFormType i_FormType,
                                      FriendLogic i_SelectedMatch = null,
                                      FindMyMatchFacade i_FindMyMatchFacade = null,
                                      FriendsFilter i_FriendsFilter = null,
                                      Album i_Album = null, 
                                      bool i_IsYear = false)
        {
            Form selectedForm = null;

            switch (i_FormType)
            {
                case eFormType.LoginForm:
                    {
                        selectedForm = new LoginForm();
                        break;
                    }

                case eFormType.MainForm:
                    {
                        selectedForm = new MainForm();
                        break;
                    }

                case eFormType.FindMyMatchForm:
                    {
                        selectedForm = new FindMyMatchForm();
                        break;
                    }

                case eFormType.MyOptionalMatchesForm:
                    {
                        selectedForm = new MyOptionalMatchesForm(i_FindMyMatchFacade);
                        break;
                    }

                case eFormType.SelectedMatchForm:
                    {
                        selectedForm = new SelectedMatchForm(i_SelectedMatch, i_FindMyMatchFacade);
                        break;
                    }

                case eFormType.LikesPagesForm:
                    {
                        selectedForm = new LikesPagesForm();
                        break;
                    }

                case eFormType.PostsForm:
                    {
                        selectedForm = new PostsForm();
                        break;
                    }

                case eFormType.GroupsForm:
                    {
                        selectedForm = new GroupsForm();
                        break;
                    }

                case eFormType.FriendsFilterForm:
                    {
                        selectedForm = new FriendsFilterForm();
                        break;
                    }

                case eFormType.FriendsForm:
                    {
                        selectedForm = new FriendsForm(i_FriendsFilter);
                        break;
                    }

                case eFormType.AlbumsForm:
                    {
                        selectedForm = new AlbumsForm();
                        break;
                    }

                case eFormType.AlbumStatisticsByYearOrMonthForm:
                    {
                        if (i_IsYear)
                        {
                           selectedForm = new AlbumStatisticsByYearsForm(i_Album);
                        }
                        else
                        {
                            selectedForm = new AlbumStatisticsByMonthsForm(i_Album);
                        }

                        break;
                    }
            }

            return selectedForm;
        }
    }
}