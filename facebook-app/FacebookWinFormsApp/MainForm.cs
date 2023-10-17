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
    public partial class MainForm : Form
    {
        private readonly UserLogic r_LoggedInUser;

        public MainForm()
        {
            r_LoggedInUser = UserLogic.Instance;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            setTheUserInfo();
        }

        private void setTheUserInfo()
        {
            userBindingSource.DataSource = r_LoggedInUser.LoggedInUser;
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            Form groupForm = FormFactory.CreateForm(i_FormType: FormFactory.eFormType.GroupsForm);
            groupForm.ShowDialog();
            Show();
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            Form postsForm = FormFactory.CreateForm(i_FormType: FormFactory.eFormType.PostsForm);
            postsForm.ShowDialog();
            Show();
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            Form friendsFilterByGenderForm = FormFactory.CreateForm(i_FormType: FormFactory.eFormType.FriendsFilterForm);
            friendsFilterByGenderForm.ShowDialog();
            Show();
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            Form albumsForm = FormFactory.CreateForm(i_FormType: FormFactory.eFormType.AlbumsForm);
            albumsForm.ShowDialog();
            Show();
        }

        private void buttonLikesPages_Click(object sender, EventArgs e)
        {
            Form likePagesForm = FormFactory.CreateForm(i_FormType: FormFactory.eFormType.LikesPagesForm);
            likePagesForm.ShowDialog();
            Show();
        }

        private void buttonFindMyMatch_Click(object sender, EventArgs e)
        {
            if (r_LoggedInUser.RelationshipStatus != User.eRelationshipStatus.InARelationship &&
                r_LoggedInUser.RelationshipStatus != User.eRelationshipStatus.Married &&
                r_LoggedInUser.RelationshipStatus != User.eRelationshipStatus.Enagaged)
            {
                Form findMyMatchForm = FormFactory.CreateForm(i_FormType: FormFactory.eFormType.FindMyMatchForm);
                findMyMatchForm.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("You are in a relationship", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}