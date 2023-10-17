using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookWinFormsAppLogic;

namespace BasicFacebookFeatures
{
    public partial class SelectedMatchForm : Form
    {
        private readonly FriendLogic r_SelectedMatch;
        private readonly FindMyMatchFacade r_FindMyMatchFacade;
        private List<Photo> m_PhotoList = null;
        private int m_IndexUserPhotos = 0;
        
        public SelectedMatchForm(FriendLogic i_SelectedMatch, FindMyMatchFacade i_FindMyMatchFacade)
        {
            r_SelectedMatch = i_SelectedMatch;
            r_FindMyMatchFacade = i_FindMyMatchFacade;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchMyOptionalMatchInfo).Start();
        }

        private void fetchMyOptionalMatchInfo()
        {
            m_IndexUserPhotos = 0;
            m_PhotoList = r_SelectedMatch.AllUserPictures;
            labelName.Invoke(new Action(() => labelName.Text = string.Format("{0} {1}", r_SelectedMatch.UserFriend.FirstName, r_SelectedMatch.UserFriend.LastName)));
            labelBirthday.Invoke(new Action(() => labelBirthday.Text = r_SelectedMatch.UserFriend.Birthday));
            labelGender.Invoke(new Action(() => labelGender.Text = r_SelectedMatch.UserFriend.Gender.ToString()));
            labelLocation.Invoke(new Action(() => labelLocation.Text = r_SelectedMatch.UserFriend.Location.Name));
            textBoxNumberOfCommonGroups.Invoke(new Action(() => 
            textBoxNumberOfCommonGroups.Text = r_FindMyMatchFacade.GetNumberOfGroupsThatCommonBetweenYouAndYourFriend(r_SelectedMatch).ToString()));
            textBoxNumberOfCommonLikesPages.Invoke(new Action(() => 
            textBoxNumberOfCommonLikesPages.Text = r_FindMyMatchFacade.GetNumberOfLikesPagesThatCommonBetweenYouAndYourFriend(r_SelectedMatch).ToString()));
            textBoxNumberOfLikesThatTheFriendGaveYou.Invoke(new Action(() => 
            textBoxNumberOfLikesThatTheFriendGaveYou.Text = r_FindMyMatchFacade.GetNumberOfLikesThatYourFriendGaveYouOnYourPosts(r_SelectedMatch).ToString()));
            pictureBoxCoverPhoto.LoadAsync(r_SelectedMatch.UserFriend.PictureNormalURL);
            new Thread(passingThroughThePictures).Start();
        }

        private void passingThroughThePictures()
        {
            try
            {
                Photo photo = m_PhotoList[m_IndexUserPhotos];
                pictureBoxPhoto.LoadAsync(photo.PictureAlbumURL);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            m_IndexUserPhotos--;
            passingThroughThePictures();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            m_IndexUserPhotos++;
            passingThroughThePictures();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MyOptionalMatch_Load(object sender, EventArgs e)
        {
        }
    }
}