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
    public partial class AlbumsForm : Form
    {
        private readonly UserLogic r_LoggedInUser;
        private SortedAlbumsByDifferentCategoriesLogic m_SortedAlbumsByDifferentCategories;
        private IOrderedEnumerable<KeyValuePair<Album, DateTime?>> m_SortAlbumsByTheLastPhotoUploaded;
        private IOrderedEnumerable<KeyValuePair<Album, int>> m_SortAlbumsByAmountOfComments;
        private IOrderedEnumerable<KeyValuePair<Album, int>> m_SortAlbumsByAmountOfPhotos;
        private int m_Index = 0;
        private bool m_IsClicked = false;

        public AlbumsForm()
        {
            r_LoggedInUser = UserLogic.Instance;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchAlbumsAndCreateObjectsOfAlbumsThatSortedByDifferentCategories).Start();
        }

        private void fetchAlbumsAndCreateObjectsOfAlbumsThatSortedByDifferentCategories()
        {
            m_SortedAlbumsByDifferentCategories = new SortedAlbumsByDifferentCategoriesLogic();
            m_SortAlbumsByAmountOfComments = m_SortedAlbumsByDifferentCategories.SortAlbumsByAmountOfComments();
            m_SortAlbumsByAmountOfPhotos = m_SortedAlbumsByDifferentCategories.SortAlbumsByAmountOfPhotos();
            m_SortAlbumsByTheLastPhotoUploaded = m_SortedAlbumsByDifferentCategories.SortAlbumsByTheLastPhotoUploaded();
            new Thread(fetchAlbums).Start();
            new Thread(makeControlsEnabled).Start();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Clear()));
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DisplayMember = "Name"));
            try
            {
                foreach (Album album in r_LoggedInUser.AlbumsList)
                {
                    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void makeControlsEnabled()
        {
            buttonPhotosInTheAlbum.Invoke(new Action(() => buttonPhotosInTheAlbum.Enabled = true));
            buttonAlbumStatistics.Invoke(new Action(() => buttonAlbumStatistics.Enabled = true));
            comboBoxYearOrMonth.Invoke(new Action(() => comboBoxYearOrMonth.Enabled = true));
            radioButtonShowWithoutOrder.Invoke(new Action(() => radioButtonShowWithoutOrder.Enabled = true));
            radioButtonSortByAmountsOfComments.Invoke(new Action(() => radioButtonSortByAmountsOfComments.Enabled = true));
            radioButtonSortoByAmountsOfPhotos.Invoke(new Action(() => radioButtonSortoByAmountsOfPhotos.Enabled = true));
            radioButtonSortByLastUpdatedAlbum.Invoke(new Action(() => radioButtonSortByLastUpdatedAlbum.Enabled = true));
            buttonBack.Invoke(new Action(() => buttonBack.Enabled = true));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPhoto.Image = null;
            m_IsClicked = false;
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;

                labelAmountOfPhotos.Visible = true;
                labelAmountOfComments.Visible = true;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxCoverPhoto.LoadAsync(selectedAlbum.PictureAlbumURL);
                }

                labelAmountOfPhotos.Text = string.Format("Amount of photos in the album: {0}", selectedAlbum.Photos.Count);
                labelAmountOfComments.Text = string.Format("Amount of comments in the album: {0}", selectedAlbum.Comments.Count);
            }
        }

        private void buttonPhotosInTheAlbum_Click(object sender, EventArgs e)
        {
            m_Index = 0;
            m_IsClicked = true;
            fetchThePhotosOfTheAlbum();
        }

        private void fetchThePhotosOfTheAlbum()
        {
            try
            {
                if (listBoxAlbums.SelectedItems.Count == 1)
                {
                    if (m_IsClicked)
                    {
                        Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                        Photo photo = selectedAlbum.Photos[m_Index];

                        buttonPrev.Visible = true;
                        buttonNext.Visible = true;
                        pictureBoxPhoto.LoadAsync(photo.PictureAlbumURL);
                    }
                    else
                    {
                        MessageBox.Show("Error: you need to press on the button 'Go to the photos in the album'");
                    }
                }
                else
                {
                    MessageBox.Show("Error: you need to select one album", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonSortByLastUpdatedAlbum_CheckedChanged(object sender, EventArgs e)
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            foreach (KeyValuePair<Album, DateTime?> kvp in m_SortAlbumsByTheLastPhotoUploaded)
            {
                listBoxAlbums.Items.Add(kvp.Key);
            }
        }

        private void radioButtonSortByAmountsOfComments_CheckedChanged(object sender, EventArgs e)
        {
            addToListBox(m_SortAlbumsByAmountOfComments);
        }

        private void radioButtonSortoByAmountsOfPhotos_CheckedChanged(object sender, EventArgs e)
        {
            addToListBox(m_SortAlbumsByAmountOfPhotos);
        }

        private void addToListBox(IOrderedEnumerable<KeyValuePair<Album, int>> i_SortByCommentsOrPhotos)
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            foreach (KeyValuePair<Album, int> kvp in i_SortByCommentsOrPhotos)
            {
                listBoxAlbums.Items.Add(kvp.Key);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            m_Index++;
            fetchThePhotosOfTheAlbum();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            m_Index--;
            fetchThePhotosOfTheAlbum();
        }

        private void radioButtonShowWithoutOrder_CheckedChanged(object sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void buttonAlbumStatistics_Click(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;

                if (!string.IsNullOrEmpty(comboBoxYearOrMonth.Text))
                {
                    bool isYear = comboBoxYearOrMonth.Text.Equals("Years") ? true : false;
                    Form albumStatisticsByYearOrMonth = FormFactory.CreateForm(i_FormType: FormFactory.eFormType.AlbumStatisticsByYearOrMonthForm, i_Album: selectedAlbum, i_IsYear: isYear);
                    albumStatisticsByYearOrMonth.ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show("You must choose on of the option: Years or Months");
                }
            }
            else
            {
                MessageBox.Show("You have to choose one album", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LikeForm_Load(object sender, EventArgs e)
        {
        }
    }
}