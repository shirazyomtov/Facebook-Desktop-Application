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
    public partial class LikesPagesForm : Form
    {
        private readonly UserLogic r_LoggedInUser;

        public LikesPagesForm()
        {
            r_LoggedInUser = UserLogic.Instance;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            try
            {   
               pageBindingSource.DataSource = r_LoggedInUser.LikesPagesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxLikesPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LikesPagesForm_Load(object sender, EventArgs e)
        {
        }
    }
}