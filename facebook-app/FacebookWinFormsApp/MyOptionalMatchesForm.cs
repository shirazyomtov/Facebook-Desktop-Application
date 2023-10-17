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
    public partial class MyOptionalMatchesForm : Form
    {
        private readonly FindMyMatchFacade r_FindMyMatchFacade;
        private List<FriendLogic> m_OptionalMatchWithoutSorted;
        private IOrderedEnumerable<KeyValuePair<FriendLogic, int>> m_OptionalMatchSortedByTheHighestMatch = null;

        public MyOptionalMatchesForm(FindMyMatchFacade i_FindMyMatchFacade)
        {
            r_FindMyMatchFacade = i_FindMyMatchFacade;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_OptionalMatchWithoutSorted = r_FindMyMatchFacade.OpitionalMatchesWithoutSorted;
            new Thread(fetchMyOptionalMatchesAndMakeControlsEnabled).Start();
        }

        private void fetchMyOptionalMatchesAndMakeControlsEnabled()
        {
           new Thread(fetchMyOptionalMatches).Start();
           new Thread(makeControlsEnabled).Start();
        }

        private void fetchMyOptionalMatches()
        {
            listBoxOptionalMatches.Invoke(new Action(() => listBoxOptionalMatches.Items.Clear()));
            listBoxOptionalMatches.Invoke(new Action(() => listBoxOptionalMatches.DisplayMember = "Name"));
            try
            {
                foreach (FriendLogic friend in m_OptionalMatchWithoutSorted)
                {
                   listBoxOptionalMatches.Invoke(new Action(() => listBoxOptionalMatches.Items.Add(friend)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxOptionalMatches.Items.Count == 0)
            {
                MessageBox.Show("No matches found for you", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void makeControlsEnabled()
        {
            radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.Invoke(new Action(() => radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.Enabled = true));
            radioButtonShowMyOptionalMatchesWithoutOrder.Invoke(new Action(() => radioButtonShowMyOptionalMatchesWithoutOrder.Enabled = true));
        }

        private void radioButtonShowMyOptionalMatchesWithoutOrder_CheckedChanged(object sender, EventArgs e)
        {
            fetchMyOptionalMatches();
        }

        private void radioButtonShowMyOptionalMatchesSortedByTheHighestMatch_CheckedChanged(object sender, EventArgs e)
        {
            if (m_OptionalMatchSortedByTheHighestMatch == null)
            {
                m_OptionalMatchSortedByTheHighestMatch = r_FindMyMatchFacade.OpitionalMatchesSortedByTheHighestMatch;
            }

            listBoxOptionalMatches.Items.Clear();
            listBoxOptionalMatches.DisplayMember = "Name";
            foreach (KeyValuePair<FriendLogic, int> kvp in m_OptionalMatchSortedByTheHighestMatch)
            {
                listBoxOptionalMatches.Items.Add(kvp.Key);
            }
        }

        private void listBoxOptionalMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOptionalMatches.SelectedItems.Count == 1)
            {
                FriendLogic selectedMatch = listBoxOptionalMatches.SelectedItem as FriendLogic;
                Form selectedMatchForm = FormFactory.CreateForm(i_FormType: FormFactory.eFormType.SelectedMatchForm, i_SelectedMatch: selectedMatch, i_FindMyMatchFacade: r_FindMyMatchFacade);
                selectedMatchForm.ShowDialog();
                Show();
            }
        }

        private void MyOptionalMatchesForm_Load(object sender, EventArgs e)
        {
        }
    }
}