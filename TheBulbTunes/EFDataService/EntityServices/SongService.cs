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

        private List<Song> _songs;

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

        public List<Song> FetchWithFilter(string titleFilter = null, string artistFilter = null,string genreFilter = null,string albumFilter = null)
        {

            //Retrieve all available songs unfiltered 
            _songs = FetchAll();

            if (titleFilter != null)
                _songs = SearchByTitle(titleFilter, _songs);

            if (artistFilter != null)
                _songs = SearchByArtist(artistFilter, _songs);

            if (genreFilter != null)
                _songs = SearchByGenre(genreFilter, _songs);

            if (albumFilter != null)
                _songs = SearchByAlbum(albumFilter, _songs);
            
            return _songs;
        }

        private List<Song> SearchByTitle( string searchValue, List<Song> songs)
        {
            return songs.Where(s => s.Title.Contains(searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private List<Song> SearchByArtist(string searchValue, List<Song> songs)
        {
            return songs.Where(s => s.Artist.Contains(searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private List<Song> SearchByGenre(string searchValue, List<Song> songs)
        {
            return songs.Where(s => s.Genre.Contains(searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
        } 

        private List<Song> SearchByAlbum(string searchValue, List<Song> songs)
        {
            return songs.Where(s => s.Album.Contains(searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
        }

      //Update Song

        public void Update(Guid id, Song songUpdatedInfo)
        {
            //Check if a song with the supplied id exists 

            Song songToUpdate = FetchAll()
                .Where(s => s.SongID == id)
                .FirstOrDefault();

            if (songToUpdate == null)
            {
                Console.WriteLine("Invalid operation! No match was found for the id you supplied");
                return;
            }

            // A match song was found. perform the requested update

            if (songUpdatedInfo.Title != null) songToUpdate.Title = songUpdatedInfo.Title;
            if (songUpdatedInfo.Artist != null) songToUpdate.Artist = songUpdatedInfo.Artist;
            if (songUpdatedInfo.Album != null) songToUpdate.Album = songUpdatedInfo.Artist;
            if (songUpdatedInfo.Genre != null) songToUpdate.Genre = songUpdatedInfo.Genre;
            if (songUpdatedInfo.FeaturedArtist != null) songToUpdate.FeaturedArtist= songUpdatedInfo.FeaturedArtist;
            if (songUpdatedInfo.ReleasedDate != null) songToUpdate.ReleasedDate = songUpdatedInfo.ReleasedDate;

            _context.SaveChanges();
        }

       //Delete Song
       public void Delete (Guid id)
        {

            Song songToDelete = FetchAll()
                .Where(s => s.SongID == id)
                .FirstOrDefault();

            if (songToDelete == null)
            {
                Console.WriteLine("Invalid operation! No match was found for the id you supplied");
                return;
            }

            _context.Songs.Remove(songToDelete);
            _context.SaveChanges();

        }
    }
}
