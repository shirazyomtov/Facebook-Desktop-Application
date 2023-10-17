using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookWinFormsAppLogic;

namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc");

            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                    "1098016427777315",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos",
                    "groups_access_member_info",
                    "pages_read_engagement");
            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                UserLogic loggedInUser = UserLogic.Instance;
                loggedInUser.LoggedInUser = loginResult.LoggedInUser;
                Form mainAppForm = FormFactory.CreateForm(i_FormType: FormFactory.eFormType.MainForm);
                mainAppForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(loginResult.ErrorMessage, "Login Failed");
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }
    }
}