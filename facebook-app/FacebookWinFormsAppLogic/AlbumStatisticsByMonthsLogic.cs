using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppLogic
{
    public class AlbumStatisticsByMonthsLogic : AlbumStatisticsLogic
    {
        private const int k_MinMonth = 1;
        private const int k_MaxMonth = 12;
        private const int k_JumpsBetweenEachKey = 1;

        public AlbumStatisticsByMonthsLogic(Album i_Album) : base(i_Album)
        {
        }

        protected override int CreatedTimeValue(Photo i_Photo)
        {
            return i_Photo.CreatedTime.Value.Month;
        }

        protected override int JumpBetweenEachKey()
        {
            return k_JumpsBetweenEachKey;
        }

        protected override int MaxNumberOfKey()
        {
            return k_MaxMonth;
        }

        protected override int MinNumberOfKey()
        {
            return k_MinMonth;
        }
    }
}
