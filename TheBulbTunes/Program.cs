using System;
using System.Collections.Generic;
using TheBulbTunes.EFDataService.Entities;
using TheBulbTunes.EFDataService.EntityServices;

namespace TheBulbTunes
{
    class Program
    {
        static void Main(string[] args)
        {
            SongService songService = new SongService();

            #region Using the Fetch with Filter Method 
            List<Song> filteredSong1 = songService.FetchWithFilter("over", "romantic", null, null);
            List<Song> filteredSong2 = songService.FetchWithFilter("Ess", "r", "lagos", "kid");

            Console.WriteLine("\n\nFILTERED SONGS FOR JANE\n");
            Console.Write("Title\t\tArtist\t\tAlbum");
            foreach (Song song in filteredSong1)
            {
                Console.WriteLine();
                Console.Write($"{song.Title}\t{song.Artist}\t{song.Album}");
            }

            Console.WriteLine("\n\nFILTERED SONGS FOR HOPE\n");
            Console.Write("Title\t\tArtist\t\tAlbum");
            foreach (Song song in filteredSong2)
            {
                Console.WriteLine();
                Console.Write($"{song.Title}\t{song.Artist}\t{song.Album}");
            }
            Console.WriteLine("\n\n\n");

            #endregion

            #region Create a number of songs with the Create Method and fetching the list with the fetch all method 

            //songService.Create("All Over", "Tiwa Savage","Sugarcane","","Afro-pop, Romantic",new DateTime(2017, 5, 22));
            //songService.Create("Nobody's Business","Rihanna","Unapologetic","Chris Brown","R&B",new DateTime(2012,1,1));
            //songService.Create("Get Down On It","Kool & The Gang","Something Special","", "Funk",new DateTime(1981,11,1));
            //songService.Create("The Monster","Eminem","Marshal Mathers","Rihanna","Rap/R&B",new DateTime(2013,1,1));
            //songService.Create("Essence","Wizkid","Made In Lagos","Tems","R&B",new DateTime(2020,10,30));
            ////songService.Create("", "", "", "", "", new DateTime());

            ////Fetch all Songs
            //List<Song> availableSongs = songService.FetchAll();
            //Console.WriteLine("Title \t\tArtist\t\tAlbum");

            //foreach (Song song in availableSongs)
            //{
            //    Console.WriteLine();
            //    Console.Write($"{song.Title}\t\t{song.Artist}\t\t{song.Album}");
            //}

#endregion
        }
    }
}
