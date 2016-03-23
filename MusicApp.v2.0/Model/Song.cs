using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Song
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DurationInSeconds { get; set; }
        public int AlbumID { get; set; }

        public Album Album { get {
                return DataContext.Albums.FirstOrDefault(x => x.ID == AlbumID);
            } }
    }
}
