using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBulbTunes.EFDataService.Entities;
using Microsoft.EntityFrameworkCore;

namespace TheBulbTunes.EFDataService.EntityServices
{
    public class FavouriteService
    {
        private readonly TheBulbTunesDBContext _context = new TheBulbTunesDBContext();

        private List<Favourite> _favourites;

        

        //Create a Favorite  

        public void Create(Guid songId, Guid userId )
        {
            Song song = _context.Songs.Find(songId);
            User user = _context.Users.Find(userId);


            Favourite newFav = new Favourite()
            {
                ID = new Guid(),
                SelectedSong = song,
                AddedBy = user,
                DateAdded = DateTime.Now

            };
            _context.Favourites.Add(newFav);
            _context.SaveChanges();

        }

        public List<Favourite> FetchAll()
        {
            return _context.Favourites
                .Include(f => f.AddedBy)
                .Include(f => f.SelectedSong)
                .ToList();
        }


        //Private Helper Methods to simplify searching various Parameters 
        private List<Favourite> SearchByTitle(string searchValue, List<Favourite> favourites)
        {
            return favourites.Where(f => f.SelectedSong.Title.Contains(searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private List<Favourite> SearchByArtist(string searchValue, List<Favourite> favourites)
        {
            return favourites.Where(f => f.SelectedSong.Artist.Contains(searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private List<Favourite> SearchByUser(string searchValue, List<Favourite> favourites)
        {
            return favourites
                .Where(f =>
               f.AddedBy.FirstName.Contains(searchValue, StringComparison.OrdinalIgnoreCase) ||
               f.AddedBy.LastName.Contains(searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        //FetchWithFilter Method 
        public List<Favourite> FetchWithFilter(string titleFilter = null, string userFilter = null, string artistFilter = null)
        {
            //Retrieve all available favorite unfiltered 
            _favourites = FetchAll();

            //If any filter is specified, apply that filter by calling it's search method 

            if (titleFilter != null)
                _favourites = SearchByTitle(titleFilter, _favourites);

            if (userFilter != null)
                _favourites = SearchByUser(userFilter, _favourites);

            if (artistFilter != null)
                _favourites = SearchByArtist(artistFilter, _favourites);



            return _favourites;
        }


        //Delete a favorite
        public void Delete (Guid id)
        {
            Favourite favouriteToDelete = FetchAll()
                .Where(f => f.ID == id)
                .FirstOrDefault();



            /*second method to write the delete method

           favouriteToDelete = _context.Favourites.Find(id);
            */

            //A matching song was found. Perform the requested deletion.
            _context.Favourites.Remove(favouriteToDelete);
            _context.SaveChanges();
        }
        
    }
}
