using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBulbTunes.EFDataService.Entities;

namespace TheBulbTunes.EFDataService.EntityServices
{
    public class SongService
    {

        private readonly TheBulbTunesDBContext _context = new TheBulbTunesDBContext();

        private List<Song> songs = new List<Song> { };

        public SongService()
        {

        }

        //Create a Song 
        public void Create(string title, string artist, string album, string featuredArtist, string genre, DateTime releasedDate)
        {
            Song newSong = new Song
            {
                SongID = new Guid(),
                Title = title,
                Artist = artist,
                Album = album,
                FeaturedArtist = featuredArtist,
                Genre = genre,
                ReleasedDate = releasedDate
            };

            _context.Songs.Add(newSong);
            _context.SaveChanges();
        }

        public List<Song> FetchAll()
        {
            return _context.Songs.ToList();
        }
    }
}
