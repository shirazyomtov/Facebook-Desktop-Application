using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppLogic
{
    public class SortedAlbumsByDifferentCategoriesLogic
    {
        private readonly UserLogic r_LoggedInUser;
        private readonly Dictionary<Album, int> r_DictOfAlbumsSortByAmountOfPhotos = new Dictionary<Album, int>();
        private readonly Dictionary<Album, int> r_DictOfAlbumsSortByAmountOfComments = new Dictionary<Album, int>();
        private readonly Dictionary<Album, DateTime?> r_DictOfAlbumsSortByTheLastUpdateAlbum = new Dictionary<Album, DateTime?>();

        public SortedAlbumsByDifferentCategoriesLogic()
        {
            r_LoggedInUser = UserLogic.Instance;
            createDiffrentDictOfAlbums();
        }

        private void createDiffrentDictOfAlbums()
        {
            DateTime? dateOfTheLastPhotoUploaded = null;

            foreach (Album album in r_LoggedInUser.AlbumsList)
            {
                dateOfTheLastPhotoUploaded = getDateOfTheLastPhotoUploaded(album);
                r_DictOfAlbumsSortByTheLastUpdateAlbum.Add(album, dateOfTheLastPhotoUploaded);
                r_DictOfAlbumsSortByAmountOfPhotos.Add(album, album.Photos.Count);
                r_DictOfAlbumsSortByAmountOfComments.Add(album, album.Comments.Count);
            }
        }

        private DateTime? getDateOfTheLastPhotoUploaded(Album i_Album)
        {
            DateTime? dateOfTheLastPhotoUploaded = null;

            foreach (Photo photo in i_Album.Photos)
            {
                if (dateOfTheLastPhotoUploaded == null)
                {
                    dateOfTheLastPhotoUploaded = photo.CreatedTime;
                }
                else
                {
                    if (dateOfTheLastPhotoUploaded.Value.Date < photo.CreatedTime.Value.Date)
                    {
                        dateOfTheLastPhotoUploaded = photo.CreatedTime;
                    }
                }
            }

            return dateOfTheLastPhotoUploaded;
        }

        public IOrderedEnumerable<KeyValuePair<Album, int>> SortAlbumsByAmountOfPhotos()
        {
            return sortAlbumsByAmountOfPhotosOrComments(r_DictOfAlbumsSortByAmountOfPhotos);
        }

        public IOrderedEnumerable<KeyValuePair<Album, int>> SortAlbumsByAmountOfComments()
        {
            return sortAlbumsByAmountOfPhotosOrComments(r_DictOfAlbumsSortByAmountOfComments);
        }

        public IOrderedEnumerable<KeyValuePair<Album, DateTime?>> SortAlbumsByTheLastPhotoUploaded()
        {
            var sortedDict = from entry in r_DictOfAlbumsSortByTheLastUpdateAlbum orderby entry.Value descending select entry;

            return sortedDict;
        }

        private IOrderedEnumerable<KeyValuePair<Album, int>> sortAlbumsByAmountOfPhotosOrComments(Dictionary<Album, int> i_DictSort)
        {
            var sortedDict = from entry in i_DictSort orderby entry.Value descending select entry;

            return sortedDict;
        }
    }
}