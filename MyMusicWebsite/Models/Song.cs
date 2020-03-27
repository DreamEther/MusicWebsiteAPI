using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyMusicWebsite.Models
{
    public class Song
    {
        public int ID { get; set; }

        public int ArtistID { get; set; }

        public int AlbumID { get; set; }
        public string SongName { get; set; }
        
        [DisplayFormat(DataFormatString = @":mm\:ss")]
        public string Length { get; set; }
           
    }
}
