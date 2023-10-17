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
    public partial class FindMyMatchForm : Form
    {
        private const int k_LegalAge = 18;
        private readonly UserLogic r_LoggedInUser;

        public FindMyMatchForm()
        {
            r_LoggedInUser = UserLogic.Instance;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            featchCitiesOfFriends();
        }

        private void featchCitiesOfFriends()
        {
            bool checkIfTheCityExists = false;
            List<FriendLogic> friendsList = r_LoggedInUser.FriendsList;

            foreach (FriendLogic friend in friendsList)
            {
                foreach (string city in checkedListBoxCities.Items)
                {
                    if (city.Equals(friend.UserFriend.Location.Name))
                    {
                        checkIfTheCityExists = true;
                        break;
                    }
                }

                if (!checkIfTheCityExists)
                {
                    checkedListBoxCities.Items.Add(friend.UserFriend.Location.Name);
                }

                checkIfTheCityExists = false;
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            FindMyMatchFacade findMyMatchFacade = null;

            if ((r_LoggedInUser.Age >= k_LegalAge && numericUpDownFrom.Value < k_LegalAge) || (numericUpDownFrom.Value > numericUpDownTo.Value))
            {
                MessageBox.Show("Invalid age range ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(comboBoxWithoutFilterOrWithFilter.Text))
            {
                MessageBox.Show("You must choose on of the option: without filter cities or with filter cities", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((comboBoxWithoutFilterOrWithFilter.Text.Equals("with filter") ? true : false) && checkedListBoxCities.SelectedItem == null)
            {
                MessageBox.Show("You must select at least one city", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                findMyMatchFacade = setMyIdealMatch();
                Form myOptionalMatches = FormFactory.CreateForm(i_FormType: FormFactory.eFormType.MyOptionalMatchesForm, i_FindMyMatchFacade: findMyMatchFacade);
                myOptionalMatches.ShowDialog();
                Show();
            }
        }

        private FindMyMatchFacade setMyIdealMatch()
        {
            List<string> cityNameThatSelected = null;
            bool isWithFilterByCities = comboBoxWithoutFilterOrWithFilter.Text.Equals("with filter") ? true : false;
            FindMyMatchFacade findMyMatchFacade = new FindMyMatchFacade(i_MinAge: (int)numericUpDownFrom.Value, i_MaxAge: (int)numericUpDownTo.Value);

            if (isWithFilterByCities)
            {
                cityNameThatSelected = getCitiesNameThatSelect();
                findMyMatchFacade.FilterByCities(cityNameThatSelected);
            }

            if (radioButtonWithoutFilter.Checked == false)
            {
                if (radioButtonMale.Checked == true)
                {
                    findMyMatchFacade.FilterByGender(User.eGender.male);
                }
                else
                {
                    findMyMatchFacade.FilterByGender(User.eGender.female);
                }
            }
    
            return findMyMatchFacade;
        }

        private List<string> getCitiesNameThatSelect()
        {
            List<string> citiesNameThatSelect = new List<string>();

            foreach (string city in checkedListBoxCities.CheckedItems)
            {
                citiesNameThatSelect.Add(city);
            }

            return citiesNameThatSelect;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxWithoutFilterOrWithFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isWithFilterByCities = comboBoxWithoutFilterOrWithFilter.Text.Equals("with filter") ? true : false;
            if (isWithFilterByCities)
            {
                checkedListBoxCities.Visible = true;
            }
            else
            {
                checkedListBoxCities.Visible = false;
            }
        }

        private void FindMyMatchForm_Load(object sender, EventArgs e)
        {
        }
    }
}