using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppLogic
{
    public abstract class AlbumStatisticsLogic
    {
        private readonly Album r_Album;

        public AlbumStatisticsLogic(Album i_Album)
        {
            r_Album = i_Album;
        }

        protected abstract int MinNumberOfKey();

        protected abstract int JumpBetweenEachKey();

        protected abstract int MaxNumberOfKey();

        protected abstract int CreatedTimeValue(Photo i_Photo);

        public Dictionary<int, int> GetStatisticsAboutAmountOfPhotos()
        {
            int i;
            bool photoCreatedTimeValueInRange = false;
            int minNumberOfX = MinNumberOfKey();
            int maxNumberOfX = MaxNumberOfKey();
            int jumpsBetweenEachX = JumpBetweenEachKey();
            Dictionary<int, int> statisticsAboutAmountOfPhotos = new Dictionary<int, int>();
            initDictOfStatisticsAboutAmountOfPhotos(ref statisticsAboutAmountOfPhotos);

            foreach (Photo photo in r_Album.Photos)
            {
                for (i = minNumberOfX; i <= maxNumberOfX; i = i + jumpsBetweenEachX)
                {
                    if (CreatedTimeValue(photo) == i)
                    {
                        photoCreatedTimeValueInRange = true;
                        break;
                    }
                }

                if (photoCreatedTimeValueInRange)
                {
                    statisticsAboutAmountOfPhotos[CreatedTimeValue(photo)]++;
                }

                photoCreatedTimeValueInRange = false;
            }

            return statisticsAboutAmountOfPhotos;
        }

        private void initDictOfStatisticsAboutAmountOfPhotos(ref Dictionary<int, int> io_StatisticsAboutAmountOfPhotos)
        {
            int i;
            int minNumberOfX = MinNumberOfKey();
            int maxNumberOfX = MaxNumberOfKey();
            int jumpsBetweenEachX = JumpBetweenEachKey();

            for (i = minNumberOfX; i <= maxNumberOfX; i = i + jumpsBetweenEachX)
            {
                io_StatisticsAboutAmountOfPhotos.Add(i, 0);
            }
        }
    }
}