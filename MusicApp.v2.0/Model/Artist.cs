using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Artist
    {
        public int ID { get; set; }
        public string ArtistName { get; set; }

        public List<Album> Albums { get; set; }


      
    }
}
