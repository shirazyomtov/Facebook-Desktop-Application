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
    public partial class FriendsForm : Form
    {
        private readonly FriendsFilter r_FriendsFilter;
        private IEnumerator<FriendLogic> m_Iterator;

        public FriendsForm(FriendsFilter i_FriendsFilter)
        {
            r_FriendsFilter = i_FriendsFilter;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchFriends();
        }

        private void fetchFriends()
        {
            try
            {
                listBoxFriends.Items.Clear();
                listBoxFriends.DisplayMember = "Name";

                using (m_Iterator = r_FriendsFilter.GetEnumerator())
                {
                    while (m_Iterator.MoveNext())
                    {
                        listBoxFriends.Items.Add(m_Iterator.Current);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxFriends.Items.Count == 0)
            {
                MessageBox.Show("No friends to retrieve", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void FriendsForm_Load(object sender, EventArgs e)
        {
        }  
    }
}