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
    public partial class AlbumStatisticsByYearsForm : Form
    {
        private readonly AlbumStatisticsByYearsLogic r_AlbumStatisticsByYears;

        public AlbumStatisticsByYearsForm(Album i_Album)
        {
            r_AlbumStatisticsByYears = new AlbumStatisticsByYearsLogic(i_Album);
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            getStatistics();
        }

        private void getStatistics()
        {
            Dictionary<int, int> dictOfStatistics = r_AlbumStatisticsByYears.GetStatisticsAboutAmountOfPhotos();
            
            foreach (KeyValuePair<int, int> item in dictOfStatistics)
            {
                chartAlbumStaisticsByYear.Series["Amount of photos"].Points.AddXY(item.Key, item.Value);
            }
        }

        private void AlbumStatisticsByYearForm_Load(object sender, EventArgs e)
        {
        }
    }
}