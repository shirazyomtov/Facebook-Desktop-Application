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
    public partial class GroupsForm : Form
    {
        private readonly UserLogic r_LoggedInUser;

        public GroupsForm()
        {
            r_LoggedInUser = UserLogic.Instance;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchGroups();
        }

        private void fetchGroups()
        {
            try
            {
                groupBindingSource.DataSource = r_LoggedInUser.GroupsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
        }
    }
}