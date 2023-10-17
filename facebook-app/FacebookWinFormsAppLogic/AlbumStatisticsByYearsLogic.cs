using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppLogic
{
    public class AlbumStatisticsByYearsLogic : AlbumStatisticsLogic
    {
        private const int k_YearPublishFacebook = 2006;
        private const int k_JumpsBetweenEachKey = 1;

        public AlbumStatisticsByYearsLogic(Album i_Album) : base(i_Album)
        { 
        }

        protected override int CreatedTimeValue(Photo i_Photo)
        {
            return i_Photo.CreatedTime.Value.Year;
        }

        protected override int JumpBetweenEachKey()
        {
            return k_JumpsBetweenEachKey;
        }

        protected override int MaxNumberOfKey()
        {
            return DateTime.Now.Year;
        }

        protected override int MinNumberOfKey()
        {
            return k_YearPublishFacebook;
        }
    }
}
