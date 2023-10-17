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
    public partial class FriendsFilterForm : Form
    {
        private FriendsFilter m_FriendsFilter;

        public FriendsFilterForm()
        {
            m_FriendsFilter = new FriendsFilter();
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                m_FriendsFilter.FilterTest = i_Friend => (int)i_Friend.UserFriend.Gender == (int)User.eGender.male;
            }
            else if (radioButtonFemale.Checked)
            {
                m_FriendsFilter.FilterTest = i_Friend => (int)i_Friend.UserFriend.Gender == (int)User.eGender.female;
            }
            else
            {
                m_FriendsFilter.FilterTest = i_Friend => true;
            }

            Form FriendsForm = FormFactory.CreateForm(FormFactory.eFormType.FriendsForm, i_FriendsFilter: m_FriendsFilter);
            FriendsForm.ShowDialog();
            Show();
        }

        private void FriendsFilterByGenderForm_Load(object sender, EventArgs e)
        {
        }
    }
}