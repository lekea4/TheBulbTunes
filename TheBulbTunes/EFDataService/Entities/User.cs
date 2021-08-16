using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBulbTunes.EFDataService.Entities
{
     public class User
    {
        [Required]
        public Guid UserID { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, MaxLength(150)]
        public string EmailAddress { get; set; } 


        //favorite belonging to the user
        public List<Favourite> FavouritesList { get; set; } 
    }
}
