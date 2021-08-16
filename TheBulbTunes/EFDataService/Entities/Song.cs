using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBulbTunes.EFDataService.Entities
{
   public class Song
    {
        [Required]
        public Guid SongID { get; set; }

        [Required, MaxLength (100)]
        public string Title { get; set; }

        [Required, MaxLength(100)]
        public string Artist { get; set;  }

        [MaxLength(250)]
        public string FeaturedArtist { get; set; }

        [Required, MaxLength(100)]
        public string Album { get; set; }

        [MaxLength(100)]
        public string Genre { get; set; }

        [Required]
        public DateTime ReleasedDate { get; set;  }


        //Favorite referring to this song
        public List<Favourite> FavouritesList { get; set; }

    }
}
