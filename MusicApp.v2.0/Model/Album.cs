using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Album
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Song> Songs { get; set; }

        public int ArtistID { get; set; }

        public Artist Artist { get { return DataContext.Artists.FirstOrDefault(x => x.ID == ArtistID); } }

        //public void LongestSong(Album album)
        //{
        //    int defaultSongDuration = 0;
        //    Song longestSong = null;

        //    for (int i = 0; i < Songs.Count; i++)
        //    {
        //        var song = Songs[i];
        //        if (song.DurationInSeconds > defaultSongDuration)
        //        {
        //            longestSong = song;
        //            defaultSongDuration = song.DurationInSeconds;
        //        }
        //    }
        //}
    }
}
