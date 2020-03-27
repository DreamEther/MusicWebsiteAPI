using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyMusicWebsite.Models
{
    public class Album
    {
        public int ID { get; set; }

        public int ArtistID { get; set; }

        public string AlbumName { get; set; }

        public DateTime ReleaseDate { get; set; }

        [DisplayFormat(DataFormatString = @"hh\:mm\:ss")]
        public string AlbumLength { get; set; }
    }
}
