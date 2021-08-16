using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBulbTunes.EFDataService.Entities
{
    public class Favourite
    {
        [Required]
        public Guid ID { get; set; }

        [Required]
        public Guid SelectedSongID { get; set; }

        [Required]
        public Guid AddedByID { get; set; }

        [Required]

        public DateTime DateAdded { get; set; }



        
        //The following are navigation properties made possible by the foreign-key relationships 
        public virtual Song SelectedSong { get; set; }

        public virtual User AddedBy  { get; set; }



    }
}
