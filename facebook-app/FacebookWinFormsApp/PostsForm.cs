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
    public partial class PostsForm : Form
    {
        private readonly UserLogic r_LoggedInUser;

        public PostsForm()
        {
            r_LoggedInUser = UserLogic.Instance;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchPosts).Start();
        }

        private void fetchPosts()
        {
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
            listBoxPosts.Invoke(new Action(() => listBoxPosts.DisplayMember = "Name"));
            try
            {
                foreach (Post post in r_LoggedInUser.PostsList)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                    }
                    else if (post.Caption != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                    }
                    else
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           buttonBack.Invoke(new Action(() => buttonBack.Enabled = true));
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = r_LoggedInUser.PostsList[listBoxPosts.SelectedIndex];

            labelComments.Visible = true;
            listBoxPostComments.Visible = true;
            listBoxPostComments.DisplayMember = "Message";
            listBoxPostComments.DataSource = selected.Comments;
            if (selected.PictureURL != null)
            {
                pictureBoxPost.LoadAsync(selected.PictureURL);
            }
            else
            {
                pictureBoxPost.Image = null;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PostsForm_Load(object sender, EventArgs e)
        {
        }
    }
}