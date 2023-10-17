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
    public partial class AlbumStatisticsByMonthsForm : Form
    {
        private readonly AlbumStatisticsByMonthsLogic r_AlbumStatisticsByMonths;

        public AlbumStatisticsByMonthsForm(Album i_Album)
        {
            r_AlbumStatisticsByMonths = new AlbumStatisticsByMonthsLogic(i_Album);
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            getStatistics();
        }

        private void getStatistics()
        {
            Dictionary<int, int> dictOfStatistics = r_AlbumStatisticsByMonths.GetStatisticsAboutAmountOfPhotos();

            foreach (KeyValuePair<int, int> item in dictOfStatistics)
            {
                chartAlbumStaisticsByMonth.Series["Amount of photos"].Points.AddXY(item.Key, item.Value);
            }
        }

        private void AlbumStatisticsByMonthForm_Load(object sender, EventArgs e)
        {
        }
    }
}